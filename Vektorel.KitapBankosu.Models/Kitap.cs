using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.KitapBankosu.Models
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAd { get; set; }
        public short TurId { get; set; }
        public short SayfaSayi { get; set; }
        public short BasimYil { get; set; }
        public short Adet { get; set; }
        public short YayinEviId { get; set; }
        public string Isbn { get; set; }



    }
}
