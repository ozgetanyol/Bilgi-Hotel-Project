using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class KullaniciEntity
    {

        public int KullaniciId { get; set; }
        public int KullaniciTipiId { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciParola { get; set; }
        public string KullaniciEposta { get; set; }
        public string KullaniciEpostaOnayKod { get; set; }
        public bool KullaniciEpostaOnay { get; set; }
        public DateTime KullaniciKayıtTarihi { get; set; }
        public DateTime KullaniciSonGirisTarihi { get; set; }
        public int DilId { get; set; }
        public int ResimId { get; set; }

    }
}
