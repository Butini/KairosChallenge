namespace KairosChallenge
{
    partial class frmUrlLink
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
            this.infoTxt = new System.Windows.Forms.Label();
            this.urlBtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // infoTxt
            // 
            this.infoTxt.AutoSize = true;
            this.infoTxt.Location = new System.Drawing.Point(29, 24);
            this.infoTxt.Name = "infoTxt";
            this.infoTxt.Size = new System.Drawing.Size(184, 13);
            this.infoTxt.TabIndex = 0;
            this.infoTxt.Text = "Si pulsas el botón te llevara a la URL:";
            // 
            // urlBtn
            // 
            this.urlBtn.Location = new System.Drawing.Point(551, 67);
            this.urlBtn.Name = "urlBtn";
            this.urlBtn.Size = new System.Drawing.Size(75, 23);
            this.urlBtn.TabIndex = 1;
            this.urlBtn.Text = "¡Vamos!";
            this.urlBtn.UseVisualStyleBackColor = true;
            this.urlBtn.Click += new System.EventHandler(this.urlBtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 96);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1123, 444);
            this.webBrowser1.TabIndex = 2;
            // 
            // frmUrlLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 552);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.urlBtn);
            this.Controls.Add(this.infoTxt);
            this.Name = "frmUrlLink";
            this.Text = "frmUrlLink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoTxt;
        private System.Windows.Forms.Button urlBtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}