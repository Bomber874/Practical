using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Practical
{
    public partial class Form1 : Form
    {
        StatusBar statusBar;
        public string logFileName = "";
        bool AllowEdit = false; // Необходимо для избежания случайного ввода данных

        void Notify(string message, StatusBar.TYPE type)
        {
            statusBar.Show(message, type);
            SystemSounds.Beep.Play();
            MessageBox.Show(message);
        }

        public Form1()
        {
            InitializeComponent();
            logFileName = $"logs/{DateTime.Now.ToShortDateString().Replace('.', '-')}-{DateTime.Now.ToShortTimeString().Replace(':', '-')}.log";
            statusBar = new StatusBar(statusBarText, logFileName);
            statusBar.Show("Программа запущена", StatusBar.TYPE.OK);
        }

        string[] ReadText(string filePath)
        {
            string[] txt = { };
            try
            {
                txt = File.ReadAllLines(filePath);
                return txt;
            }
            catch (FileNotFoundException)
            {
                Notify("Не найден файл "+filePath, StatusBar.TYPE.ERROR);
                return null;
            }
            catch (Exception ex)
            {
                Notify("Непредвиденная ошибка:" + ex.Message, StatusBar.TYPE.ERROR);
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var txt = File.ReadAllLines("input.txt");

                foreach (string service in txt)
                {
                    serviceTypeInput.Items.Add(service);
                }
            }
            catch (FileNotFoundException)
            {
                Notify("Не найден файл input.txt", StatusBar.TYPE.ERROR);
                this.Close();
            }
            catch (Exception ex)
            {
                Notify("Непредвиденная ошибка:"+ex.Message, StatusBar.TYPE.ERROR);
                this.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            statusBar.Show("Завершение работы, причина:" + e.CloseReason.ToString(), StatusBar.TYPE.SHUTDOWN);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены?", "Выйти из программы",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void orderNumber_Leave(object sender, EventArgs e)
        {
            statusBar.Show("№Заказа:" + orderNumber.Value, StatusBar.TYPE.INFO);
        }

        private void dateInput_Leave(object sender, EventArgs e)
        {
            statusBar.Show("Дата:" + dateInput.Text, StatusBar.TYPE.INFO);
        }

        private void nameInput_Leave(object sender, EventArgs e)
        {
            statusBar.Show("Название/ФИО:" + nameInput.Text, StatusBar.TYPE.INFO);
        }

        private void serviceInput_Leave(object sender, EventArgs e)
        {
            statusBar.Show("Услуга:" + serviceInput.Text, StatusBar.TYPE.INFO);
        }

        private void serviceTypeInput_Leave(object sender, EventArgs e)
        {
            statusBar.Show("Вид услуги:" + serviceTypeInput.Text, StatusBar.TYPE.INFO);
        }

        private void discountInput_Leave(object sender, EventArgs e)
        {
            statusBar.Show("Скидка:" + discountInput.Value, StatusBar.TYPE.INFO);
        }

        private void costInput_Leave(object sender, EventArgs e)
        {
            statusBar.Show("Стоимость услуги:" + costInput.Text, StatusBar.TYPE.INFO);
        }

        private void donePanel_CheckedChanged(object sender, EventArgs e)
        {
            if (donePanel.Checked)
                statusBar.Show("Услуга выполнена", StatusBar.TYPE.INFO);
            else
                statusBar.Show("Услуга не выполнена", StatusBar.TYPE.INFO);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Понятия не имею, могут ли совпадать номера заказов, пусть будет что могут
            //if (!Parser.Date(dateInput.Text))
            //{
            //    Notify("Некорректная дата услуги", StatusBar.TYPE.ERROR);
            //    return;
            //}
            if (!Parser.Name(nameInput.Text))
            {
                Notify("Некорректное ФИО/Название", StatusBar.TYPE.ERROR);
                return;
            }
            if (!Parser.Name(serviceInput.Text))
            {
                Notify("Некорректное название услуги", StatusBar.TYPE.ERROR);
                return;
            }
            if (serviceTypeInput.Text == "")
            {
                Notify("Выберите вид услуги из списка", StatusBar.TYPE.ERROR);
                return;
            }
            if (!Parser.Time(timeInput.Text))
            {
                Notify("Некорректый объём услуги", StatusBar.TYPE.ERROR);
                return;
            }
            if (!Parser.Cost(costInput.Text))
            {
                Notify("Некорректая стоимость услуги", StatusBar.TYPE.ERROR);
                return;
            }
            dataGridView1.Rows.Add(orderNumber.Value,
                dateInput.Text,
                nameInput.Text,
                serviceInput.Text,
                serviceTypeInput.Text,
                timeInput.Text,
                discountInput.Value,
                costInput.Text,
                donePanel.Checked);
            statusBar.Show("Запись сохранена", StatusBar.TYPE.OK);
        }

        private void timeInput_Leave(object sender, EventArgs e)
        {
            // Чтобы сработало, пришлось в маске отказаться от пробелов, в качестве разделителей
            // Также, оказалось, что timeInput.Text возвращает timeInput.Text.Trim(), поэтому в конец маски добавил \.
            timeInput.Text = timeInput.Text.Replace(' ', '0');
            statusBar.Show("Объём услуги:" + timeInput.Text, StatusBar.TYPE.INFO);
        }

        void saveRequest()
        {
            SaveForm saveForm = new SaveForm();
            saveForm.ShowDialog(); // saveForm.Show(); Не подойдет, т.к. тогда выполнение кода продолжится
            if (saveForm.SaveFile)
            {
                if (CSV.Save(saveForm.FileName, dataGridView1))
                    statusBar.Show($"Успешная выгрузка в файл:{saveForm.FileName}", StatusBar.TYPE.OK);
                else
                    statusBar.Show($"Ошибка при выгрузке файла{saveForm.FileName}", StatusBar.TYPE.ERROR);
            }
        }

        private void saveTableToFile_Click(object sender, EventArgs e)
        {
            saveRequest();
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            saveRequest();
        }

        private void clearMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены?\nИнформация удалится без возможности восстановления", "Очистить таблицу",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        dataGridView1[i, j].Value = null;
                    }
                }
            }
            dataGridView1.RowCount = 1;
        }

        string oldCellValue = "";
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!AllowEdit)
            {
                e.Cancel = true;
                return;
            }
            if (dataGridView1[e.ColumnIndex, e.RowIndex].Value != null)
            {
                oldCellValue = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            else
            {
                oldCellValue = "";
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1[e.ColumnIndex, e.RowIndex].Value == null)
            {
                statusBar.Show($"Ячейка[{e.ColumnIndex}:{e.RowIndex}] Очищенна. Старое значение:{oldCellValue}", StatusBar.TYPE.INFO);
                return;
            }
            if(oldCellValue != dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString())
                statusBar.Show($"Ячейка[{e.ColumnIndex}:{e.RowIndex}] Старое значение:{oldCellValue}, Новое значение:{dataGridView1[e.ColumnIndex, e.RowIndex].Value}", StatusBar.TYPE.INFO);
        }

        bool _isFirstTime = true;
        private void enableEditMenuItem_Click(object sender, EventArgs e)
        {
            if (_isFirstTime)
            {
                var result = MessageBox.Show("Включайте редактирование только в том случае, если вы проинструктированы\n"+
                    "О последствиях неверного ввода данных в таблицу\n"+
                    "Если потребность в редактировании таблицы отпала, отключите её редактирование\n"+
                    "Включить редактирование?", "Внимание, опасность",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    statusBar.Show("Включено редактирование таблицы", StatusBar.TYPE.OK);
                    AllowEdit = true;
                    _isFirstTime = false; // Чтобы не спрашивала каждый раз
                }
            }
            
        }

        private void disableMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Show("Отключено редактирование таблицы", StatusBar.TYPE.OK);
            AllowEdit = false;
        }

        private void openLogButton1_Click(object sender, EventArgs e)
        {
            var log = ReadText(logFileName); if (log == null)
            {
                return;
            }
            LogViewForm viewForm = new LogViewForm(log);
            viewForm.ShowDialog();
        }

        //private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (!dataGridView1.Focused) // Это событие вызывается не только при изменении значения клетки пользователем
        //        return;
        //    MessageBox.Show(sender.ToString());
        //    statusBar.Show($"Ячейка[{e.ColumnIndex}:{e.RowIndex}] Новое значение:{dataGridView1[e.ColumnIndex,e.RowIndex].Value}", StatusBar.TYPE.INFO);

        //}


    }
}
