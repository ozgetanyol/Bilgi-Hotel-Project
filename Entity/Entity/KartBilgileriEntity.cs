using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KartBilgileriEntity
    {

        public int KartId { get; set; }
        public int OdaId { get; set; }
        public  bool KartAktifMi { get; set; }
        public int PersonelId { get; set; }
        public int MisafirId { get; set; }
        public  DateTime KartVerilisTarihi { get; set; }
        public DateTime KartAlisTarihi { get; set; }
        public string KartIslemAciklama { get; set; }
    }
}
