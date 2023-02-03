using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class MesaiPersonelEntity
    {

        public int MesaiId { get; set; }
        public DateTime MesaiBaslangicTarihi { get; set; }
        public DateTime MesaiBitisTarihi { get; set; }
        public int PersonelId { get; set; }
        public Decimal MesaiSaatFark { get; set; }
    }
}
