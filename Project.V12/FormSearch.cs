using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.V12.Lib;
using System.IO;

namespace Project.V12
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        DataService ds = new DataService();
        private void FormSearch_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(39, 51, 65);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewDataService.Rows.Clear();
            string path = @"C:\Users\blitz\source\repos\Tyuiu.SorokinAD.Sprint7\DataService.csv";
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_mas[j];
                }
            }
            dataGridViewDataService.RowCount = rows;
            dataGridViewDataService.ColumnCount = columns;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (array[r, c] == textBoxSelectPC.Text)
                    {
                        dataGridViewDataService.Rows[r].Cells[0].Value = array[r, 0];
                        dataGridViewDataService.Rows[r].Cells[1].Value = array[r, 1];
                        dataGridViewDataService.Rows[r].Cells[2].Value = array[r, 2];
                        dataGridViewDataService.Rows[r].Cells[3].Value = array[r, 3];
                        dataGridViewDataService.Rows[r].Cells[4].Value = array[r, 4];
                        dataGridViewDataService.Rows[r].Cells[5].Value = array[r, 5];
                        dataGridViewDataService.Rows[r].Cells[6].Value = array[r, 6];

                    }
                }
            }

            /*try
            {

                for (int i = 1; i < dataGridViewDataService.RowCount - 1; i++)
                {
                    if (dataGridViewDataService.Rows[i].Cells[0].Value.ToString() == "")
                    {
                        dataGridViewDataService.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Такого комплектующего нет ни у одного компьютера. Введите корректное комплектующее", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


        }
    }
}
