using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical
{
    public class StatusBar
    {
        RichTextBox _statusBar;
        public StatusBar(RichTextBox richTextBox)
        {
            _statusBar = richTextBox;
        }
        public enum TYPE
        {
            ERROR,
            OK,
            INFO,
            SHUTDOWN
        }
        string _log = "";
        public void WriteLog()
        {
            File.WriteAllText($"{DateTime.Now.ToShortDateString().Replace('.','-')}-{DateTime.Now.ToShortTimeString().Replace(':','-')}.log", _log);
        }
        public void Show(string message, TYPE type)
        {
            if (message.Trim() == "")
                return;
            string prefix;
            Color color;
            switch (type)
            {
                case (TYPE.INFO):
                    prefix = "[INFO]";
                    color = Color.Gray;
                    break;

                case (TYPE.ERROR):
                    prefix = "[ERROR]";
                    color = Color.Red;
                    break;
                case (TYPE.OK):
                    prefix = "[OK]";
                    color = Color.Green;
                    break;
                case (TYPE.SHUTDOWN):
                    prefix = "[SHUTDOWN]";
                    color = Color.Green;
                    break;
                default:
                    color = Color.Gray;
                    prefix = "";
                    break;
            }
            string ToShow = $"{DateTime.Now.ToLongTimeString()}{prefix}: {message}";
            _log += ToShow + "\n";
            _statusBar.Text = ToShow;
            _statusBar.SelectAll();
            _statusBar.SelectionColor = color;
        }
    }
}
