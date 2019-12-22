using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.KitapBankosu.BLL;

namespace Vektorel.KitapBankosuApp
{
    public partial class frmKitapListe : Form
    {
        DataTable dt;
        public frmKitapListe()
        {
            InitializeComponent();
            grdKitaplar.AutoGenerateColumns = false;
        }

        private void FrmKitapListe_Load(object sender, EventArgs e)
        {
            KitapBL kbl = new KitapBL();
            dt = kbl.KitapTablosu();
            grdKitaplar.DataSource = dt;
        }

        private void GrdKitaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int kitapid = Convert.ToInt32(dt.Rows[e.RowIndex]["KitapId"]);
            frmKitapIslemleri frm = new frmKitapIslemleri(kitapid);
            frm.Show();
        }
    }
}
