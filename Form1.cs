using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Practical
{
    public partial class Form1 : Form
    {
        StatusBar statusBar;

        void Notify(string message, StatusBar.TYPE type)
        {
            statusBar.Show(message, type);
            SystemSounds.Beep.Play();
            MessageBox.Show(message);
        }

        public Form1()
        {
            InitializeComponent();
            statusBar = new StatusBar(statusBarText);
            statusBar.Show("Программа запущена", StatusBar.TYPE.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var txt = File.ReadAllLines("input.txt");
            foreach (string service in txt)
            {
                serviceTypeInput.Items.Add(service);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            statusBar.Show("Завершение работы, причина:" + e.CloseReason.ToString(), StatusBar.TYPE.SHUTDOWN);
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
            if (nameInput.Text == "")
            {
                Notify("Выберите ФИО/Название", StatusBar.TYPE.ERROR);
                return;
            }
            if (serviceInput.Text == "")
            {
                Notify("Введите название услуги", StatusBar.TYPE.ERROR);
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

        private void saveTableToFile_Click(object sender, EventArgs e)
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
    }
}
