using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class MusterilerEntity
    {

        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriTCKimlik { get; set; }
        public string MusteriPasaportNo { get; set; }
        public string MusteriUnvan { get; set; }
        public string MusteriYetkiliAdSoyad { get; set; }
        public string MusteriVergiNo { get; set; }
        public string MusteriVergiDairesi { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusteriPosta { get; set; }
        public string MusteriAdres { get; set; }
        public int IlID { get; set; }
        public int IlceID { get; set; }
        public int UlkeID { get; set; }
        public string MusteriAciklama { get; set; }
        public bool MusteriKurumsalOK { get; set; }
        public int DilID { get; set; }


    }
}
