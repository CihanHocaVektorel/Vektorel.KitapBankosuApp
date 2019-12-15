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
        Helper hlp = new Helper();
        public bool TurEkle(Tur tur)
        {
            try
            {
                Helper hlp = new Helper();
                //SqlParameter[] pr = new SqlParameter[1];
                //pr[0] = new SqlParameter("@TurAd", turad);
                SqlParameter[] p = {new SqlParameter("@TurAd",tur.Turad)};

                return hlp.ExecuteNonQuery("Insert into tblTurler values(@TurAd)", p) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Tur> TurListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select * from tblTurler");
            List<Tur> lst = new List<Tur>();
            while (dr.Read())
            {
                Tur t = new Tur();
                t.Turad = dr["TurAd"].ToString();
                t.Turid = Convert.ToInt16(dr["TurId"]); 
                lst.Add(t);
            }
            dr.Close();
            return lst;
        }

    }
}
