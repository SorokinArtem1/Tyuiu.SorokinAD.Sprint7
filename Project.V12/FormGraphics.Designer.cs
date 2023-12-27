
namespace Project.V12
{
    partial class FormGraphics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTittle = new System.Windows.Forms.Panel();
            this.groupBoxTittle = new System.Windows.Forms.GroupBox();
            this.labelGraphics = new System.Windows.Forms.Label();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxSelectCompl = new System.Windows.Forms.ComboBox();
            this.buttonAddPC = new System.Windows.Forms.Button();
            this.textBoxSelectPC = new System.Windows.Forms.TextBox();
            this.labelSelectPC = new System.Windows.Forms.Label();
            this.labelSelectCompl = new System.Windows.Forms.Label();
            this.panelOutPut = new System.Windows.Forms.Panel();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter = new System.Windows.Forms.Splitter();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelTittle.SuspendLayout();
            this.groupBoxTittle.SuspendLayout();
            this.panelSelect.SuspendLayout();
            this.groupBoxSelect.SuspendLayout();
            this.panelOutPut.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTittle
            // 
            this.panelTittle.Controls.Add(this.groupBoxTittle);
            this.panelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittle.Location = new System.Drawing.Point(0, 0);
            this.panelTittle.Name = "panelTittle";
            this.panelTittle.Size = new System.Drawing.Size(1184, 100);
            this.panelTittle.TabIndex = 0;
            // 
            // groupBoxTittle
            // 
            this.groupBoxTittle.Controls.Add(this.labelGraphics);
            this.groupBoxTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTittle.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTittle.Name = "groupBoxTittle";
            this.groupBoxTittle.Size = new System.Drawing.Size(1184, 100);
            this.groupBoxTittle.TabIndex = 0;
            this.groupBoxTittle.TabStop = false;
            // 
            // labelGraphics
            // 
            this.labelGraphics.AutoSize = true;
            this.labelGraphics.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraphics.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGraphics.Location = new System.Drawing.Point(22, 25);
            this.labelGraphics.Name = "labelGraphics";
            this.labelGraphics.Size = new System.Drawing.Size(168, 59);
            this.labelGraphics.TabIndex = 1;
            this.labelGraphics.Text = "Graphics";
            // 
            // panelSelect
            // 
            this.panelSelect.Controls.Add(this.groupBoxSelect);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSelect.Location = new System.Drawing.Point(0, 100);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(389, 350);
            this.panelSelect.TabIndex = 0;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.buttonClear);
            this.groupBoxSelect.Controls.Add(this.comboBoxSelectCompl);
            this.groupBoxSelect.Controls.Add(this.buttonAddPC);
            this.groupBoxSelect.Controls.Add(this.textBoxSelectPC);
            this.groupBoxSelect.Controls.Add(this.labelSelectPC);
            this.groupBoxSelect.Controls.Add(this.labelSelectCompl);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(389, 350);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DimGray;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(272, 218);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 75);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Очистить график";
            this.toolTip.SetToolTip(this.buttonClear, "График будет полностью очищен");
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxSelectCompl
            // 
            this.comboBoxSelectCompl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectCompl.FormattingEnabled = true;
            this.comboBoxSelectCompl.Items.AddRange(new object[] {
            "Процессор",
            "Видеокарта",
            "Блок питания",
            "Оперативная память",
            "Жесткий диск"});
            this.comboBoxSelectCompl.Location = new System.Drawing.Point(249, 68);
            this.comboBoxSelectCompl.Name = "comboBoxSelectCompl";
            this.comboBoxSelectCompl.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectCompl.TabIndex = 5;
            // 
            // buttonAddPC
            // 
            this.buttonAddPC.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonAddPC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddPC.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddPC.Location = new System.Drawing.Point(32, 218);
            this.buttonAddPC.Name = "buttonAddPC";
            this.buttonAddPC.Size = new System.Drawing.Size(208, 75);
            this.buttonAddPC.TabIndex = 4;
            this.buttonAddPC.Text = "Добавить компьютер";
            this.toolTip.SetToolTip(this.buttonAddPC, "Комплектующее покажется на графике");
            this.buttonAddPC.UseVisualStyleBackColor = false;
            this.buttonAddPC.Click += new System.EventHandler(this.buttonAddPC_Click);
            // 
            // textBoxSelectPC
            // 
            this.textBoxSelectPC.Location = new System.Drawing.Point(249, 116);
            this.textBoxSelectPC.Name = "textBoxSelectPC";
            this.textBoxSelectPC.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectPC.TabIndex = 3;
            // 
            // labelSelectPC
            // 
            this.labelSelectPC.AutoSize = true;
            this.labelSelectPC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectPC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSelectPC.Location = new System.Drawing.Point(28, 115);
            this.labelSelectPC.Name = "labelSelectPC";
            this.labelSelectPC.Size = new System.Drawing.Size(148, 19);
            this.labelSelectPC.TabIndex = 1;
            this.labelSelectPC.Text = "Выбор компьютера";
            // 
            // labelSelectCompl
            // 
            this.labelSelectCompl.AutoSize = true;
            this.labelSelectCompl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectCompl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSelectCompl.Location = new System.Drawing.Point(28, 67);
            this.labelSelectCompl.Name = "labelSelectCompl";
            this.labelSelectCompl.Size = new System.Drawing.Size(183, 19);
            this.labelSelectCompl.TabIndex = 0;
            this.labelSelectCompl.Text = "Выбор комплектующего";
            // 
            // panelOutPut
            // 
            this.panelOutPut.Controls.Add(this.groupBoxOutput);
            this.panelOutPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut.Location = new System.Drawing.Point(389, 100);
            this.panelOutPut.Name = "panelOutPut";
            this.panelOutPut.Size = new System.Drawing.Size(795, 350);
            this.panelOutPut.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.chart);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(795, 350);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(184, 19);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(424, 300);
            this.chart.TabIndex = 0;
            // 
            // splitter
            // 
            this.splitter.Location = new System.Drawing.Point(389, 100);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 350);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
            // 
            // FormGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.panelOutPut);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.panelTittle);
            this.MinimumSize = new System.Drawing.Size(1200, 489);
            this.Name = "FormGraphics";
            this.Text = "Graphcs | Сорокин А.Д | Sprint 7";
            this.Load += new System.EventHandler(this.FormGraphics_Load);
            this.panelTittle.ResumeLayout(false);
            this.groupBoxTittle.ResumeLayout(false);
            this.groupBoxTittle.PerformLayout();
            this.panelSelect.ResumeLayout(false);
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.panelOutPut.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTittle;
        private System.Windows.Forms.GroupBox groupBoxTittle;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.Panel panelOutPut;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Label labelGraphics;
        private System.Windows.Forms.Label labelSelectPC;
        private System.Windows.Forms.Label labelSelectCompl;
        private System.Windows.Forms.Button buttonAddPC;
        private System.Windows.Forms.TextBox textBoxSelectPC;
        private System.Windows.Forms.ComboBox comboBoxSelectCompl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ToolTip toolTip;
    }
}