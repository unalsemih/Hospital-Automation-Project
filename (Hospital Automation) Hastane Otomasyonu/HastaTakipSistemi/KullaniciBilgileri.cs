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

namespace HastaTakipSistemi
{
    public partial class KullaniciBilgileri : Form
    {
        public KullaniciBilgileri()
        {
            InitializeComponent();
            formAc = new FormAc();

        }
        FormAc formAc;


        private void KullaniciBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void KullaniciBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void KullaniciBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAc.AktifForm = null;//null yapma sebebi FOrmAc kısmında aktif formu yani bu formu kapatmasın. //Form zaten kapanıyor.
            FormAc.Open(new KullaniciTanit());
     
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
          // FormAc.Open(new KullaniciTanit());
       
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (btnGuncelle.Text == "Güncelle")
            {
                User newUser = User.BilgileriGuncelle(this);
                User.Guncelle(newUser);
            }
            else
            {
                User newUser = User.BilgileriGuncelle(this);
                User.yeniEkle(newUser);

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand();
            sql.CommandText = "kullaniciSil";
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("@kullaniciId", txtId.Text);
            DatabaseControl.Sil(sql);
            FormAc.Open(new KullaniciTanit());
        }
    }
}
