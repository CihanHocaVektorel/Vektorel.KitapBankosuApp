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
    public partial class frmYazarBul : Form
    {
        public frmYazarBul()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnYazarBul_Click(object sender, EventArgs e)
        {
            YazarBL yb = new YazarBL();
            Yazar yz = yb.YazarBul(txtYazarAd.Text.Trim());
            if (yz == null)
            {
                MessageBox.Show("Yazar Bulunamadı!");
            }
            else
            {
                frmYazar frm = (frmYazar)Application.OpenForms["frmYazar"];
                frm.txtAd.Text = yz.Ad;
                frm.txtSoyad.Text = yz.Soyad;
                frm.dtDTar.Value = yz.DTar;
                if (yz.OlumTarih != DateTime.MinValue)
                {
                    frm.chkYasiyor.Checked = false;
                    frm.dtOlumTar.Value = yz.OlumTarih;
                }
                else
                {
                    frm.chkYasiyor.Checked = true;
                }
                frm.btnEkle.Text = "Güncelle";
                frm.KayitIslem = Islem.Update;
                frm.yazarid = yz.Yazarid;
                frm.btnSil.Visible = true;
                this.Close();
            }
        }
    }
}
