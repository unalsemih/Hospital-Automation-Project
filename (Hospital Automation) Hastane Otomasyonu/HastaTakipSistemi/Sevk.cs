using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    class Sevk
    {
        string sevkTarihi, dosyaNo, poliklinik, saat, yapilanIslem, drKod, miktar, birimFiyat, sira, toplamTutar, taburcu;

        public string SevkTarihi { get => sevkTarihi; set => sevkTarihi = value; }
        public string DosyaNo { get => dosyaNo; set => dosyaNo = value; }
        public string Poliklinik { get => poliklinik; set => poliklinik = value; }
        public string Saat { get => saat; set => saat = value; }
        public string YapilanIslem { get => yapilanIslem; set => yapilanIslem = value; }
        public string DrKod { get => drKod; set => drKod = value; }
        public string Miktar { get => miktar; set => miktar = value; }
        public string BirimFiyat { get => birimFiyat; set => birimFiyat = value; }
        public string Sira { get => sira; set => sira = value; }
        public string ToplamTutar { get => toplamTutar; set => toplamTutar = value; }
        public string Taburcu { get => taburcu; set => taburcu = value; }

        public static List<Sevk> sevkler;
        public static void SevkleriGetir(string dosyaNo,HastaIslemleri hastaIslemleri)
        {//Dosya no ya gore butun sevkleri getirir.
            SqlCommand komut = new SqlCommand();
            komut.CommandType = System.Data.CommandType.StoredProcedure;
            komut.CommandText = "sevkleriGetir";
            komut.Parameters.Add("@dosyaNo",dosyaNo);


            sevkler = DatabaseControl.sevkGetir(komut,hastaIslemleri);


        }

        public static ComboBox oncekiIslemler(string dosyaNo, HastaIslemleri hastaIslemleri,ComboBox comboBox)
        {
            SevkleriGetir(dosyaNo,hastaIslemleri);
            // MessageBox.Show(sevkler[0].sevkTarihi);
            for (int i = 0; i < sevkler.Count; i++)
            {
                if(!(comboBox.Items.Contains(sevkler[i].sevkTarihi)))
                    comboBox.Items.Add(sevkler[i].sevkTarihi);
            }
                return comboBox;
        }

    }
}
