using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public partial class SaveForm : Form
    {
        public bool SaveFile = false;
        public string FileName;
        public SaveForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!Parser.File(fileNameInput.Text))
            {
                MessageBox.Show($"Некорректное название файла\nВы ввели:{fileNameInput.Text}");
                return;
            }
            if (!fileNameInput.Text.EndsWith(".csv"))
            {
                fileNameInput.Text = fileNameInput.Text + ".csv";
            }
            FileName = fileNameInput.Text;
            SaveFile = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
