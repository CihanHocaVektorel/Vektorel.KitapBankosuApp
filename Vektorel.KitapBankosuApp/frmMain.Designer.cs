namespace Vektorel.KitapBankosuApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yazarİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayıneviİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYazarKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYazarListeleme = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKayıtİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListelemeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarİşlemleriToolStripMenuItem,
            this.yayıneviİşlemleriToolStripMenuItem,
            this.kitapİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yazarİşlemleriToolStripMenuItem
            // 
            this.yazarİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYazarKayit,
            this.btnYazarListeleme});
            this.yazarİşlemleriToolStripMenuItem.Name = "yazarİşlemleriToolStripMenuItem";
            this.yazarİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.yazarİşlemleriToolStripMenuItem.Text = "Yazar İşlemleri";
            // 
            // yayıneviİşlemleriToolStripMenuItem
            // 
            this.yayıneviİşlemleriToolStripMenuItem.Name = "yayıneviİşlemleriToolStripMenuItem";
            this.yayıneviİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.yayıneviİşlemleriToolStripMenuItem.Text = "Yayınevi İşlemleri";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapKayıtİşlemleriToolStripMenuItem,
            this.kitapListelemeİşlemleriToolStripMenuItem});
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // btnYazarKayit
            // 
            this.btnYazarKayit.Name = "btnYazarKayit";
            this.btnYazarKayit.Size = new System.Drawing.Size(190, 22);
            this.btnYazarKayit.Text = "Yazar Kayıt İşlemleri";
            this.btnYazarKayit.Click += new System.EventHandler(this.BtnYazarKayit_Click);
            // 
            // btnYazarListeleme
            // 
            this.btnYazarListeleme.Name = "btnYazarListeleme";
            this.btnYazarListeleme.Size = new System.Drawing.Size(190, 22);
            this.btnYazarListeleme.Text = "Yazar Listeleme İşlemleri";
            this.btnYazarListeleme.Click += new System.EventHandler(this.BtnYazarListeleme_Click);
            // 
            // kitapKayıtİşlemleriToolStripMenuItem
            // 
            this.kitapKayıtİşlemleriToolStripMenuItem.Name = "kitapKayıtİşlemleriToolStripMenuItem";
            this.kitapKayıtİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.kitapKayıtİşlemleriToolStripMenuItem.Text = "Kitap Kayıt İşlemleri";
            // 
            // kitapListelemeİşlemleriToolStripMenuItem
            // 
            this.kitapListelemeİşlemleriToolStripMenuItem.Name = "kitapListelemeİşlemleriToolStripMenuItem";
            this.kitapListelemeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.kitapListelemeİşlemleriToolStripMenuItem.Text = "Kitap Listeleme İşlemleri";
            this.kitapListelemeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.KitapListelemeİşlemleriToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.ÇıkışToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yazarİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnYazarKayit;
        private System.Windows.Forms.ToolStripMenuItem btnYazarListeleme;
        private System.Windows.Forms.ToolStripMenuItem yayıneviİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKayıtİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListelemeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}