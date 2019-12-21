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
    public class KitapYazarBL
    {
        Helper hlp = new Helper();
        public bool KitapYazarEkle(KitapYazar ky)
        {
            SqlParameter[] p = {new SqlParameter("@Yazarid",ky.Yazarid),new SqlParameter("@Kitapid",ky.Kitapid) };
            return hlp.ExecuteNonQuery("Insert into tblKitapYazar values(@Yazarid,@Kitapid)", p)>0;
        }
    }
}
