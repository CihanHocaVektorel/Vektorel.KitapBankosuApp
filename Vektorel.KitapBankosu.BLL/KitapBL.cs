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
    public class KitapBL
    {
        Helper hlp = new Helper();
        public bool KitapEkle(Kitap k)
        {
            SqlParameter[] p = { new SqlParameter("@KitapAd", k.KitapAd), new SqlParameter("@TurId", k.TurId), new SqlParameter("@SayfaSayi", k.SayfaSayi), new SqlParameter("@BasimYil", k.BasimYil), new SqlParameter("@Adet", k.Adet), new SqlParameter("@YayinEviId", k.YayinEviId), new SqlParameter("@Isbn", k.Isbn) };

            return hlp.ExecuteNonQuery("Insert into tblKitaplar values(@KitapAd,@TurId,@SayfaSayi,@BasimYil,@Adet,@YayinEviId,@Isbn)", p) > 0;
        }

        public short SonEklenenKitap()
        {
            short kitapid = 0;
            SqlDataReader dr = hlp.ExecuteReader("Select Top 1 KitapId from tblKitaplar Order By KitapId Desc", null);

            if (dr.Read())
            {
                kitapid = Convert.ToInt16(dr["KitapId"]);
            }
            dr.Close();
            return kitapid;
        }
    }
}
