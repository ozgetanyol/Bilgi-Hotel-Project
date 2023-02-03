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
    public partial class Kampanyalar : Form
    {
        public Kampanyalar()
        {
            InitializeComponent();
        }
        ToolsDAL nesne = new ToolsDAL();

        int KampanyaId;
       

        public KampanyalarEntity myParameters()
        {
            KampanyalarEntity myKampanya = new KampanyalarEntity();
            myKampanya.KampanyaId = KampanyaId;
            myKampanya.KampanyaBilgileri = txtkampanyabilgileri.Text;
            myKampanya.KampanyaIndirimOran = Convert.ToInt32(txtkampanyaindirimoran.Text);
            myKampanya.KampanyaBaslangicZaman = Convert.ToDateTime(dtkampanyabaslangic.Value);
            myKampanya.KampanyaBitisTarihi = Convert.ToDateTime(dtkampanyabitis.Value);
            myKampanya.KampanyaTanim = txtkampanyatanim.Text;

            return myKampanya;
        }

        private void Kampanyalar_Load_1(object sender, EventArgs e)
        {
           

            nesne.ListViewDoldur(lwkampanyalar, "sp_KampanyaListesiAll", null, "sp");
        }

        private void btnkampanyaekle_Click(object sender, EventArgs e)
        {
            KampanyalarDAL myKampanyaDAL = new KampanyalarDAL();

            int donensatir = myKampanyaDAL.İnsertKampanyalar(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Eklendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            KampanyalarDAL myKampanyaDAL = new KampanyalarDAL();

            int donensatir = myKampanyaDAL.DeleteKampanyalar(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Silindi");

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            KampanyalarDAL myKampanyaDAL = new KampanyalarDAL();

            int donensatir = myKampanyaDAL.UpdateKampanyalar(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Güncellendi");
        }

        private void lwkampanyalar_DoubleClick(object sender, EventArgs e)
        {
            KampanyaId = Convert.ToInt32(lwkampanyalar.SelectedItems[0].SubItems[0].Text);


            nesne.FormDoldur("select * from Kampanyalar where KampanyaId= " + lwkampanyalar.SelectedItems[0].SubItems[0].Text, "txt", this);
          
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            nesne.ListViewDoldur(lwkampanyalar, "sp_KampanyaListesiAll", null, "sp");
        }
    }
}
