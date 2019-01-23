using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    class Islem
    {
        string islemAdi;
        string birimFiyat;

 
        public string IslemAdi { get => islemAdi; set => islemAdi = value; }
        public string BirimFiyat { get => birimFiyat; set => birimFiyat = value; }
        public static SortedDictionary<string, string> islemFiyatList = new SortedDictionary<string, string>();


        public static ComboBox Islemler(ComboBox comboBox)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select * From islem";
            return DatabaseControl.Islemler(komut, comboBox,islemFiyatList);
        }

    }
}
