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
    public partial class Login : Form
    {
        public AnaForm anaForm;

        public Login(AnaForm anaForm)
        {
            InitializeComponent();
            //    this.anaForm = anaForm;
            database = new DatabaseControl();
        }
        DatabaseControl database;
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            LoginControl.GirisKontrol(txtKullaniciAdi.Text, txtSifre.Text);
        }

       

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }
    }
}
