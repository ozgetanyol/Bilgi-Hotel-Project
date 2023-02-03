using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PersonelYetkiEntity
    {

        public int PersonelId { get; set; }
        public int YetkiId { get; set; }
        public DateTime PersonelYetkiEnSonGirisTarihi { get; set; }
        public string PersonelYetkiAciklama { get; set; }
        public bool PersonelYetkiAktifMi { get; set; }
    }
}
