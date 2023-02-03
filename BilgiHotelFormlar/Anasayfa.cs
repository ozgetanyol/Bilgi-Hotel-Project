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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BilgiHotelFormlar
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
       
        

        private void btnkullanicigiris_Click(object sender, EventArgs e)
        {
            KullaniciGiris frmkullanicigiris = new KullaniciGiris();
            FormGetir(frmkullanicigiris);
        }

        private void FormGetir(Form frm)
        {
           
            
            Form myForm = this.ActiveMdiChild;
            if (myForm != null)
            {
                myForm.Hide();
            }
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void btnmusteriler_Click(object sender, EventArgs e)
        {
            
            Musteriler frmmusteriler = new Musteriler();
            FormGetir(frmmusteriler);
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(KullaniciGirisYetki.GirisYapanYetki) ==1)
            {
                btnpersonel.Enabled = true;
                btnkampanyalar.Enabled = true;
                btnmisafir.Enabled = true;
                btnayarlar.Enabled = true;
                btnmusteriler.Enabled = true;

            }
        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            Personeller frmpersonel = new Personeller();
            FormGetir(frmpersonel);
        }

     

        private void btnoda_Click(object sender, EventArgs e)
        {
            Odalar frmodalar = new Odalar();
            FormGetir(frmodalar);
        }

      

        private void btnvardiyalar_Click(object sender, EventArgs e)
        {
            PersonelVardiya frmpersonelvardiya = new PersonelVardiya();
            FormGetir(frmpersonelvardiya);
        }

        private void btnayarlar_Click(object sender, EventArgs e)
        {
            Ayarlar frmayarlar = new Ayarlar();
            FormGetir(frmayarlar);
        }

        private void btnkampanyalar_Click(object sender, EventArgs e)
        {
            Kampanyalar frmkampanyalar = new Kampanyalar();
            FormGetir(frmkampanyalar);
        }

        private void btnmisafir_Click(object sender, EventArgs e)
        {
            Misafir frmmisafir = new Misafir();
            FormGetir(frmmisafir);
        }

        private void btnrezervayon_Click(object sender, EventArgs e)
        {
            Rezervasyon frmrezervasyon = new Rezervasyon();
            FormGetir(frmrezervasyon);
        }

        private void btnsatisvefatura_Click(object sender, EventArgs e)
        {
            Satis frmsatis = new Satis();
            FormGetir(frmsatis);
        }

        private void btnodadurum_Click(object sender, EventArgs e)
        {
            OdaDurum frmodadurum = new OdaDurum();
            FormGetir(frmodadurum);
             
        }

        private void btnayarlar_Click_1(object sender, EventArgs e)
        {
            Ayarlar frmayarlar = new Ayarlar();
            FormGetir(frmayarlar);
        }
    }
}
