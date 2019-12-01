using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.DAL;
using Vektorel.KitapBankosu.Models;

namespace Vektorel.KitapBankosu.BLL
{
    public class TurBL
    {
        public bool TurEkle(Tur tur)
        {
            try
            {
                Helper hlp = new Helper();

                //SqlParameter[] pr = new SqlParameter[1];
                //pr[0] = new SqlParameter("@TurAd", turad);

                SqlParameter[] p = {new SqlParameter("@TurAd",tur.Turad)};

                return hlp.ExcuteNonQuery("Insert into tblTurler values(@TurAd)", p) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
