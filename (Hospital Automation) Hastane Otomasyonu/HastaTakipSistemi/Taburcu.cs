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
    public partial class Taburcu : Form
    {
        public Taburcu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Taburcu_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


            //if (!(DatabaseControl.TaburcuDurumu(txtDosyaNo.Text, cmBoxSevk.Text)))
           // {
                SqlCommand komut = new SqlCommand();
                komut.CommandType = CommandType.StoredProcedure;
                komut.CommandText = "taburcu";
                komut.Parameters.Add("@dosyaNo", txtDosyaNo.Text);
                komut.Parameters.Add("@sevkTarihi", cmBoxSevk.Text);
                MessageBox.Show("a" + cmBoxCikis.Text + "a");
                komut.Parameters.Add("@cikisTarihi", DateTime.Now.Date);
                komut.Parameters.Add("@odeme", cmBoxOdeme.Text);
                komut.Parameters.Add("@toplamTutar", txtTutar.Text);
                DatabaseControl.Ekle(komut);
            this.Close();
           // }
           // else
           //     MessageBox.Show("Hasta bu sevkten taburcu edilmiş...");
        }
    }
}
