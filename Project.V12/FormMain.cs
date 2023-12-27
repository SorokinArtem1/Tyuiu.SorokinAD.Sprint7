using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(39, 51, 65);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDataService_Click(object sender, EventArgs e)
        {
            FormDataService formds = new FormDataService();
            formds.ShowDialog();
        }

        private void buttonGraphics_Click(object sender, EventArgs e)
        {
            FormGraphics formgr = new FormGraphics();
            formgr.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch formsr = new FormSearch();
            formsr.ShowDialog();

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo formin = new FormInfo();
            formin.ShowDialog();
        }

        private void buttonProg_Click(object sender, EventArgs e)
        {
            FormProgram formpr = new FormProgram();
            formpr.ShowDialog();
        }
    }
}
