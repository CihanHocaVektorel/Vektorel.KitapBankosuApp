using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.KitapBankosu.BLL;
using Vektorel.KitapBankosu.Models;

namespace Vektorel.KitapBankosuApp
{

    public partial class frmYazar : Form
    {
        public Islem KayitIslem { get; set; }
        public int yazarid;
        public frmYazar()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            switch (KayitIslem)
            {
                case Islem.Insert:
                    try
                    {
                        YazarBL y = new YazarBL();
                        Yazar yz = new Yazar();
                        yz.Ad = txtAd.Text;
                        yz.Soyad = txtSoyad.Text;
                        yz.DTar = dtDTar.Value;
                        if (!chkYasiyor.Checked)
                        {
                            yz.OlumTarih = dtOlumTar.Value;
                        }
                        y.YazarEkle(yz);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı Hatası.Hata Numarası:" + ex.Number);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bilinmeyen bir hata oluştu");
                    }
                    break;
                case Islem.Update:
                    try
                    {
                        YazarBL y = new YazarBL();
                        Yazar yz = new Yazar();
                        yz.Ad = txtAd.Text;
                        yz.Soyad = txtSoyad.Text;
                        yz.DTar = dtDTar.Value;
                        if (!chkYasiyor.Checked)
                        {
                            yz.OlumTarih = dtOlumTar.Value;
                        }
                        yz.Yazarid = yazarid;
                        if (y.YazarGuncelle(yz))
                        {
                            Sifirlama();
                            MessageBox.Show("Güncelleme Başarılı..");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı Hatası.Hata Numarası:" + ex.Number);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bilinmeyen bir hata oluştu");
                    }
                    break;
                default:
                    break;
            }
        }

        void Sifirlama()
        {
            btnEkle.Text = "Ekle";
            KayitIslem = Islem.Insert;
            txtAd.Text = "";
            txtSoyad.Text = "";
            dtDTar.Value = DateTime.Now;
            dtOlumTar.Value = DateTime.Now;
            chkYasiyor.Checked = false;
            btnSil.Visible = false;
        }

        private void ChkYasiyor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYasiyor.Checked)
            {
                dtOlumTar.Enabled = false;
            }
            else
            {
                dtOlumTar.Enabled = true;
            }
        }

        private void BtnYazarBul_Click(object sender, EventArgs e)
        {
            frmYazarBul frm = new frmYazarBul();
            frm.Show();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp == DialogResult.Yes)
            {
                YazarBL yb = new YazarBL();
                if (yb.YazarSil(yazarid))
                {
                    MessageBox.Show("İşlem başarılı");
                    Sifirlama();
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi..");
            }
        }
    }
}
