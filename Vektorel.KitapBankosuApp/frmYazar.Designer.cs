namespace Vektorel.KitapBankosuApp
{
    partial class frmYazar
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDtar = new System.Windows.Forms.Label();
            this.lblOlumTarih = new System.Windows.Forms.Label();
            this.dtDTar = new System.Windows.Forms.DateTimePicker();
            this.dtOlumTar = new System.Windows.Forms.DateTimePicker();
            this.chkYasiyor = new System.Windows.Forms.CheckBox();
            this.btnYazarBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(105, 54);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(105, 80);
            this.txtSoyad.MaxLength = 75;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(105, 174);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(30, 61);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(30, 87);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblDtar
            // 
            this.lblDtar.AutoSize = true;
            this.lblDtar.Location = new System.Drawing.Point(30, 113);
            this.lblDtar.Name = "lblDtar";
            this.lblDtar.Size = new System.Drawing.Size(70, 13);
            this.lblDtar.TabIndex = 7;
            this.lblDtar.Text = "Doğum Tarihi";
            // 
            // lblOlumTarih
            // 
            this.lblOlumTarih.AutoSize = true;
            this.lblOlumTarih.Location = new System.Drawing.Point(30, 139);
            this.lblOlumTarih.Name = "lblOlumTarih";
            this.lblOlumTarih.Size = new System.Drawing.Size(60, 13);
            this.lblOlumTarih.TabIndex = 8;
            this.lblOlumTarih.Text = "Ölüm Tarihi";
            // 
            // dtDTar
            // 
            this.dtDTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDTar.Location = new System.Drawing.Point(105, 113);
            this.dtDTar.Name = "dtDTar";
            this.dtDTar.Size = new System.Drawing.Size(100, 20);
            this.dtDTar.TabIndex = 9;
            // 
            // dtOlumTar
            // 
            this.dtOlumTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOlumTar.Location = new System.Drawing.Point(105, 139);
            this.dtOlumTar.Name = "dtOlumTar";
            this.dtOlumTar.Size = new System.Drawing.Size(100, 20);
            this.dtOlumTar.TabIndex = 10;
            // 
            // chkYasiyor
            // 
            this.chkYasiyor.AutoSize = true;
            this.chkYasiyor.Location = new System.Drawing.Point(211, 142);
            this.chkYasiyor.Name = "chkYasiyor";
            this.chkYasiyor.Size = new System.Drawing.Size(60, 17);
            this.chkYasiyor.TabIndex = 11;
            this.chkYasiyor.Text = "Yaşıyor";
            this.chkYasiyor.UseVisualStyleBackColor = true;
            this.chkYasiyor.CheckedChanged += new System.EventHandler(this.ChkYasiyor_CheckedChanged);
            // 
            // btnYazarBul
            // 
            this.btnYazarBul.Location = new System.Drawing.Point(105, 203);
            this.btnYazarBul.Name = "btnYazarBul";
            this.btnYazarBul.Size = new System.Drawing.Size(100, 23);
            this.btnYazarBul.TabIndex = 12;
            this.btnYazarBul.Text = "Yazar Bul";
            this.btnYazarBul.UseVisualStyleBackColor = true;
            this.btnYazarBul.Click += new System.EventHandler(this.BtnYazarBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSil.Location = new System.Drawing.Point(105, 232);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 23);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // frmYazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 292);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYazarBul);
            this.Controls.Add(this.chkYasiyor);
            this.Controls.Add(this.dtOlumTar);
            this.Controls.Add(this.dtDTar);
            this.Controls.Add(this.lblOlumTarih);
            this.Controls.Add(this.lblDtar);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "frmYazar";
            this.Text = "frmKitap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDtar;
        private System.Windows.Forms.Label lblOlumTarih;
        private System.Windows.Forms.Button btnYazarBul;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.DateTimePicker dtDTar;
        public System.Windows.Forms.DateTimePicker dtOlumTar;
        public System.Windows.Forms.CheckBox chkYasiyor;
        public System.Windows.Forms.Button btnSil;
    }
}