using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ResimlerEntity
    {

        public int ResimId { get; set; }
        public string ResimUrlAdres { get; set; }
        public string ResimAciklama { get; set; }
        public bool ResimAktifOk { get; set; }
        public string ResimAlternatifText { get; set; }
    }
}
