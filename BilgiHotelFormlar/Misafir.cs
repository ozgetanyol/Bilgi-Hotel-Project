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
    public partial class Misafir : Form
    {
        public Misafir()
        {
            InitializeComponent();
        }
        ToolsDAL nesne = new ToolsDAL();

        int MisafirId;

        private void Misafir_Load(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxulke, "sp_UlkeListesiAll", "sp");
            nesne.ComboDoldur(cbxil, "sp_IlListesiAll", "sp");
            nesne.ComboDoldur(cbxilce, "sp_IlceListesiAll", "sp");
            nesne.ComboDoldur(cbxcinsiyet, "sp_CinsiyetListesiAll", "sp");
            nesne.ComboDoldur(cbxuyruk, "sp_UlkeListesiAll", "sp");
            nesne.ComboDoldur(cbxdil, "sp_DilListesiAll", "sp");
            nesne.IntComboDoldur(cbxkonaklamatip, "select MisafirId,KonaklamaTipNo from Misafir", "txt");

            nesne.ListViewDoldur(lwMisafir, "sp_MisafirListesiAll", null, "sp");

        }

        private void cbxil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxilce, "select * from Ilce where IlId=" + cbxil.SelectedValue.ToString(), Text);
        }

        private void cbxulke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nesne.ComboDoldur(cbxilce, "select * from Sehir where UlkeId=" + cbxulke.SelectedValue.ToString(), Text);
        }

        public MisafirEntity myParameters()
        {
            MisafirEntity myMisafir= new MisafirEntity();
            myMisafir.MisafirId = MisafirId;
            myMisafir.MisafirAd = txtad.Text;
            myMisafir.MisafirSoyad = txtsoyad.Text;
            myMisafir.MisafirTcKimlik = txttckimlik.Text;
            myMisafir.MisafirDogumTarihi = dtdogumtarihi.Value;
            myMisafir.MisafirUyrukId = Convert.ToInt32(cbxuyruk.SelectedValue);
            myMisafir.MisafirEposta = txteposta.Text;
            myMisafir.MisafirTelefon = txttelefon.Text;
            myMisafir.MisafirPasaportNo = txtpasaportno.Text;
            myMisafir.CinsiyetId = Convert.ToInt32(cbxcinsiyet.SelectedValue);
            myMisafir.MisafirAdres = txtadres.Text;
            myMisafir.IlId = Convert.ToInt32(cbxil.SelectedValue);
            myMisafir.IlceId = Convert.ToInt32(cbxilce.SelectedValue);
            myMisafir.UlkeId = Convert.ToInt32(cbxulke.SelectedValue);
            myMisafir.MisafirAciklama = txtaciklama.Text;
            myMisafir.MisafirHesKod = txtheskodu.Text;
            myMisafir.dilId = Convert.ToInt32(cbxdil.SelectedValue);
            myMisafir.KonaklamaTipNo = Convert.ToInt32(cbxkonaklamatip.SelectedValue);


            return myMisafir;
        }

        private void btnmisafirekle_Click(object sender, EventArgs e)
        {
            MisafirDAL myMisafirDAL = new MisafirDAL();

            int donensatir = myMisafirDAL.İnsertMisafir(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Eklendi");
        }

        private void btnmisafirguncelle_Click(object sender, EventArgs e)
        {
            MisafirDAL myMisafirDAL = new MisafirDAL();

            int donensatir = myMisafirDAL.UpdateMisafir(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Güncellendi");
        }

        private void btnmisafirsil_Click(object sender, EventArgs e)
        {
            MisafirDAL myMisafirDAL = new MisafirDAL();

            int donensatir = myMisafirDAL.DeleteMisafir(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Silindi");
        }

        private void lwMisafir_DoubleClick(object sender, EventArgs e)
        {
            MisafirId = Convert.ToInt32(lwMisafir.SelectedItems[0].SubItems[0].Text);


            nesne.FormDoldur("select * from Misafir where MisafirId= " + lwMisafir.SelectedItems[0].SubItems[0].Text, "txt", this);

            txtmisafirtcno.Text = "";
           
        }

        private void btnmisafirgetir_Click(object sender, EventArgs e)
        {
            nesne.GroupBoxDoldur("select * from Misafir where MisafirTcKimlik = '" + txtmisafirtcno.Text + "'", "txt", gbmisafirbilgileri);
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            nesne.ListViewDoldur(lwMisafir, "select * from Misafir", null, "txt");
        }
    }
}
