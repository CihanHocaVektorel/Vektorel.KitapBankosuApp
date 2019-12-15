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
   public class YayinEviBL
    {
        Helper hlp = new Helper();
        public List<YayinEvi> YayinEviListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select * from tblYayinEvleri");
            List<YayinEvi> lst = new List<YayinEvi>();
            while (dr.Read())
            {
                YayinEvi y = new YayinEvi();
                y.Ad = dr["Ad"].ToString();
                y.Adres = dr["Adres"].ToString();
                y.Telefon = dr["Tel"].ToString();
                y.YayinEviId = Convert.ToInt16(dr["YayinEviId"]);
                lst.Add(y);
            }
            dr.Close();
            return lst;
        }
    }
}
