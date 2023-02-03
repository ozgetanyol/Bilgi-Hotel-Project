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
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

      

        private void btngiris_Click(object sender, EventArgs e)
        {
            KullaniciGirisYetki.KullaniciGirisSorgula(txtkullaniciadi.Text, txtsifre.Text);

            if (KullaniciGirisYetki.GirisYapanYetki>0)
            {
                MessageBox.Show("Giriş Başarılı, Hoşgeldiniz");
                Anasayfa anasayfa= new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız, Lütfen Tekrar Deneyiniz.");
                txtsifre.Clear();
            }

        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
