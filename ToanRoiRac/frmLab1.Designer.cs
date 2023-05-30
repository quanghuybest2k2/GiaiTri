namespace ToanRoiRac
{
    partial class frmLab1
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
            this.lbltittle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbbChoice = new System.Windows.Forms.ComboBox();
            this.btnChoice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltittle
            // 
            this.lbltittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltittle.AutoSize = true;
            this.lbltittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltittle.Location = new System.Drawing.Point(124, 12);
            this.lbltittle.Name = "lbltittle";
            this.lbltittle.Size = new System.Drawing.Size(146, 31);
            this.lbltittle.TabIndex = 0;
            this.lbltittle.Text = "Giải Lab 1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(375, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbbChoice
            // 
            this.cbbChoice.FormattingEnabled = true;
            this.cbbChoice.Items.AddRange(new object[] {
            "Xuất trực tiếp",
            "Xuất file .txt"});
            this.cbbChoice.Location = new System.Drawing.Point(104, 37);
            this.cbbChoice.Name = "cbbChoice";
            this.cbbChoice.Size = new System.Drawing.Size(156, 21);
            this.cbbChoice.TabIndex = 2;
            // 
            // btnChoice
            // 
            this.btnChoice.Location = new System.Drawing.Point(104, 110);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(131, 50);
            this.btnChoice.TabIndex = 3;
            this.btnChoice.Text = "Chọn";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbltittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 65);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.cbbChoice);
            this.panel2.Controls.Add(this.btnChoice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 221);
            this.panel2.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(326, 37);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 286);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLab1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltittle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbbChoice;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
    }
}