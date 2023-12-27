using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Project.V12.Lib;

namespace Project.V12
{
    public partial class FormDataService : Form
    {
        public FormDataService()
        {
            InitializeComponent();
            openFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();


        public string[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_mas[j];
                }
            }
            return array;
        }
        private void FormDataService_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(39, 51, 65);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewDataService.Rows.Count-1;
            DataGridViewRow newRow = new DataGridViewRow();
            dataGridViewDataService.Rows.Add(newRow);


            dataGridViewDataService.Rows[rowIndex].Cells[0].Value = textBoxNumber.Text; textBoxNumber.Clear();
            dataGridViewDataService.Rows[rowIndex].Cells[1].Value = textBoxProc.Text; textBoxProc.Clear();
            dataGridViewDataService.Rows[rowIndex].Cells[2].Value = textBoxVideo.Text; textBoxVideo.Clear();
            dataGridViewDataService.Rows[rowIndex].Cells[3].Value = textBoxBlock.Text; textBoxBlock.Clear();
            dataGridViewDataService.Rows[rowIndex].Cells[4].Value = textBoxMemory.Text; textBoxMemory.Clear();
            dataGridViewDataService.Rows[rowIndex].Cells[5].Value = textBoxMom.Text; textBoxMom.Clear();
            dataGridViewDataService.Rows[rowIndex].Cells[6].Value = textBoxDisk.Text; textBoxDisk.Clear();

            dataGridViewDataService.Sort(dataGridViewDataService.Columns[0], ListSortDirection.Descending);




        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFile = openFileDialog.FileName;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewDataService.RowCount = rows;
            dataGridViewDataService.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                
                dataGridViewDataService.Columns[i].Width = 200;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewDataService.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "DataServic.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewDataService.RowCount;
            int columns = dataGridViewDataService.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewDataService.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewDataService.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
