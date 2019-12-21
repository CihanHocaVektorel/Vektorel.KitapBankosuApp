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
    public partial class frmKitapListe : Form
    {
        DataTable dt;
        public frmKitapListe()
        {
            InitializeComponent();
            grdYazarlar.AutoGenerateColumns = false;
        }

        private void FrmKitapListe_Load(object sender, EventArgs e)
        {
            YazarBL yz = new YazarBL();
            dt = yz.YazarTablosu();
            grdYazarlar.DataSource = dt;
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            YazarBL yb = new YazarBL();
            foreach (DataRow item in dt.Rows)
            {
                Yazar yz = new Yazar();
                if (item.RowState != DataRowState.Deleted)
                {                    
                    yz.Ad = item["Ad"].ToString();
                    yz.Soyad = item["Soyad"].ToString();
                    yz.DTar = Convert.ToDateTime(item["DTar"]);
                    if (item["OlumTarih"].ToString() != "")
                    {
                        yz.OlumTarih = Convert.ToDateTime(item["OlumTarih"]);
                    }
                    yz.Yazarid = Convert.ToInt32(item["YazarId"]);
                }
               
                switch (item.RowState)
                {
                    case DataRowState.Added:
                        yb.YazarEkle(yz);
                        break;
                    case DataRowState.Deleted:
                        yb.YazarSil(Convert.ToInt32(item["YazarId",DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        yb.YazarGuncelle(yz);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
