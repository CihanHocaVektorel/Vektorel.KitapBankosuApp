using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.DAL;
using Vektorel.KitapBankosu.Models;

namespace Vektorel.KitapBankosu.BLL
{
    public class YazarBL
    {
        Helper hlp = new Helper();
        public bool YazarEkle(Yazar yazar)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", yazar.Ad), new SqlParameter("@Soyad", yazar.Soyad), new SqlParameter("@DTar", yazar.DTar), new SqlParameter("@OlumTarih", yazar.OlumTarih) };
                if (yazar.OlumTarih == DateTime.MinValue)
                {
                    p[3].Value = DBNull.Value;
                }

                return hlp.ExecuteNonQuery("Insert into tblYazarlar values(@Ad,@Soyad,@DTar,@OlumTarih)", p) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Yazar YazarBul(string yazarad)
        {
            SqlParameter[] p = { new SqlParameter("@Ad", yazarad) };
            SqlDataReader dr = hlp.ExecuteReader("Select * from tblYazarlar Where Ad=@Ad", p);
            Yazar yz = null;
            if (dr.Read())
            {
                yz = new Yazar();
                yz.Ad = dr["Ad"].ToString();
                yz.Soyad = dr["Soyad"].ToString();
                yz.DTar = Convert.ToDateTime(dr["Dtar"]);
                if (dr["OlumTarih"].ToString() != ""|| yz.OlumTarih != DateTime.MinValue)
                {
                    yz.OlumTarih = Convert.ToDateTime(dr["OlumTarih"]);
                }               

            }
            dr.Close();
            return yz;
        }
    }
}
