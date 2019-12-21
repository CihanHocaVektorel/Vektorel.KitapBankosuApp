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
        }

        private void FrmKitapListe_Load(object sender, EventArgs e)
        {
            YazarBL yz = new YazarBL();
            grdYazarlar.DataSource = yz.YazarTablosu();
        }
    }
}
