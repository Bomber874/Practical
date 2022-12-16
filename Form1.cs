using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
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
            foreach(string service in txt)
            {
                serviceTypeInput.Items.Add(service);
            }
        }

        private void orderNumber_ValueChanged(object sender, EventArgs e)
        {
            statusBar.Show("№Заказа:"+orderNumber.Value, StatusBar.TYPE.INFO);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            statusBar.Show("Завершение работы, причина:"+e.CloseReason.ToString(), StatusBar.TYPE.SHUTDOWN);
            statusBar.WriteLog();
        }

        private void dateInput_TextChanged(object sender, EventArgs e)
        {
            statusBar.Show("Дата:" + dateInput.Text, StatusBar.TYPE.INFO);
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            statusBar.Show("Название/ФИО:" + nameInput.Text, StatusBar.TYPE.INFO);
        }

        private void serviceInput_TextChanged(object sender, EventArgs e)
        {
            statusBar.Show("Услуга:" + serviceInput.Text, StatusBar.TYPE.INFO);
        }

        private void serviceTypeInput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            statusBar.Show("Вид услуги:" + serviceTypeInput.Text, StatusBar.TYPE.INFO);
        }

        private void discountInput_ValueChanged(object sender, EventArgs e)
        {
            statusBar.Show("Скидка:" + discountInput.Value, StatusBar.TYPE.INFO);
        }

        private void costInput_TextChanged(object sender, EventArgs e)
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
            if (!Parser.Date(dateInput.Text))
            {
                Notify("Некорректная дата услуги", StatusBar.TYPE.ERROR);
                return;
            }
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

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            statusBar.Show("Объём услуги:" + timeInput.Text, StatusBar.TYPE.INFO);
        }
    }
}
