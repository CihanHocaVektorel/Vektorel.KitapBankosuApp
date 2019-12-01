namespace Vektorel.KitapBankosuApp
{
    partial class Form1
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTurAd = new System.Windows.Forms.TextBox();
            this.lblKitapTur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(87, 118);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtTurAd
            // 
            this.txtTurAd.Location = new System.Drawing.Point(87, 82);
            this.txtTurAd.Name = "txtTurAd";
            this.txtTurAd.Size = new System.Drawing.Size(100, 20);
            this.txtTurAd.TabIndex = 1;
            // 
            // lblKitapTur
            // 
            this.lblKitapTur.AutoSize = true;
            this.lblKitapTur.Location = new System.Drawing.Point(25, 82);
            this.lblKitapTur.Name = "lblKitapTur";
            this.lblKitapTur.Size = new System.Drawing.Size(56, 13);
            this.lblKitapTur.TabIndex = 2;
            this.lblKitapTur.Text = "Kitap Türü";
            this.lblKitapTur.Click += new System.EventHandler(this.LblKitapTur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 225);
            this.Controls.Add(this.lblKitapTur);
            this.Controls.Add(this.txtTurAd);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTurAd;
        private System.Windows.Forms.Label lblKitapTur;
    }
}

