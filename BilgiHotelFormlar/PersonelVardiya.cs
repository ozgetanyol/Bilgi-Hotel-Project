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
    public partial class PersonelVardiya : Form
    {
        public PersonelVardiya()
        {
            InitializeComponent();
        }
        ToolsDAL nesne = new ToolsDAL();

        
      

        private void PersonelVardiya_Load(object sender, EventArgs e)
        {
            
            nesne.ComboDoldur(cbxpersonelad, "select PersonelId,PersonelAd+' ' +PersonelSoyad as AdSoyad from Personel", "txt");
            nesne.ComboDoldur(cbxpersonelvardiyasaati, "  select VardiyaId, VardiyaTipi from Vardiya", "txt");

            //nesne.ListViewDoldur(lwPersonelVardiya, "sp_AdSoyadaGorePersonelVardiyaGetir", "sp");
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int Ucret;
            DateTime İseBaslama = Convert.ToDateTime(txtpersonelisebaslamasaati.Text);
            DateTime İstenCikis = Convert.ToDateTime(txtistencikissaati.Text);

            TimeSpan Sonuc;
            Sonuc = İstenCikis - İseBaslama;

            lblcalisma.Text = Sonuc.TotalHours.ToString();
            txtsaatlikucret.Text = Sonuc.TotalMinutes.ToString();

            Ucret = Convert.ToInt32(lblcalisma.Text) * Convert.ToInt32(txtsaatlikucret.Text);
            txtpersoneltutar.Text = Ucret.ToString();
        }

        private void cbxpersonelad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxpersonelvardiyasaati,"select v.VardiyaId,v.VardiyaTipi from Personel as p JOIN PersonelVardiya as pv ON p.PersonelId = pv.PersonelId JOIN Vardiya as v ON pv.VardiyaId = v.VardiyaId where p.PersonelId = " + cbxpersonelad.SelectedValue.ToString(), Text);

          

        }

      

        private void cbxpersonelvardiyasaati_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

            lbpersonelvardiya.Items.Add(cbxpersonelad.GetItemText(cbxpersonelad.SelectedItem) + "  :  " + cbxpersonelvardiyasaati.GetItemText(cbxpersonelvardiyasaati.SelectedItem));
          

            //lbpersonelvardiya.Items.Clear();
        }

      



    }
}
