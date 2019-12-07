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
    public partial class frmYazar : Form
    {
        public frmYazar()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            YazarBL y = new YazarBL();
            Yazar yz = new Yazar();
            yz.Ad = txtAd.Text;
            yz.Soyad = txtSoyad.Text;
            yz.DTar = dtDTar.Value;
            if (!chkYasiyor.Checked)
            {
                yz.OlumTarih =dtOlumTar.Value;
            }
            y.YazarEkle(yz);
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
    }
}
