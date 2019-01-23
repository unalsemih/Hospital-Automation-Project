using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    class Doktor:User
    {
        

        public static ComboBox Doktorlar(ComboBox comboBox)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select kullaniciId From kullanici where unvan = 'Doktor'";
            return DatabaseControl.DoktorNumaralari(komut, comboBox);
        }

    }
}
