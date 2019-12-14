namespace Vektorel.KitapBankosuApp
{
    partial class frmYazarListesi
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
            this.cmbYazarlar = new System.Windows.Forms.ComboBox();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdYazarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // grdYazarlar
            // 
            this.grdYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYazarlar.Location = new System.Drawing.Point(35, 108);
            this.grdYazarlar.Name = "grdYazarlar";
            this.grdYazarlar.Size = new System.Drawing.Size(286, 150);
            this.grdYazarlar.TabIndex = 0;
            // 
            // cmbYazarlar
            // 
            this.cmbYazarlar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbYazarlar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYazarlar.FormattingEnabled = true;
            this.cmbYazarlar.Location = new System.Drawing.Point(352, 237);
            this.cmbYazarlar.Name = "cmbYazarlar";
            this.cmbYazarlar.Size = new System.Drawing.Size(121, 21);
            this.cmbYazarlar.TabIndex = 1;
            this.cmbYazarlar.SelectedIndexChanged += new System.EventHandler(this.CmbYazarlar_SelectedIndexChanged);
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.Location = new System.Drawing.Point(353, 108);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(120, 95);
            this.lstYazarlar.TabIndex = 2;
            // 
            // frmYazarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.lstYazarlar);
            this.Controls.Add(this.cmbYazarlar);
            this.Controls.Add(this.grdYazarlar);
            this.Name = "frmYazarListesi";
            this.Text = "frmYazarListesi";
            this.Load += new System.EventHandler(this.FrmYazarListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdYazarlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdYazarlar;
        private System.Windows.Forms.ComboBox cmbYazarlar;
        private System.Windows.Forms.ListBox lstYazarlar;
    }
}