using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    class Hasta
    {
        string tcKimlikNo, dosyaNo, ad, soyad, dogumYeri, babaAd, anneAd, cinsiyet, kanGrubu, medeniHal, adres, tel, kurumSicilNo, kurumAdi, yakinTel, yakinKurumSicilNo, yakinKurumAdi;
        DateTime dogumTarihi;

        public string TcKimlikNo { get => tcKimlikNo; set => tcKimlikNo = value; }
        public string DosyaNo { get => dosyaNo; set => dosyaNo = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string DogumYeri { get => dogumYeri; set => dogumYeri = value; }
        public string BabaAdi { get => babaAd; set => babaAd = value; }
        public string AnneAdi { get => anneAd; set => anneAd = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
        public string KanGrubu { get => kanGrubu; set => kanGrubu = value; }
        public string MedeniHal { get => medeniHal; set => medeniHal = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Tel { get => tel; set => tel = value; }

        public DateTime DogumTarihi { get => dogumTarihi; set => dogumTarihi = value; }
        public string KurumAdi { get => kurumAdi; set => kurumAdi = value; }
        public string YakinTel { get => yakinTel; set => yakinTel = value; }
        public string YakinKurumSicilNo { get => yakinKurumSicilNo; set => yakinKurumSicilNo = value; }
        public string YakinKurumAdi { get => yakinKurumAdi; set => yakinKurumAdi = value; }
        public string KurumSicilNo { get => kurumSicilNo; set => kurumSicilNo = value; }

        public static void EkleOrGuncelle(Hasta hasta,string durum)
        {
            /*  string query = "insert into hasta (tcKimlikNo,dosyaNo,ad,soyad,dogumYeri,dogumTarihi,babaAdi,anneAdi,cinsiyet,kanGrubu,medeniHal,adres,tel,kurumSicilNo,kurumAdi,yakinTel,yakinKurumSicilNo,yakinKurumAdi) VALUES ('" + hasta.tcKimlikNo + "','" + hasta.dosyaNo + "','" + hasta.ad + "','" + hasta.soyad + "','" + hasta.dogumYeri + "'," + (hasta.dogumTarihi.ToString().Replace('.', '-').Split(' '))[0] + ",'" + hasta.babaAd + "','" + hasta.anneAd + "','" + hasta.cinsiyet + "','" + hasta.kanGrubu + "','" + hasta.medeniHal + "','" + hasta.adres + "','" + hasta.tel + "','" + hasta.kurumSicilNo + "','" + hasta.kurumAdi + "','" + hasta.yakinTel + "','" + hasta.yakinKurumSicilNo + "','" + hasta.yakinKurumAdi + "')";
              Console.WriteLine("\n " + query + " \n");
              DatabaseControl.Ekle(query);
             */
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            

            sqlCommand.Parameters.Add("@ad", hasta.ad);
            sqlCommand.Parameters.Add("@soyad", hasta.soyad);
            sqlCommand.Parameters.Add("@dogumYeri", hasta.dogumYeri);
            MessageBox.Show("" + hasta.dogumTarihi);
            sqlCommand.Parameters.Add("@dogumTarihi", hasta.dogumTarihi);
            sqlCommand.Parameters.Add("@anneAd", hasta.anneAd);
            sqlCommand.Parameters.Add("@babaAd", hasta.babaAd);
            sqlCommand.Parameters.Add("@cinsiyet", hasta.cinsiyet);
            sqlCommand.Parameters.Add("@kanGrubu", hasta.kanGrubu);
            sqlCommand.Parameters.Add("@medeniHal ", hasta.medeniHal);
            sqlCommand.Parameters.Add("@adres", hasta.adres);
            sqlCommand.Parameters.Add("@tel", hasta.tel);
            sqlCommand.Parameters.Add("@kurumSicilNo", hasta.kurumSicilNo);
            sqlCommand.Parameters.Add("@kurumAdi", hasta.kurumAdi);
            sqlCommand.Parameters.Add("@yakinTel", hasta.yakinTel);
            sqlCommand.Parameters.Add("@yakinKurumSicilNo", hasta.yakinKurumSicilNo);
            sqlCommand.Parameters.Add("@yakinKurumAdi", hasta.yakinKurumAdi);
            sqlCommand.Parameters.Add("@tcKimlikNo", hasta.tcKimlikNo);

            if (durum == "Ekle")
            {
                sqlCommand.CommandText = "hastaEkle";
                DatabaseControl.Ekle(sqlCommand);
            }
            else
            {
                sqlCommand.CommandText = "hastaGuncelle";//Procedure yazılmadı henuz
                sqlCommand.Parameters.Add("@dosyaNo", hasta.dosyaNo);/*düzenleee*/
                DatabaseControl.Guncelle(sqlCommand);
            }
        }



        public static Hasta HastaBilgiGuncelle(HastaBilgileri form)
        {
            Hasta hasta = new Hasta();
            hasta.tcKimlikNo = form.txtTcNo.Text;
            hasta.dosyaNo = form.txtDosyaNo.Text;
            hasta.ad = form.txtAd.Text;
            hasta.soyad = form.txtSoyad.Text;
            hasta.dogumYeri = form.txtDogumYeri.Text;
            hasta.dogumTarihi = form.dogumTarihi.Value;
            hasta.babaAd = form.txtBabaAd.Text;
            hasta.anneAd = form.txtAnneAd.Text;
            hasta.cinsiyet = form.cinsiyet.Text;
            hasta.kanGrubu = form.kanGrubu.Text;
            hasta.medeniHal = form.medeniHal.Text;
            hasta.adres = form.txtAdres.Text;
            hasta.tel = form.txtTel.Text;
            hasta.kurumSicilNo = form.txtKurumSicilNo.Text;
            hasta.kurumAdi = form.txtKurumAdi.Text;
            hasta.yakinTel = form.txtYakinTel.Text;
            hasta.yakinKurumSicilNo = form.txtYakinKurumSicilNo.Text;
            hasta.yakinKurumAdi = form.txtYakinKurumAdi.Text;
            return hasta;
        }

        public static void KullaniciBilgileriDoldur(HastaBilgileri form, Hasta hasta)
        {
            if(hasta != null){
                form.txtTcNo.Text = hasta.tcKimlikNo;
                form.txtDosyaNo.Text = hasta.dosyaNo;
                form.txtAd.Text = hasta.ad;
                form.txtSoyad.Text = hasta.soyad;
                form.txtDogumYeri.Text = hasta.dogumYeri;
                form.dogumTarihi.Value = hasta.dogumTarihi;
                form.txtBabaAd.Text = hasta.babaAd;
                form.txtAnneAd.Text = hasta.anneAd;
                form.cinsiyet.Text = hasta.cinsiyet;
                form.kanGrubu.Text = hasta.kanGrubu;
                form.medeniHal.Text = hasta.medeniHal;
                form.txtAdres.Text = hasta.adres;
                form.txtTel.Text = hasta.tel;
                form.txtKurumSicilNo.Text = hasta.kurumSicilNo;
                form.txtKurumAdi.Text = hasta.kurumAdi;
                form.txtYakinTel.Text = hasta.yakinTel;
                form.txtYakinKurumSicilNo.Text = hasta.yakinKurumSicilNo;
                form.txtYakinKurumAdi.Text = hasta.yakinKurumAdi;
            }


        }
        public static void BilgiGoster(HastaIslemleri hastaIslemleri, Hasta hasta)
        {
            //MessageBox.Show("a" + hasta.dosyaNo + "a");
            hastaIslemleri.txtDosyaNo.Text = hasta.dosyaNo;
            hastaIslemleri.txtHastaAd.Text = hasta.ad;
            hastaIslemleri.txtHastaSoyad.Text = hasta.soyad;
            hastaIslemleri.txtKurumAdı.Text = hasta.kurumAdi;
            //hastaIslemleri.txtOncekiIslemler.Text;
            //hastaIslemleri.txtSevkTarih.Text;

        }

    }
}
