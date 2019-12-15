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
    public partial class frmKitapIslemleri : Form
    {
        public frmKitapIslemleri()
        {
            InitializeComponent();
        }
        List<Yazar> yazarlar;
        private void FrmKitapIslemleri_Load(object sender, EventArgs e)
        {
            YazarBL yb = new YazarBL();
            TurBL tb = new TurBL();
            YayinEviBL yeb = new YayinEviBL();

            cmbTurler.DisplayMember = "Turad";
            cmbTurler.ValueMember = "Turid";
            cmbTurler.DataSource = tb.TurListesi();

            cmbYayinevleri.DisplayMember = "Ad";
            cmbYayinevleri.ValueMember = "YayinEviId";
            cmbYayinevleri.DataSource = yeb.YayinEviListesi();


            yazarlar = yb.YazarListesi();
            cmbYazarlar.DisplayMember = "AdSoyad";
            cmbYazarlar.ValueMember = "Yazarid";
            cmbYazarlar.DataSource = yazarlar;
        }

        private void BtnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazar yz = new Yazar();
            yz.AdSoyad = cmbYazarlar.Text;
            yz.Yazarid = (int)cmbYazarlar.SelectedValue;

            lstYazarlar.DisplayMember = "AdSoyad";
            lstYazarlar.ValueMember = "Yazarid";

            if (YazarKontrol(yz))
            {
                lstYazarlar.Items.Add(yz);
            }
        }

        bool YazarKontrol(Yazar yz)
        {
            foreach (Yazar item in lstYazarlar.Items)
            {
                if (yz.Yazarid == item.Yazarid)
                {
                    MessageBox.Show("Yazar Eklenmiş");
                    return false;
                }
            }
            return true;
        }
    }
}
