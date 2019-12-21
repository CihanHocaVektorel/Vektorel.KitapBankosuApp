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
            else
            {
                MessageBox.Show("Yazar Eklenmiş");
            }
        }

        bool YazarKontrol(Yazar yz)
        {
            foreach (Yazar item in lstYazarlar.Items)
            {
                if (yz.Yazarid == item.Yazarid)
                {
                    return false;
                }
            }
            return true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            KitapBL ktp = new KitapBL();
            KitapYazarBL kybl = new KitapYazarBL();
            Kitap k = new Kitap();
            k.Adet = short.Parse(txtAdet.Text.Trim());
            k.BasimYil = short.Parse(txtBasimYil.Text.Trim());
            k.Isbn = txtIsbn.Text.Trim();
            k.KitapAd = txtKitapAd.Text.Trim();
            k.SayfaSayi = short.Parse(txtSayfaSayi.Text.Trim());
            k.TurId = Convert.ToInt16(cmbTurler.SelectedValue);
            k.YayinEviId = Convert.ToInt16(cmbYayinevleri.SelectedValue);
            bool kitapekle = ktp.KitapEkle(k);

            short kitapid = ktp.SonEklenenKitap();

            bool kitapyazar = false;
            if (kitapid != 0)
            {
                foreach (Yazar yazar in lstYazarlar.Items)
                {
                    KitapYazar ky = new KitapYazar();
                    ky.Yazarid = yazar.Yazarid;
                    ky.Kitapid = kitapid;                   
                    kitapyazar = kybl.KitapYazarEkle(ky);
                    // kitapyazar = kybl.KitapYazarEkle(new KitapYazar { Kitapid = kitapid, Yazarid = yazar.Yazarid });
                }
            }

            if (kitapekle && kitapyazar)
            {
                MessageBox.Show("Ekleme Başarılı");
            }
        }
    }
}
