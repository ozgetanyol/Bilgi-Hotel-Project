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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        ToolsDAL nesne = new ToolsDAL();

        int SatisId;

        public SatisEntity myParameters()
        {
            SatisEntity mySatis = new SatisEntity();
            mySatis.SatisId = SatisId;
            mySatis.SatisOdaGirisTarihi = dtodagiris.Value;
            mySatis.SatisOdaCikisTarihi = dtodacikis.Value;
            mySatis.SatisIndirim = Convert.ToInt32(txtsatisindirim.Text); 
            mySatis.KartId = Convert.ToInt32(txtkartid.Text);
            mySatis.OdaId = Convert.ToInt32(txtodaid.Text);
            mySatis.OdaSatisDurum = Convert.ToBoolean(cxsatisdurum.Checked);
            mySatis.OdaSatisTutar = Convert.ToDecimal(txtodasatistutar.Text);
            mySatis.OdaSatisKDV = Convert.ToInt32(txtodasatiskdv.Text);
            mySatis.OdaSatisOdemeTipiId = Convert.ToInt32(txtodasatisodeme.Text);
           

            return mySatis;
        }

        private void Satis_Load(object sender, EventArgs e)
        {
            nesne.ListViewDoldur(lwSatis, "sp_SatisListesiAll", null, "sp");
        }

        private void lwSatis_DoubleClick(object sender, EventArgs e)
        {
            SatisId = Convert.ToInt32(lwSatis.SelectedItems[0].SubItems[0].Text);


            nesne.FormDoldur("select * from Satis where SatisId= " + lwSatis.SelectedItems[0].SubItems[0].Text, "txt", this);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SatisDAL mySatisDAL = new SatisDAL();

            int donensatir = mySatisDAL.İnsertSatis(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Eklendi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SatisDAL mySatisDAL = new SatisDAL();

            int donensatir = mySatisDAL.UpdateSatis(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Güncellendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SatisDAL mySatisDAL = new SatisDAL();

            int donensatir = mySatisDAL.DeleteSatis(myParameters());
            MessageBox.Show(donensatir.ToString() + " Adet Kayıt Silindi");
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            nesne.ListViewDoldur(lwSatis, "select * from Satis", null, "txt");
        }
    }
}
