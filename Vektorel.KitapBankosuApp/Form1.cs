using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.KitapBankosu.BLL;
using Vektorel.KitapBankosu.Models;

namespace Vektorel.KitapBankosuApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void LblKitapTur_Click(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {//SqlInjection
            
            try
            {
                TurBL t = new TurBL();
                Tur tur = new Tur();
                tur.Turad = txtTurAd.Text;
                MessageBox.Show(t.TurEkle(tur)?"Ekleme Başarılı":"Başarısız"); 
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        if (ex.Message.Contains("UK_tblTurler_TurAd"))
                        {
                            MessageBox.Show(ex.Number + " Bu ad daha önce kaydedilmiştir.");
                        }
                        break;
                    default:                       
                        MessageBox.Show("Veritabanı Hatası!Hata Numarası:" + ex.Number);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!");
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmTurBul frm = new frmTurBul();
            frm.ShowDialog();
        }
    }
}
