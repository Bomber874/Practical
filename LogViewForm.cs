using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public partial class LogViewForm : Form
    {
        string[] logText;
        public LogViewForm(string[] log)
        {
            InitializeComponent();
            logText = log;
        }

        private void LogViewForm_Load(object sender, EventArgs e)
        {
            Regex error = new Regex(@"^\d?\d:\d\d:\d\d\[ERROR\]:.+$");
            Regex ok = new Regex(@"^\d?\d:\d\d:\d\d\[OK\]:.+$");    // Если бы нужна была необходимость подсветки больших типов сообщений, сделал бы массив
            foreach (string line in logText)
            {
                if (ok.IsMatch(line))   // Было бы больше, написал бы метод(я не лентяй)
                {
                    //richTextBox1.SelectionStart = richTextBox1.TextLength;
                    //MessageBox.Show(richTextBox1.SelectionStart+"");
                    richTextBox1.AppendText(line + Environment.NewLine);
                    richTextBox1.Select(richTextBox1.TextLength - line.Length, line.Length);
                    //MessageBox.Show(richTextBox1.SelectionStart + "");
                    //richTextBox1.SelectionLength = line.Length;
                    richTextBox1.SelectionColor = Color.Green;
                    //MessageBox.Show(richTextBox1.SelectionStart+" "+richTextBox1.SelectionLength);
                }
                else if (error.IsMatch(line))
                {
                    richTextBox1.AppendText(line + Environment.NewLine);
                    richTextBox1.Select(richTextBox1.TextLength - line.Length, line.Length);
                    richTextBox1.SelectionColor = Color.Red;
                }
                else
                    richTextBox1.AppendText(line + Environment.NewLine);  // Можно сделать какую-нибудь подсветку, но я не придумал какую
            }
            richTextBox1.Select(0, 0);
        }
    }
}
