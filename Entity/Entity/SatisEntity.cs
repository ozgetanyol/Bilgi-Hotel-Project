using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SatisEntity
    {
        public int SatisId { get; set; }
        public DateTime SatisOdaGirisTarihi { get; set; }
        public DateTime SatisOdaCikisTarihi { get; set; }
        public int SatisIndirim { get; set; }
        public int KartId { get; set; }
        public int OdaId { get; set; }
        public bool OdaSatisDurum { get; set; }
        public decimal OdaSatisTutar { get; set; }
        public int OdaSatisKDV { get; set; }
        public int OdaSatisOdemeTipiId { get; set; }
    }
}
