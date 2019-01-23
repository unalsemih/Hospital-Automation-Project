using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    class LoginControl
    {
        public static string yetki;
        public static void GirisKontrol(string kAdi, string sifre)
        {
            if (DatabaseControl.kullaniciGiris(kAdi, sifre))
            {
                FormAc.AnaForm.menuStrip.Enabled = true;
                if (yetki.ToUpper() == "TRUE")
                    FormAc.AnaForm.referanslarToolStripMenuItem.Enabled = true;
                FormAc.AktifForm.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre Yanlış");
            }

        }


    }
}
