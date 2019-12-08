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
                    //Güncelleme
                    break;
                default:
                    break;
            }

           

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
    }
}
