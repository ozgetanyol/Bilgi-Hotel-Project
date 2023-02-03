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
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }

        ToolsDAL nesne = new ToolsDAL();

        int RezervasyonId;
        private void btnrezervasyonguncelle_Click(object sender, EventArgs e)
        {
            RezervasyonDAL myRezervasyonDAL = new RezervasyonDAL();

            int donensatir = myRezervasyonDAL.UpdateRezervasyon(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Güncellendi");
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxrezervasyontipi, "sp_RezervasyonTipListesiAll", "sp");

            nesne.ListViewDoldur(lwrezervasyon, "sp_RezervasyonListesiAll", null, "sp");
        }


        public RezervasyonEntity myParameters()
        {
            RezervasyonEntity myRezervasyon = new RezervasyonEntity();
            myRezervasyon.RezervasyonId = RezervasyonId;
            myRezervasyon.MusteriId = Convert.ToInt32(txtrezervasyonmusteriid.Text);
            myRezervasyon.RezervasyonGecerlilikTarihi = dtrezervasyongecerliliktarihi.Value;
            myRezervasyon.RezervasyonGecerlilikSonTarihi = dtrezervasyongecerliliksontarih.Value;
            myRezervasyon.ErkenRezervasyonIndirim = Convert.ToInt32(txtindirim.Text);
            myRezervasyon.RezervasyonTipiId = Convert.ToInt32(cbxrezervasyontipi.SelectedValue);
            myRezervasyon.RezervasyonAciklama = txtrezervasyonaciklama.Text;
            myRezervasyon.RezervasyonIptalOk = Convert.ToBoolean(cxiptal.Checked);

            return myRezervasyon;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            RezervasyonDAL myRezervasyonDAL = new RezervasyonDAL();

            int donensatir = myRezervasyonDAL.İnsertRezervasyon(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Eklendi");

        }

        private void btnrezervasyonsil_Click(object sender, EventArgs e)
        {

            RezervasyonDAL myRezervasyonDAL = new RezervasyonDAL();

            int donensatir = myRezervasyonDAL.DeleteRezervasyon(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Silindi");
        }

        private void lwrezervasyon_DoubleClick(object sender, EventArgs e)
        {
            RezervasyonId = Convert.ToInt32(lwrezervasyon.SelectedItems[0].SubItems[0].Text);


            nesne.FormDoldur("select * from Rezervasyon where RezervasyonId= " + lwrezervasyon.SelectedItems[0].SubItems[0].Text, "txt", this);
            txtmusteriid.Text = "";

        }

        private void btnrezervasyongetir_Click(object sender, EventArgs e)

            
        {
            nesne.GroupBoxDoldur("Select * from Rezervasyon  where MusteriId = '" + txtmusteriid.Text + "'", "txt", gbrezervasyon);
        }
    }
}
