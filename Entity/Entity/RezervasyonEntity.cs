using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RezervasyonEntity
    {
        public int RezervasyonId { get; set; }
        public int MusteriId { get; set; }
        public DateTime RezervasyonGecerlilikTarihi { get; set; }
        public DateTime RezervasyonGecerlilikSonTarihi { get; set; }
        public int ErkenRezervasyonIndirim { get; set; }
        public int RezervasyonTipiId { get; set; }
        public string RezervasyonAciklama { get; set; }
        public bool RezervasyonIptalOk { get; set; }
    }
}
