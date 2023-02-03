using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OdalarEntity
    {

        public int OdaId { get; set; }
        public int OdaEbatMsqr { get; set; }
        public int OdaTipiId { get; set; }
        public decimal OdaFiyat { get; set; }
        public string OdaYatakTipi{ get; set; }
        public bool OdaMiniBarOk { get; set; }
        public bool OdaKlimaOk { get; set; }
        public bool OdaKurutmaOk { get; set; }
        public bool OdaWifiOk { get; set; }
        public bool OdaKasaOk { get; set; }
        public bool OdaBalkonOk { get; set; }
        public bool OdaTvOk { get; set; }
        public string OdaAciklama { get; set; }
        public string OdaEbatBoyut { get; set; }
        public string OdaNo { get; set; }
        public int OdaKat { get; set; }
    }
}
