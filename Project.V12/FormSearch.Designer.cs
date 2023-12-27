
namespace Project.V12
{
    partial class FormSearch
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
            this.panelTittle = new System.Windows.Forms.Panel();
            this.groupBoxTittle = new System.Windows.Forms.GroupBox();
            this.textBoxSelectPC = new System.Windows.Forms.TextBox();
            this.labelSelectPC = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelDataService = new System.Windows.Forms.Label();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.dataGridViewDataService = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelTittle.SuspendLayout();
            this.groupBoxTittle.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataService)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTittle
            // 
            this.panelTittle.Controls.Add(this.groupBoxTittle);
            this.panelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittle.Location = new System.Drawing.Point(0, 0);
            this.panelTittle.Name = "panelTittle";
            this.panelTittle.Size = new System.Drawing.Size(819, 100);
            this.panelTittle.TabIndex = 0;
            // 
            // groupBoxTittle
            // 
            this.groupBoxTittle.Controls.Add(this.textBoxSelectPC);
            this.groupBoxTittle.Controls.Add(this.labelSelectPC);
            this.groupBoxTittle.Controls.Add(this.buttonSearch);
            this.groupBoxTittle.Controls.Add(this.labelDataService);
            this.groupBoxTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTittle.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTittle.MinimumSize = new System.Drawing.Size(819, 100);
            this.groupBoxTittle.Name = "groupBoxTittle";
            this.groupBoxTittle.Size = new System.Drawing.Size(819, 100);
            this.groupBoxTittle.TabIndex = 0;
            this.groupBoxTittle.TabStop = false;
            // 
            // textBoxSelectPC
            // 
            this.textBoxSelectPC.Location = new System.Drawing.Point(430, 59);
            this.textBoxSelectPC.Name = "textBoxSelectPC";
            this.textBoxSelectPC.Size = new System.Drawing.Size(179, 20);
            this.textBoxSelectPC.TabIndex = 14;
            this.toolTip.SetToolTip(this.textBoxSelectPC, "Введите комплектующее желающее найти");
            // 
            // labelSelectPC
            // 
            this.labelSelectPC.AutoSize = true;
            this.labelSelectPC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectPC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSelectPC.Location = new System.Drawing.Point(417, 25);
            this.labelSelectPC.Name = "labelSelectPC";
            this.labelSelectPC.Size = new System.Drawing.Size(203, 19);
            this.labelSelectPC.TabIndex = 13;
            this.labelSelectPC.Text = "Название комлпектующего";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(650, 25);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 52);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Поиск";
            this.toolTip.SetToolTip(this.buttonSearch, "Покажет все компьютеры, имеющие определенное комплектующее");
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDataService
            // 
            this.labelDataService.AutoSize = true;
            this.labelDataService.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataService.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDataService.Location = new System.Drawing.Point(26, 25);
            this.labelDataService.Name = "labelDataService";
            this.labelDataService.Size = new System.Drawing.Size(140, 59);
            this.labelDataService.TabIndex = 1;
            this.labelDataService.Text = "Search";
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.groupBoxOutput);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(0, 100);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(819, 350);
            this.panelOutput.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.dataGridViewDataService);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(819, 350);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            // 
            // dataGridViewDataService
            // 
            this.dataGridViewDataService.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewDataService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Proc,
            this.Video,
            this.Block,
            this.Memory,
            this.Mom,
            this.Disk});
            this.dataGridViewDataService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataService.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDataService.Name = "dataGridViewDataService";
            this.dataGridViewDataService.ReadOnly = true;
            this.dataGridViewDataService.Size = new System.Drawing.Size(813, 331);
            this.dataGridViewDataService.TabIndex = 1;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер ПК";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 50;
            // 
            // Proc
            // 
            this.Proc.HeaderText = "Процессор";
            this.Proc.MinimumWidth = 6;
            this.Proc.Name = "Proc";
            this.Proc.ReadOnly = true;
            this.Proc.Width = 120;
            // 
            // Video
            // 
            this.Video.HeaderText = "Видеокарта";
            this.Video.Name = "Video";
            this.Video.ReadOnly = true;
            this.Video.Width = 120;
            // 
            // Block
            // 
            this.Block.HeaderText = "Блок питания";
            this.Block.Name = "Block";
            this.Block.ReadOnly = true;
            this.Block.Width = 120;
            // 
            // Memory
            // 
            this.Memory.HeaderText = "Оперативная память";
            this.Memory.Name = "Memory";
            this.Memory.ReadOnly = true;
            this.Memory.Width = 120;
            // 
            // Mom
            // 
            this.Mom.HeaderText = "Материнская память";
            this.Mom.Name = "Mom";
            this.Mom.ReadOnly = true;
            this.Mom.Width = 120;
            // 
            // Disk
            // 
            this.Disk.HeaderText = "Жесткий диск";
            this.Disk.Name = "Disk";
            this.Disk.ReadOnly = true;
            this.Disk.Width = 120;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelTittle);
            this.MinimumSize = new System.Drawing.Size(835, 489);
            this.Name = "FormSearch";
            this.Text = "Search | Сорокин А.Д | Sprint 7";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.panelTittle.ResumeLayout(false);
            this.groupBoxTittle.ResumeLayout(false);
            this.groupBoxTittle.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTittle;
        private System.Windows.Forms.GroupBox groupBoxTittle;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelDataService;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSelectPC;
        private System.Windows.Forms.Label labelSelectPC;
        private System.Windows.Forms.DataGridView dataGridViewDataService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disk;
        private System.Windows.Forms.ToolTip toolTip;
    }
}