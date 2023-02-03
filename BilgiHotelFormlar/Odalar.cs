using BilgiHotelDAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiHotelFormlar
{
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        ToolsDAL nesne = new ToolsDAL();

        int OdaId;
        private void Odalar_Load(object sender, EventArgs e)
        {
            //nesne.ComboDoldur(cbxodayatak, " select OdaId,OdaYatakTipi from Odalar", "txt");
            //nesne.ComboDoldur(cbxodano, "select OdaId,OdaNo from Odalar", "txt");
            //nesne.IntComboDoldur(cbxodakat, " select OdaId,OdaKat from Odalar", "txt");
            //nesne.IntComboDoldur(cbxodatipi, "select OdaId,OdaTipiId from Odalar", "txt");
           



            nesne.ListViewDoldur(lwOdalar, "sp_OdaListesiAll", null, "sp");
        }

        private void lwOdalar_DoubleClick(object sender, EventArgs e)
        {
            OdaId = Convert.ToInt32(lwOdalar.SelectedItems[0].SubItems[0].Text);


            nesne.FormDoldur("select * from Odalar where OdaId= " + lwOdalar.SelectedItems[0].SubItems[0].Text, "txt", this);
          
        }

        public OdalarEntity myParameters()
        {
            OdalarEntity myOda = new OdalarEntity();

            myOda.OdaId = OdaId;
            myOda.OdaEbatMsqr = Convert.ToInt32(txtodaebatmsgr.Text);
            myOda.OdaTipiId = Convert.ToInt32(txtodatipi.Text);
            myOda.OdaFiyat = Convert.ToDecimal(txtfiyat.Text);
            myOda.OdaYatakTipi = txtodayatak.Text.ToString();
            myOda.OdaMiniBarOk=cbminibar.Checked;
            myOda.OdaKlimaOk=cbklima.Checked;
            myOda.OdaKurutmaOk=cbsackurutma.Checked;
            myOda.OdaWifiOk=cbwifi.Checked;
            myOda.OdaKasaOk=cbkasa.Checked;
            myOda.OdaBalkonOk=cbbalkon.Checked;
            myOda.OdaTvOk=cbtv.Checked;
            myOda.OdaAciklama = txtodaaciklama.Text;
            myOda.OdaEbatBoyut=txtebatboyut.Text;
            myOda.OdaNo = txtodano.Text.ToString();
            myOda.OdaKat = Convert.ToInt32(txtodakat.Text);


            return myOda;
        }

        private void btnodaekle_Click(object sender, EventArgs e)
        {
            OdalarDAL myOdaDAL = new OdalarDAL();

            int donensatir = myOdaDAL.İnsertOdalar(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Eklendi");
        }

        private void btnodasil_Click(object sender, EventArgs e)
        {
            OdalarDAL myOdaDAL = new OdalarDAL();
            int donensatir = myOdaDAL.DeleteOdalar(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Silindi");

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            OdalarDAL myOdaDAL = new OdalarDAL();
            int donensatir = myOdaDAL.UpdateOdalar(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Güncellendi");
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            nesne.ListViewDoldur(lwOdalar, "sp_OdaListesiAll",null, "sp");
        }
    }
}
