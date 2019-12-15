using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.KitapBankosu.BLL;
using Vektorel.KitapBankosu.Models;

namespace Vektorel.KitapBankosuApp
{
    public partial class frmYazarListesi : Form
    {
        public frmYazarListesi()
        {
            InitializeComponent();
        }

        private void FrmYazarListesi_Load(object sender, EventArgs e)
        {
            YazarBL yb = new YazarBL();

            List<Yazar> lst = yb.YazarListesi();

            grdYazarlar.DataSource = yb.YazarListesi();


            cmbYazarlar.DisplayMember = "Ad";
            lst.Insert(0, new Yazar { Ad = "Seçiniz"});
            lst.Insert(1, new Yazar { Ad = "Yazar Ekle" });
            cmbYazarlar.DataSource = lst;

            lstYazarlar.DisplayMember = "Ad";
            lstYazarlar.DataSource = yb.YazarListesi();
        }

        private void CmbYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (cmbYazarlar.SelectedIndex==1)
            {
                frmYazar frm = new frmYazar();
                frm.Show();
            }
        }
    }
}
