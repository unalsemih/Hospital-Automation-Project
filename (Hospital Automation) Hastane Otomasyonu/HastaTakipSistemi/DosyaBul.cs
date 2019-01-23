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
    public partial class DosyaBul : Form
    {
        public DosyaBul()
        {
            InitializeComponent();
        }

        private void cmBoxAramaKriter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmBoxAramaKriter.Text == "Hasta Adı Soyadı")
            {
                pnlAramaAdSoyad.Visible = true;
                pnl2Arama.Visible = false;
            }
            else
            {
                pnlAramaAdSoyad.Visible = false;
                pnl2Arama.Visible =true;

            }


        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            if (cmBoxAramaKriter.Text == "Hasta Adı Soyadı")
            {
                if(checkAnd.Checked==true)
                komut.CommandText = "HastaAdIleBul";
                else
                komut.CommandText = "HastaAdorSoyadIleBul";
                komut.Parameters.Add("@ad",txtAd.Text);
                komut.Parameters.Add("@soyad",txtSoyad.Text);
            }
            else if (cmBoxAramaKriter.Text == "Kimlik No")
            {
                komut.CommandText = "KimlikNoIleBul";
                komut.Parameters.Add("@tcKimlikNo", txtAramaMetni.Text);
            }
            else if (cmBoxAramaKriter.Text == "Kurum Sicil No")
            {
                komut.CommandText = "KurumSicilNoIleBul";
                komut.Parameters.Add("@kurumSicilNo", txtAramaMetni.Text);
            }
            else
            {
                komut.CommandText = "DosyaNoIleBul";
                komut.Parameters.Add("@dosyaNo", txtAramaMetni.Text);
            }
            DatabaseControl.Arama(komut,this);

        }
    }
}
