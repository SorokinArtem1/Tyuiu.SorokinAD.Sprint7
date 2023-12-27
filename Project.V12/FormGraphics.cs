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
using System.Windows.Forms.DataVisualization.Charting;

namespace Project.V12
{
    public partial class FormGraphics : Form
    {
        private ComboBox comboBox;
        public FormGraphics()
        {
            InitializeComponent();
        }

        private void FormGraphics_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(39, 51, 65);
        }

        private void buttonAddPC_Click(object sender, EventArgs e)
        {
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

            int m = 0;
            string path2 = @"C:\Users\blitz\source\repos\Tyuiu.SorokinAD.Sprint7\DataService.csv";

            if (comboBoxSelectCompl.Text == "Процессор")
            {
                m = 1;
                path2 = @"C:\Users\blitz\source\repos\Tyuiu.SorokinAD.Sprint7\DataServiceProc.csv";
                this.chart.ChartAreas[0].AxisY.Title = "Тактовая частота (Гц)";
            }

            else if (comboBoxSelectCompl.Text == "Видеокарта")
            {
                m = 2;
                path2 = @"C:\Users\blitz\source\repos\Tyuiu.SorokinAD.Sprint7\DataServiceVideo.csv";
                this.chart.ChartAreas[0].AxisY.Title = "Объем видеопамяти (Гб)";
            }
            else if (comboBoxSelectCompl.Text == "Блок питания")
            {
                m = 3;
                path2 = @"C:\Users\blitz\source\repos\Tyuiu.SorokinAD.Sprint7\DataServiceBlock.csv";
                this.chart.ChartAreas[0].AxisY.Title = "Мощность (Вт)";
            }
            else if (comboBoxSelectCompl.Text == "Оперативная память")
            {
                m = 4;
                path2 = @"C:\Users\blitz\source\repos\Tyuiu.SorokinAD.Sprint7\DataServiceMemory.csv";
                this.chart.ChartAreas[0].AxisY.Title = "Частота передачи данных (МГц";
            }
            else if (comboBoxSelectCompl.Text == "Жесткий диск")
            {
                m = 6;
                path2 = @"C:\Users\blitz\source\repos\Tyuiu.SorokinAD.Sprint7\DataServiceDisk.csv";
                this.chart.ChartAreas[0].AxisY.Title = "Объем (Гб)";
            }



            int n = Convert.ToInt32(textBoxSelectPC.Text);

            string compl = array[n, m];

        
            string file2 = File.ReadAllText(path2);
            file2 = file2.Replace('\n', '\r');
            string[] lines2 = file2.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows2 = lines2.Length;
            int columns2 = lines2[0].Split(';').Length;

            string[,] array2 = new string[rows2, columns2];

            for (int i = 0; i < rows2; i++)
            {
                string[] line_mas = lines2[i].Split(';');
                for (int j = 0; j < columns2; j++)
                {
                    array2[i, j] = line_mas[j];
                }
            }
            double charace = 0;
            for (int i = 0; i < rows2; i++)
            {
                if (array2[i, 0] == array[n, m])
                {
                    charace = Convert.ToDouble(array2[i, 1]);
                }
            }
            

            this.chart.ChartAreas[0].AxisX.Title = "Комплектующее";


            chart.Series[0].Points.AddXY(textBoxSelectPC.Text, charace);




            chart.DataManipulator.Sort(PointSortOrder.Ascending, chart.Series[0]);
            chart.Invalidate();
            textBoxSelectPC.Clear();

            comboBoxSelectCompl.Enabled = false;



        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.chart.Series[0].Points.Clear();
            comboBoxSelectCompl.Enabled = true;
        }
    }
}
