using BilgiHotelDAL;
using Entity;
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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        ToolsDAL nesne = new ToolsDAL();
        int PersonelId;
        private void Personeller_Load(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxulke, "sp_UlkeListesiAll", "sp");
            nesne.ComboDoldur(cbxil, "sp_IlListesiAll", "sp");
            nesne.ComboDoldur(cbxilce, "sp_IlceListesiAll", "sp");
            nesne.ComboDoldur(cbxcinsiyet, "sp_CinsiyetListesiAll", "sp");
            nesne.ComboDoldur(cbxkategori, "sp_PersonelKategoriListesiAll", "sp");
            nesne.ComboDoldur(cbxgorev, "sp_GorevListesiAll", "sp");
            nesne.ComboDoldur(cbxresim, "sp_ResimlerListesiAll", "sp");
            nesne.ComboDoldur(cbxvardiya, "sp_VardiyaListesiAll", "sp");
            nesne.ComboDoldur(cbxuyruk, "sp_UlkeListesiAll", "sp");

            nesne.ListViewDoldur(lwPersonel, "sp_PersonelListesiAll", null, "sp");

        }

        private void btnpersonelsil_Click(object sender, EventArgs e)
        {
            PersonelDAL myPersonelDAL = new PersonelDAL();

            int donensatir = myPersonelDAL.DeletePersonel(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Silindi");
        }
        public PersonelEntity myParameters()
        {
            PersonelEntity myPersonel = new PersonelEntity();
            myPersonel.PersonelId = PersonelId;
            myPersonel.PersonelAd = txtpersonelad.Text;
            myPersonel.PersonelSoyad = txtpersonelsoyad.Text;
            myPersonel.PersonelTcKimlik = txttcno.Text;
            myPersonel.PersonelDogumTarihi = dtdogumtarihi.Value;
            myPersonel.PersonelUyrukId = Convert.ToInt32(cbxuyruk.SelectedValue);
            myPersonel.PersonelEposta = txteposta.Text;
            myPersonel.PersonelTelefon = txttelefon.Text;
            myPersonel.PersonelPasaportNo = txtpasaportno.Text;
            myPersonel.CinsiyetId = Convert.ToInt32(cbxcinsiyet.SelectedValue);
            myPersonel.PersonelIseGirisTarihi = dtisegiris.Value;
            myPersonel.PersonelIstenCikisTarihi = dtistencikis.Value;
            myPersonel.PersonelSaatlikUcret = Convert.ToDecimal(txtsaatlikucret.Text);
            myPersonel.PersonelMaas= Convert.ToDecimal(txtmaas.Text);
            myPersonel.PersonelSicilNo = txtsicilno.Text;
            myPersonel.GorevId = Convert.ToInt32(cbxgorev.SelectedValue);
            myPersonel.PersonelKategoriID = Convert.ToInt32(cbxkategori.SelectedValue);
            myPersonel.PersonelEngelDurumu=Convert.ToBoolean(cxengel.Checked);
            myPersonel.PersonelHesKodu = txthes.Text;
            myPersonel.IlId = Convert.ToInt32(cbxil.SelectedValue);
            myPersonel.IlceId = Convert.ToInt32(cbxilce.SelectedValue);
            myPersonel.UlkeId = Convert.ToInt32(cbxulke.SelectedValue);
            myPersonel.PersonelAdres = txtadres.Text;
            myPersonel.PersonelAcilDurumKisiAd=txtadaranacakkisi.Text;
            myPersonel.PersonelAcilDurumKisiTelefon=txtaranacak.Text;
            myPersonel.ResimId = Convert.ToInt32(cbxresim.SelectedValue);
            myPersonel.VardiyaId = Convert.ToInt32(cbxvardiya.SelectedValue);



            return myPersonel;
        }

        private void btnpersonelekle_Click(object sender, EventArgs e)
        {
            PersonelDAL myPersonelDAL = new PersonelDAL();

            int donensatir = myPersonelDAL.İnsertPersonel(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Eklendi");
        }

        private void btntcyegoregetir_Click(object sender, EventArgs e)
        {
            nesne.GroupBoxDoldur("Select * From Personel where PersonelTcKimlik = '" + txtpersoneltckimlik.Text + "'","txt", gbpersonelbilgileri);
        }

        private void cbxil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxilce, "select * from Ilce where IlId=" + cbxil.SelectedValue.ToString(), Text);
        }

        private void cbxulke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxilce, "select * from Sehir where UlkeId=" + cbxulke.SelectedValue.ToString(), Text);
        }

        private void btnpersonelguncelle_Click(object sender, EventArgs e)
        {
            PersonelDAL myPersonelDAL = new PersonelDAL();

            int donensatir = myPersonelDAL.UpdatePersonel(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Güncellendi");
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            btnpersonelekle.Visible = false;
            btnpersonelsil.Visible = false;
            btnpersonelguncelle.Visible = false;
            btntcyegoregetir.Visible = false;
            PersonelId = 0;
            ToolsDAL.Temizle(this);
        }

        private void lwPersonel_DoubleClick(object sender, EventArgs e)
        {
            PersonelId = Convert.ToInt32(lwPersonel.SelectedItems[0].SubItems[0].Text);


            nesne.FormDoldur("select * from Personel where PersonelId= " + lwPersonel.SelectedItems[0].SubItems[0].Text, "txt", this);
            txtpersoneltckimlik.Text = "";




        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            nesne.ListViewDoldur(lwPersonel, "select * from Personel",null,"txt");
        }

        private void btnvardiyagetir_Click(object sender, EventArgs e)
        {
            PersonelVardiya frmpersonelvardiya = new PersonelVardiya();
            frmpersonelvardiya.Show();
            this.Hide();
        }

        private void btnodagetir_Click(object sender, EventArgs e)
        {
            Odalar frmodalar = new Odalar();
            frmodalar.Show();   
            this.Hide();
        }

        private void btnrezervasyon_Click(object sender, EventArgs e)
        {
            Rezervasyon frmrezervasyon = new Rezervasyon();
            frmrezervasyon.Show();
            this.Hide();
        }
    }
}
