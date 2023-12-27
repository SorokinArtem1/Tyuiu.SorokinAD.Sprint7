
namespace Project.V12
{
    partial class FormDataService
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelDataService = new System.Windows.Forms.Label();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.dataGridViewDataService = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Video = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelInput = new System.Windows.Forms.Panel();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxDisk = new System.Windows.Forms.TextBox();
            this.textBoxMom = new System.Windows.Forms.TextBox();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.textBoxBlock = new System.Windows.Forms.TextBox();
            this.textBoxVideo = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxProc = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelDisk = new System.Windows.Forms.Label();
            this.labelMom = new System.Windows.Forms.Label();
            this.labelMemory = new System.Windows.Forms.Label();
            this.labelBlock = new System.Windows.Forms.Label();
            this.labelVideo = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelProc = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelTittle.SuspendLayout();
            this.groupBoxTittle.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataService)).BeginInit();
            this.panelInput.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
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
            this.groupBoxTittle.Controls.Add(this.buttonSave);
            this.groupBoxTittle.Controls.Add(this.buttonOpen);
            this.groupBoxTittle.Controls.Add(this.labelDataService);
            this.groupBoxTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTittle.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTittle.Name = "groupBoxTittle";
            this.groupBoxTittle.Size = new System.Drawing.Size(1184, 100);
            this.groupBoxTittle.TabIndex = 0;
            this.groupBoxTittle.TabStop = false;
            this.groupBoxTittle.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(1030, 25);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 59);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.toolTip.SetToolTip(this.buttonSave, "Сохранить таблицу с добавленными компьютерами");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpen.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpen.Location = new System.Drawing.Point(870, 25);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(124, 59);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Открыть базу данных";
            this.toolTip.SetToolTip(this.buttonOpen, "Открыть файл с компьютерами");
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelDataService
            // 
            this.labelDataService.AutoSize = true;
            this.labelDataService.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataService.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDataService.Location = new System.Drawing.Point(12, 25);
            this.labelDataService.Name = "labelDataService";
            this.labelDataService.Size = new System.Drawing.Size(218, 59);
            this.labelDataService.TabIndex = 0;
            this.labelDataService.Text = "DataService";
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.panel4);
            this.panelOutput.Controls.Add(this.splitter1);
            this.panelOutput.Controls.Add(this.panelInput);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(0, 100);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(1184, 350);
            this.panelOutput.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxOutput);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(359, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 350);
            this.panel4.TabIndex = 2;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.dataGridViewDataService);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(825, 350);
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
            this.dataGridViewDataService.Size = new System.Drawing.Size(819, 331);
            this.dataGridViewDataService.TabIndex = 0;
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
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(356, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 350);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.groupBoxInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(356, 350);
            this.panelInput.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.buttonAdd);
            this.groupBoxInput.Controls.Add(this.textBoxDisk);
            this.groupBoxInput.Controls.Add(this.textBoxMom);
            this.groupBoxInput.Controls.Add(this.textBoxMemory);
            this.groupBoxInput.Controls.Add(this.textBoxBlock);
            this.groupBoxInput.Controls.Add(this.textBoxVideo);
            this.groupBoxInput.Controls.Add(this.textBoxNumber);
            this.groupBoxInput.Controls.Add(this.textBoxProc);
            this.groupBoxInput.Controls.Add(this.labelInput);
            this.groupBoxInput.Controls.Add(this.labelDisk);
            this.groupBoxInput.Controls.Add(this.labelMom);
            this.groupBoxInput.Controls.Add(this.labelMemory);
            this.groupBoxInput.Controls.Add(this.labelBlock);
            this.groupBoxInput.Controls.Add(this.labelVideo);
            this.groupBoxInput.Controls.Add(this.labelNumber);
            this.groupBoxInput.Controls.Add(this.labelProc);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(356, 350);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(95, 271);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 56);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.toolTip.SetToolTip(this.buttonAdd, "Добавить компьютера на таблицу");
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxDisk
            // 
            this.textBoxDisk.Location = new System.Drawing.Point(223, 236);
            this.textBoxDisk.Name = "textBoxDisk";
            this.textBoxDisk.Size = new System.Drawing.Size(100, 20);
            this.textBoxDisk.TabIndex = 7;
            // 
            // textBoxMom
            // 
            this.textBoxMom.Location = new System.Drawing.Point(223, 203);
            this.textBoxMom.Name = "textBoxMom";
            this.textBoxMom.Size = new System.Drawing.Size(100, 20);
            this.textBoxMom.TabIndex = 6;
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Location = new System.Drawing.Point(223, 169);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.Size = new System.Drawing.Size(100, 20);
            this.textBoxMemory.TabIndex = 5;
            // 
            // textBoxBlock
            // 
            this.textBoxBlock.Location = new System.Drawing.Point(223, 135);
            this.textBoxBlock.Name = "textBoxBlock";
            this.textBoxBlock.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlock.TabIndex = 4;
            // 
            // textBoxVideo
            // 
            this.textBoxVideo.Location = new System.Drawing.Point(223, 103);
            this.textBoxVideo.Name = "textBoxVideo";
            this.textBoxVideo.Size = new System.Drawing.Size(100, 20);
            this.textBoxVideo.TabIndex = 3;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(223, 43);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 2;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // textBoxProc
            // 
            this.textBoxProc.Location = new System.Drawing.Point(223, 72);
            this.textBoxProc.Name = "textBoxProc";
            this.textBoxProc.Size = new System.Drawing.Size(100, 20);
            this.textBoxProc.TabIndex = 2;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInput.Location = new System.Drawing.Point(116, 16);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(101, 19);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Ввод данных";
            // 
            // labelDisk
            // 
            this.labelDisk.AutoSize = true;
            this.labelDisk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDisk.Location = new System.Drawing.Point(21, 235);
            this.labelDisk.Name = "labelDisk";
            this.labelDisk.Size = new System.Drawing.Size(106, 19);
            this.labelDisk.TabIndex = 0;
            this.labelDisk.Text = "Жесткий диск";
            // 
            // labelMom
            // 
            this.labelMom.AutoSize = true;
            this.labelMom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMom.Location = new System.Drawing.Point(21, 203);
            this.labelMom.Name = "labelMom";
            this.labelMom.Size = new System.Drawing.Size(146, 19);
            this.labelMom.TabIndex = 0;
            this.labelMom.Text = "Материнская плата";
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMemory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMemory.Location = new System.Drawing.Point(21, 168);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(156, 19);
            this.labelMemory.TabIndex = 0;
            this.labelMemory.Text = "Оперативная память";
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBlock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBlock.Location = new System.Drawing.Point(22, 135);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(105, 19);
            this.labelBlock.TabIndex = 0;
            this.labelBlock.Text = "Блок питания";
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVideo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVideo.Location = new System.Drawing.Point(21, 102);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(92, 19);
            this.labelVideo.TabIndex = 0;
            this.labelVideo.Text = "Видеокарта";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNumber.Location = new System.Drawing.Point(22, 42);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(79, 19);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер ПК";
            // 
            // labelProc
            // 
            this.labelProc.AutoSize = true;
            this.labelProc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProc.Location = new System.Drawing.Point(22, 71);
            this.labelProc.Name = "labelProc";
            this.labelProc.Size = new System.Drawing.Size(86, 19);
            this.labelProc.TabIndex = 0;
            this.labelProc.Text = "Процессор";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormDataService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelTittle);
            this.MinimumSize = new System.Drawing.Size(1200, 489);
            this.Name = "FormDataService";
            this.Text = "DataService | Сорокин А.Д | Sprint 7";
            this.Load += new System.EventHandler(this.FormDataService_Load);
            this.panelTittle.ResumeLayout(false);
            this.groupBoxTittle.ResumeLayout(false);
            this.groupBoxTittle.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataService)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTittle;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxTittle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelDataService;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelDisk;
        private System.Windows.Forms.Label labelMom;
        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.Label labelBlock;
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.Label labelProc;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxDisk;
        private System.Windows.Forms.TextBox textBoxMom;
        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.TextBox textBoxBlock;
        private System.Windows.Forms.TextBox textBoxVideo;
        private System.Windows.Forms.TextBox textBoxProc;
        private System.Windows.Forms.DataGridView dataGridViewDataService;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Video;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disk;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonSave;
    }
}