using System.Threading.Tasks;

namespace DictionaryAPI
{
    partial class FrmMain
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
            this.cbbLang = new System.Windows.Forms.ComboBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtxtValue = new System.Windows.Forms.RichTextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.flpResult = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbLang
            // 
            this.cbbLang.FormattingEnabled = true;
            this.cbbLang.Location = new System.Drawing.Point(110, 92);
            this.cbbLang.Name = "cbbLang";
            this.cbbLang.Size = new System.Drawing.Size(105, 21);
            this.cbbLang.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 74);
            this.panelTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(323, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Từ điển tiếng anh";
            // 
            // rtxtValue
            // 
            this.rtxtValue.Location = new System.Drawing.Point(110, 119);
            this.rtxtValue.Name = "rtxtValue";
            this.rtxtValue.Size = new System.Drawing.Size(678, 48);
            this.rtxtValue.TabIndex = 2;
            this.rtxtValue.Text = "";
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(326, 401);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(96, 37);
            this.btnLookup.TabIndex = 3;
            this.btnLookup.Text = "Tra cứu";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_ClickAsync);
            // 
            // flpResult
            // 
            this.flpResult.Location = new System.Drawing.Point(110, 202);
            this.flpResult.Name = "flpResult";
            this.flpResult.Size = new System.Drawing.Size(681, 193);
            this.flpResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đầu ra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cụm từ muốn dịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bản dịch";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpResult);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.rtxtValue);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.cbbLang);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ điển tiếng anh";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbLang;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtxtValue;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.FlowLayoutPanel flpResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

