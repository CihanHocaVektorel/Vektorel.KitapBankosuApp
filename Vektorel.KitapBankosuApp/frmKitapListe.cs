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

namespace Vektorel.KitapBankosuApp
{
    public partial class frmKitapListe : Form
    {
        public frmKitapListe()
        {
            InitializeComponent();
            grdKitaplar.AutoGenerateColumns = false;
        }

        private void FrmKitapListe_Load(object sender, EventArgs e)
        {
            KitapBL kbl = new KitapBL();
            grdKitaplar.DataSource = kbl.KitapTablosu();
        }
    }
}
