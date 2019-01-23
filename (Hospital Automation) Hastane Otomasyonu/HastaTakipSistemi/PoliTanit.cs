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
    public partial class PoliTanit : Form
    {
        public PoliTanit()
        {
            InitializeComponent();
            
        }
        public string pAd;
        private void btnOk_Click(object sender, EventArgs e)
        {
            Poliklinik poliklinik = new Poliklinik(txtPoliklinik.Text, checkDurum.Checked, textAciklama.Text);
            if (btnOk.Text=="Güncelle")
            {
                /*
                string query = "update poliklinik set poliklinikAdi='" + poliklinik.PoliklinikAdi + "', durum = '" + poliklinik.Durum.ToString() + "', aciklama='" + poliklinik.Aciklama + "' Where poliklinikAdi='" + pAd.ToString() + "'";
           //     DatabaseControl.PoliGuncelle(pAd.ToString(), poliklinik);
                DatabaseControl.Guncelle(query);
                */
                
                 
                SqlCommand komut = new SqlCommand();
                komut.CommandType = CommandType.StoredProcedure;
                komut.CommandText = "poliklinikGuncelle";
                komut.Parameters.Add("@newPoliklinikAdi",poliklinik.PoliklinikAdi);
                komut.Parameters.Add("@durum",poliklinik.Durum.ToString());
                komut.Parameters.Add("@aciklama",poliklinik.Aciklama);
                komut.Parameters.Add("@poliklinikAdi",pAd);
                DatabaseControl.Guncelle(komut);
                
                

            }
            else
            {
       


                SqlCommand komut = new SqlCommand();
                komut.CommandType = CommandType.StoredProcedure;
                komut.CommandText = "poliklinikEkle";
                komut.Parameters.Add("@newPoliklinikAdi", poliklinik.PoliklinikAdi);
                komut.Parameters.Add("@durum", poliklinik.Durum.ToString());
                komut.Parameters.Add("@aciklama", poliklinik.Aciklama);
          //      komut.Parameters.Add("@poliklinikAdi", pAd);
                DatabaseControl.Ekle(komut);
                pAd = poliklinik.PoliklinikAdi;
                btnOk.Text = "Güncelle";
            }
        }

        private void PoliTanit_Load(object sender, EventArgs e)
        {
            pAd = txtPoliklinik.Text;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FormAc.Open(new PoliklinikForm());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DatabaseControl.PoliSil(pAd);
            FormAc.Open(new PoliklinikForm());//Silindikten sonra forma döner.
        }
    }
}
