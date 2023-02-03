using BilgiHotelDAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiHotelFormlar
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        ToolsDAL nesne = new ToolsDAL();

        int MusteriID;

        private void Musteriler_Load(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxmusteriulke, "sp_UlkeListesiAll", "sp");
            nesne.ComboDoldur(cbxmusteridil, "sp_DilListesiAll", "sp");
            nesne.ComboDoldur(cbxmusteriil, "sp_IlListesiAll", "sp");
            nesne.ComboDoldur(cbxmusteriilce, "sp_IlceListesiAll", "sp");

            nesne.ListViewDoldur(lwMusteriler, "sp_MusterilerListesiAll", null, "sp");

        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
           
            MusterilerDAL myMusteriDAL = new MusterilerDAL();

            int donensatir = myMusteriDAL.İnsertMusteriler(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Eklendi");


        }


        private void cbxmusteriil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxmusteriilce, "select * from Ilce where IlId=" + cbxmusteriil.SelectedValue.ToString(), Text);
        }

        private void cbxmusteriulke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxmusteriil, "select * from Sehir where UlkeId=" + cbxmusteriulke.SelectedValue.ToString(), Text);
        }

        public MusterilerEntity myParameters()
        {
            MusterilerEntity myMusteri = new MusterilerEntity();
            myMusteri.MusteriID = MusteriID;
            myMusteri.MusteriAd = txtmusteriad.Text;
            myMusteri.MusteriSoyad = txtmusterisoyad.Text;
            myMusteri.MusteriTCKimlik = txtTcNo.Text;
            myMusteri.MusteriPasaportNo = txtmusteripasaportno.Text;
            myMusteri.MusteriUnvan = txtmusteriunvan.Text;
            myMusteri.MusteriYetkiliAdSoyad = txtmusteriyetkiliad.Text;
            myMusteri.MusteriVergiNo = txtmusterivergino.Text;
            myMusteri.MusteriVergiDairesi = txtmusterivergidairesi.Text;
            myMusteri.MusteriTelefon = txttelefonno.Text;
            myMusteri.MusteriPosta = txtmusterieposta.Text;
            myMusteri.MusteriAdres = txtmusteriadres.Text;
            myMusteri.IlID = Convert.ToInt32(cbxmusteriil.SelectedValue);
            myMusteri.IlceID = Convert.ToInt32(cbxmusteriilce.SelectedValue);
            myMusteri.UlkeID = Convert.ToInt32(cbxmusteriulke.SelectedValue);
            myMusteri.MusteriAciklama = txtmusteriaciklama.Text;
            myMusteri.MusteriKurumsalOK = Convert.ToBoolean(cbxkurumsal.Checked);
            myMusteri.DilID = Convert.ToInt32(cbxmusteridil.SelectedValue);

            return myMusteri;

        }

        private void cbxmusteriulke_Click(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxmusteriulke, "sp_UlkeListesiAll", "sp");
        }

        private void cbxmusteridil_Click(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxmusteridil, "sp_DilListesiAll", "sp");
        }

        private void btnmusteriguncelle_Click(object sender, EventArgs e)
        {
            MusterilerDAL myMusteriDAL = new MusterilerDAL();

            int donensatir = myMusteriDAL.UpdateMusteriler(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Güncellendi");
        }

        private void btnmusteribul_Click(object sender, EventArgs e)
        {
            nesne.GroupBoxDoldur("Select * From Musteriler where MusteriTCKimlik = '"+txtmusteritckimlik.Text+"'","txt",gbmusteribilgileri);
            
        }

        private void btnmusterisil_Click(object sender, EventArgs e)
        {
            MusterilerDAL myMusteriDAL = new MusterilerDAL();

            int donensatir = myMusteriDAL.DeleteMusteriler(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Silindi");
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            btnmusteribul.Visible = false;
            btnmusteriekle.Visible = false;
            btnmusterisil.Visible = false;
            btnmusteriguncelle.Visible = false;
            ToolsDAL.Temizle(this);
        }

        private void btnrezervasyongetir_Click(object sender, EventArgs e)
        {
            Rezervasyon frmmrezervasyon = new Rezervasyon();
            frmmrezervasyon.Show();
            this.Hide();//nesne.FormDoldur("sp_MusteriTcyeGoreRezervasyonGetir","sp",);
        }

        private void lwMusteriler_DoubleClick(object sender, EventArgs e)
        {
            MusteriID = Convert.ToInt32(lwMusteriler.SelectedItems[0].SubItems[0].Text);


            nesne.FormDoldur("select * from Musteriler where MusteriID= " + lwMusteriler.SelectedItems[0].SubItems[0].Text, "txt", this);
            txtmusteritckimlik.Text = "";
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            nesne.ListViewDoldur(lwMusteriler,"select * from Musteriler",null,"txt");
        }
    }

}   
