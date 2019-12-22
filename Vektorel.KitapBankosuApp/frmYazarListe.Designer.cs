namespace Vektorel.KitapBankosuApp
{
    partial class frmYazarListe
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
            this.grdYazarlar = new System.Windows.Forms.DataGridView();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDtar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOlumTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdYazarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // grdYazarlar
            // 
            this.grdYazarlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYazarlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAd,
            this.clmSoyad,
            this.clmDtar,
            this.clmOlumTarih});
            this.grdYazarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdYazarlar.Location = new System.Drawing.Point(0, 0);
            this.grdYazarlar.Name = "grdYazarlar";
            this.grdYazarlar.Size = new System.Drawing.Size(521, 133);
            this.grdYazarlar.TabIndex = 0;
            // 
            // clmAd
            // 
            this.clmAd.DataPropertyName = "Ad";
            this.clmAd.HeaderText = "Adı";
            this.clmAd.Name = "clmAd";
            // 
            // clmSoyad
            // 
            this.clmSoyad.DataPropertyName = "Soyad";
            this.clmSoyad.HeaderText = "Soyad";
            this.clmSoyad.Name = "clmSoyad";
            // 
            // clmDtar
            // 
            this.clmDtar.DataPropertyName = "DTar";
            this.clmDtar.HeaderText = "Doğum Tarihi";
            this.clmDtar.Name = "clmDtar";
            // 
            // clmOlumTarih
            // 
            this.clmOlumTarih.DataPropertyName = "OlumTarih";
            this.clmOlumTarih.HeaderText = "Ölüm Tarihi";
            this.clmOlumTarih.Name = "clmOlumTarih";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(160, 182);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(217, 47);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Değişiklikleri Kaydet";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // frmYazarListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 283);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.grdYazarlar);
            this.Name = "frmYazarListe";
            this.Text = "frmKitapListe";
            this.Load += new System.EventHandler(this.FrmKitapListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdYazarlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdYazarlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDtar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOlumTarih;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}