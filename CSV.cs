using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Practical
{
    static public class CSV
    {
        /// <summary>
        /// Сохраняет данные из компонента DataGridView в формате CSV
        /// Если файл с данным именем существует, он будет перезаписан
        /// </summary>
        /// <param name="filename">Название файла</param>
        /// <returns></returns>
        static public bool Save(string filename, DataGridView dataGridView)
        {
            StreamWriter streamWriter = new StreamWriter(filename, false, Encoding.UTF8);
            try
            {

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    streamWriter.Write(dataGridView.Columns[i].Name + (i == dataGridView.Columns.Count - 1 ? "" : ";"));
                }
                streamWriter.Write(Environment.NewLine);
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                    {
                        streamWriter.Write(dataGridView.Rows[i].Cells[j].Value + (j == dataGridView.Rows[i].Cells.Count - 1 ? "" : ";"));
                    }
                    streamWriter.Write(Environment.NewLine);
                }
                streamWriter.Close();
                streamWriter.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                streamWriter.Close();
                streamWriter.Dispose();
                return false;
            }
                
        }
    }
}
