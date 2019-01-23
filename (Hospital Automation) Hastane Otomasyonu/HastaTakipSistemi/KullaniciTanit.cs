using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    public partial class KullaniciTanit : Form
    {
        public KullaniciTanit()
        {
            InitializeComponent();
            User.KullanicilarComboBox(this);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciBilgileri kullaniciBilgileri = new KullaniciBilgileri();
            FormAc.AktifForm = null;
            FormAc.Open(kullaniciBilgileri);
            kullaniciBilgileri.btnGuncelle.Text = "Kaydet";
            kullaniciBilgileri.btnSil.Enabled = false;
            this.Close();//sonradan eklendi..
        }

        private void KullaniciTanit_Load(object sender, EventArgs e)
        {

        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (cmBoxKullanicilar.Text != "")
                    User.KullaniciBilgileriGoster(this, cmBoxKullanicilar.Text);
                else
                    MessageBox.Show("Bir kullanıcı seçiniz!");
            }
        }
    }
}
