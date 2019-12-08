namespace Vektorel.KitapBankosuApp
{
    partial class frmYazarBul
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
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.btnYazarBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(19, 40);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(99, 20);
            this.txtYazarAd.TabIndex = 0;
            // 
            // btnYazarBul
            // 
            this.btnYazarBul.Location = new System.Drawing.Point(19, 77);
            this.btnYazarBul.Name = "btnYazarBul";
            this.btnYazarBul.Size = new System.Drawing.Size(99, 23);
            this.btnYazarBul.TabIndex = 1;
            this.btnYazarBul.Text = "Yazar Bul";
            this.btnYazarBul.UseVisualStyleBackColor = true;
            this.btnYazarBul.Click += new System.EventHandler(this.BtnYazarBul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yazar Adını Giriniz";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // frmYazarBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(135, 126);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYazarBul);
            this.Controls.Add(this.txtYazarAd);
            this.Name = "frmYazarBul";
            this.Text = "frmYazarBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Button btnYazarBul;
        private System.Windows.Forms.Label label1;
    }
}