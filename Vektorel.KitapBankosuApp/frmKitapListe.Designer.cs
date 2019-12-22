namespace Vektorel.KitapBankosuApp
{
    partial class frmKitapListe
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
            this.grdKitaplar = new System.Windows.Forms.DataGridView();
            this.clmKitapAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKitapTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSayfaSayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBasimYil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // grdKitaplar
            // 
            this.grdKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKitapAd,
            this.clmKitapTur,
            this.clmSayfaSayi,
            this.clmBasimYil,
            this.clmAdet,
            this.clmYayinEvi,
            this.clmIsbn});
            this.grdKitaplar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdKitaplar.Location = new System.Drawing.Point(0, 0);
            this.grdKitaplar.Name = "grdKitaplar";
            this.grdKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdKitaplar.Size = new System.Drawing.Size(743, 226);
            this.grdKitaplar.TabIndex = 0;
            this.grdKitaplar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdKitaplar_CellDoubleClick);
            // 
            // clmKitapAd
            // 
            this.clmKitapAd.DataPropertyName = "KitapAd";
            this.clmKitapAd.HeaderText = "Kitap Adı";
            this.clmKitapAd.Name = "clmKitapAd";
            // 
            // clmKitapTur
            // 
            this.clmKitapTur.DataPropertyName = "TurAd";
            this.clmKitapTur.HeaderText = "Türü";
            this.clmKitapTur.Name = "clmKitapTur";
            // 
            // clmSayfaSayi
            // 
            this.clmSayfaSayi.DataPropertyName = "SayfaSayi";
            this.clmSayfaSayi.HeaderText = "Sayfa Sayısı";
            this.clmSayfaSayi.Name = "clmSayfaSayi";
            // 
            // clmBasimYil
            // 
            this.clmBasimYil.DataPropertyName = "BasimYil";
            this.clmBasimYil.HeaderText = "Basım Yılı";
            this.clmBasimYil.Name = "clmBasimYil";
            // 
            // clmAdet
            // 
            this.clmAdet.DataPropertyName = "Adet";
            this.clmAdet.HeaderText = "Adet";
            this.clmAdet.Name = "clmAdet";
            // 
            // clmYayinEvi
            // 
            this.clmYayinEvi.DataPropertyName = "YayinEviAd";
            this.clmYayinEvi.HeaderText = "Yayın Evi";
            this.clmYayinEvi.Name = "clmYayinEvi";
            // 
            // clmIsbn
            // 
            this.clmIsbn.DataPropertyName = "Isbn";
            this.clmIsbn.HeaderText = "Isbn";
            this.clmIsbn.Name = "clmIsbn";
            // 
            // frmKitapListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 437);
            this.Controls.Add(this.grdKitaplar);
            this.Name = "frmKitapListe";
            this.Text = "frmKitapListe";
            this.Load += new System.EventHandler(this.FrmKitapListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdKitaplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKitapAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKitapTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSayfaSayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBasimYil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsbn;
    }
}