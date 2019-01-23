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
    public partial class HastaBilgileri : Form
    {
        public HastaBilgileri()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "")
                if (btnKaydet.Text == "Kaydet")
                {
                    Hasta.EkleOrGuncelle(Hasta.HastaBilgiGuncelle(this), "Ekle");
                    btnKaydet.Text = "Güncelle";
                }
                else
                {
                    Hasta.EkleOrGuncelle(Hasta.HastaBilgiGuncelle(this), "Guncelle");
                }
            else
                MessageBox.Show("Bilgileri Giriniz");
            
           

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Text = "Kaydet";
            txtDosyaNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtAnneAd.Text = "";
            txtBabaAd.Text = "";
            txtDogumYeri.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
            txtKurumAdi.Text = "";
            txtKurumSicilNo.Text = "";
            txtYakinKurumAdi.Text = "";
            txtYakinKurumSicilNo.Text = "";
            txtYakinTel.Text = "";
            dogumTarihi.Text = "";
            txtTcNo.Text = "";


        }
    }
}
