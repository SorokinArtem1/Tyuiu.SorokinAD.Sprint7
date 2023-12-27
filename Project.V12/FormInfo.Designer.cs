
namespace Project.V12
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(142, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "О нас";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 252);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelText.Location = new System.Drawing.Point(20, 11);
            this.labelText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(280, 135);
            this.labelText.TabIndex = 3;
            this.labelText.Text = resources.GetString("labelText.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelText);
            this.panel1.Location = new System.Drawing.Point(471, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 161);
            this.panel1.TabIndex = 4;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormInfo";
            this.Text = "Info | Сорокин А.Д | Sprint 7";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Panel panel1;
    }
}