
namespace Project.V12
{
    partial class FormMain
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
            this.buttonProg = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelEVM = new System.Windows.Forms.Label();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonGraphics = new System.Windows.Forms.Button();
            this.buttonDataService = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProg
            // 
            this.buttonProg.BackColor = System.Drawing.Color.DimGray;
            this.buttonProg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProg.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonProg.Location = new System.Drawing.Point(688, 359);
            this.buttonProg.Name = "buttonProg";
            this.buttonProg.Size = new System.Drawing.Size(79, 65);
            this.buttonProg.TabIndex = 5;
            this.buttonProg.Text = "Program";
            this.toolTip.SetToolTip(this.buttonProg, "Что умеет наша программа?");
            this.buttonProg.UseVisualStyleBackColor = false;
            this.buttonProg.Click += new System.EventHandler(this.buttonProg_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.DimGray;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInfo.Location = new System.Drawing.Point(593, 359);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(79, 65);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Info";
            this.toolTip.SetToolTip(this.buttonInfo, "Информация о программе и способы связи");
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelEVM
            // 
            this.labelEVM.AutoSize = true;
            this.labelEVM.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEVM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEVM.Location = new System.Drawing.Point(131, 64);
            this.labelEVM.Name = "labelEVM";
            this.labelEVM.Size = new System.Drawing.Size(470, 49);
            this.labelEVM.TabIndex = 1;
            this.labelEVM.Text = "Персональные ЭВМ";
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.buttonSearch);
            this.groupBoxMain.Controls.Add(this.buttonGraphics);
            this.groupBoxMain.Controls.Add(this.buttonDataService);
            this.groupBoxMain.Controls.Add(this.labelEVM);
            this.groupBoxMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxMain.Location = new System.Drawing.Point(33, 26);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(734, 317);
            this.groupBoxMain.TabIndex = 3;
            this.groupBoxMain.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch.Location = new System.Drawing.Point(507, 194);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(207, 99);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.toolTip.SetToolTip(this.buttonSearch, "Найти компьютеры по комплектующим");
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonGraphics
            // 
            this.buttonGraphics.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGraphics.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGraphics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGraphics.Location = new System.Drawing.Point(262, 194);
            this.buttonGraphics.Name = "buttonGraphics";
            this.buttonGraphics.Size = new System.Drawing.Size(207, 99);
            this.buttonGraphics.TabIndex = 4;
            this.buttonGraphics.Text = "Graphics";
            this.toolTip.SetToolTip(this.buttonGraphics, "Узнать мощности разных комплектующих");
            this.buttonGraphics.UseVisualStyleBackColor = false;
            this.buttonGraphics.Click += new System.EventHandler(this.buttonGraphics_Click);
            // 
            // buttonDataService
            // 
            this.buttonDataService.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDataService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDataService.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDataService.Location = new System.Drawing.Point(19, 194);
            this.buttonDataService.Name = "buttonDataService";
            this.buttonDataService.Size = new System.Drawing.Size(207, 99);
            this.buttonDataService.TabIndex = 3;
            this.buttonDataService.Text = "DataService";
            this.toolTip.SetToolTip(this.buttonDataService, "База данных компьютеров");
            this.buttonDataService.UseVisualStyleBackColor = false;
            this.buttonDataService.Click += new System.EventHandler(this.buttonDataService_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProg);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.groupBoxMain);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.Text = "Сорокин А.Д. | Спринт 7 | Вариант 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonProg;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelEVM;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Button buttonDataService;
        private System.Windows.Forms.Button buttonGraphics;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

