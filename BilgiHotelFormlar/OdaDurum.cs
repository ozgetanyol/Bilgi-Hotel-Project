using BilgiHotelDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiHotelFormlar
{
    public partial class OdaDurum : Form
    {
        public OdaDurum()
        {
            InitializeComponent();
        }

        ToolsDAL nesne = new ToolsDAL();

        private void dtodacikis_ValueChanged(object sender, EventArgs e)
        {
           
            DateTime İlkTarih = Convert.ToDateTime(dtodagiris.Text);
            DateTime SonTarih = Convert.ToDateTime(dtodacikis.Text);

            TimeSpan Sonuc;
            Sonuc = SonTarih - İlkTarih;

            lblkaldigigun.Text = Sonuc.TotalDays.ToString();

         
        }

        private void btnodasorgula_Click(object sender, EventArgs e)
        {
            nesne.ListViewDoldur(listView1,"select o.odaNo, o.OdaAciklama, dk.DurumKategoriAd  from Satis as s join Odalar as o on o.OdaId=s.OdaId join OdaDurum as od on o.OdaId=od.OdaId join DurumKategori as dk on od.DurumKategoriId=dk.DurumKategoriId where (SatisOdaGirisTarihi between '" +dtodagiris.Value.ToString("yyyy-MM-dd HH':'mm':'ss")+ "' and '" + dtodacikis.Value.ToString("yyyy-MM-dd HH':'mm':'ss")+ "') or (SatisOdaCikisTarihi between '"+dtodagiris.Value.ToString("yyyy-MM-dd HH':'mm':'ss") + "' and '" + dtodacikis.Value.ToString("yyyy-MM-dd HH':'mm':'ss")+ "') or ((SatisOdaGirisTarihi<'" + dtodagiris.Value.ToString("yyyy-MM-dd HH':'mm':'ss") + "' and SatisOdaCikisTarihi>'"+dtodagiris.Value.ToString("yyyy-MM-dd HH':'mm':'ss") + "') or (SatisOdaGirisTarihi<'" + dtodacikis.Value.ToString("yyyy-MM-dd HH':'mm':'ss") + "' and SatisOdaCikisTarihi>'" + dtodacikis.Value.ToString("yyyy-MM-dd HH':'mm':'ss")+ "'))  ",null,"text");
        }
    }
}
