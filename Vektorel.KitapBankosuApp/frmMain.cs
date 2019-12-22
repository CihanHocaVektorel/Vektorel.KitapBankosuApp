using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.KitapBankosuApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnYazarKayit_Click(object sender, EventArgs e)
        {
            frmYazar frm = new frmYazar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnYazarListeleme_Click(object sender, EventArgs e)
        {
            frmYazarListe frm = new frmYazarListe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void KitapListelemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapListe frm = new frmKitapListe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }
    }
}
