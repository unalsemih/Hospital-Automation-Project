using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    class DatabaseControl
    {
      
        public static SqlConnection baglan;

        public DatabaseControl()
        {

            baglan = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\HastaneOtomasyonu.mdf'");
            
            /*
            baglan.Open();
            SqlCommand komut = new SqlCommand("ALTER PROCEDURE sevkSil @dosyaNo nvarchar(50), @saat nvarchar(10) AS BEGIN Delete from sevk where dosyaNo = @dosyaNo and saat = @saat; END", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            /*
             /*
            baglan.Open();
            SqlCommand komut = new SqlCommand("Create PROCEDURE RaporGet @baslangicTarihi nvarchar(10), @bitisTarihi nvarchar(10), @taburcuDurum nvarchar(50) AS BEGIN if @taburcuDurum = 'taburcuolmus' Select sevkTarihi, dosyaNo, poliklinik, yapilanIslem, toplamTutar, taburcu from sevk where sevkTarihi <= @bitisTarihi and sevkTarihi>= @baslangicTarihi and taburcu!= ''; if @taburcuDurum = 'taburcuolmamis' Select sevkTarihi, dosyaNo, poliklinik, yapilanIslem, toplamTutar, taburcu from sevk where sevkTarihi <= @bitisTarihi and sevkTarihi>= @baslangicTarihi and taburcu = ''; if @taburcuDurum = 'hepsi' Select sevkTarihi, dosyaNo, poliklinik, yapilanIslem, toplamTutar, taburcu from sevk where sevkTarihi <= @bitisTarihi and sevkTarihi>= @baslangicTarihi; END", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            */
            /*
         baglan.Open();
        SqlCommand komut = new SqlCommand("CREATE PROCEDURE hastaGuncelle @ad nvarchar(20),  @soyad nvarchar(20), @dogumYeri nvarchar(50), @dogumTarihi datetime, @anneAd nvarchar(20), @babaAd nvarchar(20), @cinsiyet nvarchar(5), @kanGrubu nvarchar(10), @medeniHal nvarchar(10), @adres nvarchar(255), @tel nvarchar(11), @kurumSicilNo nvarchar(10), @kurumAdi nvarchar(50), @yakinTel nvarchar(11), @yakinKurumSicilNo nvarchar(10),@yakinKurumAdi nvarchar(50), @dosyaNo int, @tcKimlikNo  nvarchar(11) AS BEGIN Update hasta set ad = @ad, soyad = @soyad, dogumYeri = @dogumYeri, dogumTarihi = @dogumTarihi, anneAdi = @anneAd, babaAdi = @babaAd, cinsiyet = @cinsiyet, kanGrubu = @kanGrubu, medeniHal = @medeniHal, adres = @adres, tel = @tel, kurumSicilNo = @kurumSicilNo, kurumAdi = @kurumAdi, yakinTel = @yakinTel, yakinKurumSicilNo = @yakinKurumSicilNo, yakinKurumAdi = @yakinKurumAdi, tcKimlikNo = @tcKimlikNo where dosyaNo = @dosyaNo end", baglan);
        komut.ExecuteNonQuery();
        baglan.Close();
        */
            /* 
        baglan.Open();
        SqlCommand komut = new SqlCommand("Create PROCEDURE taburcuDurum @dosyaNo nvarchar(50), @sevkTarihi nvarchar(10) AS BEGIN  Select taburcu From sevk where dosyaNo = @dosyaNo and sevkTarihi=@sevkTarihi; END", baglan);
        komut.ExecuteNonQuery();
        baglan.Close();
        */
            /*
           baglan.Open();
           SqlCommand komut = new SqlCommand("Create PROCEDURE HastaAdorSoyadIleBul @ad nvarchar(15), @soyad nvarchar(15) AS BEGIN Select ad as Ad,soyad as Soyad ,dosyaNo as Dosya_No,tcKimlikNo as Tc_No,dogumYeri as Dogum_Yeri from hasta where ad = @ad or soyad = @soyad; END",baglan);
           komut.ExecuteNonQuery();
           baglan.Close();
       */
        }




        public static bool kullaniciGiris(string kAdi, string sifre)
        {
            bool durum = false;
          
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select userName,sifre,yetki From kullanici", baglan);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                if (kAdi == dataReader["userName"].ToString() && sifre == dataReader["sifre"].ToString())
                {
                    //MessageBox.Show("a" + dataReader["yetki"].ToString() + "a");
                    LoginControl.yetki = dataReader["yetki"].ToString();
                    durum = true;//Kullanıcı var...
                    break;
                }
            }
            baglan.Close();
            return durum;
        }
        /* Eğer kAdi boş değilse sadece o kullanıcı döndürülecek boş ise hepsi */
        public static List<User> Kullanicilar(string kAdi)
        {

            baglan.Open();
            List<User> userList = new List<User>();
            SqlCommand komut;
                komut = new SqlCommand("kullanicilar", baglan);
            //komut = new SqlCommand("Select * From kullanici", baglan);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                //    MessageBox.Show("" + dataReader["ad"].ToString());
                User user = new User();
                user.Ad = dataReader["ad"].ToString();
                user.Soyad = dataReader["soyad"].ToString();
                user.Sifre = dataReader["sifre"].ToString();
                // MessageBox.Show("a" + dataReader["yetki"].ToString() + "a");
                user.Yetki = bool.Parse(dataReader["yetki"].ToString());
                user.Evtel = dataReader["evtel"].ToString();
                user.Ceptel = dataReader["ceptel"].ToString();
                user.Adres = dataReader["adres"].ToString();
                user.Unvan = dataReader["unvan"].ToString();
                user.IseBaslama = DateTime.Parse(dataReader["iseBaslama"].ToString());
                user.Maas = dataReader["maas"].ToString();
                user.DogumYeri = dataReader["dogumYeri"].ToString();
                user.AnneAd = dataReader["anneAd"].ToString();
                user.BabaAd = dataReader["babaAd"].ToString();
                user.Cinsiyet = dataReader["cinsiyet"].ToString();
                user.KanGrubu = dataReader["kanGrubu"].ToString();
                user.MedeniHal = dataReader["medeniHal"].ToString();
                user.DogumTarihi = DateTime.Parse(dataReader["dogumTarihi"].ToString());
                user.TcKimlikNo = dataReader["tcKimlikNo"].ToString();
                user.UserName = dataReader["userName"].ToString();
                user.Id = int.Parse(dataReader["kullaniciId"].ToString());

                userList.Add(user);

            }
            baglan.Close();
            return userList;
        }

        public static List<Poliklinik> Poliklinikler()
        {

            baglan.Open();
            List<Poliklinik> poliList = new List<Poliklinik>();
            SqlCommand komut = new SqlCommand("Select * From poliklinik", baglan);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                Poliklinik p = new Poliklinik();
                p.PoliklinikAdi = dataReader["poliklinikAdi"].ToString();
                Console.WriteLine("" + p.PoliklinikAdi);
                p.Durum = bool.Parse((dataReader["durum"].ToString()));
                p.Aciklama = dataReader["aciklama"].ToString();
                poliList.Add(new Poliklinik(p.PoliklinikAdi, p.Durum, p.Aciklama));

            }
            baglan.Close();
            return poliList;
        }

        /*
        public static void PoliGuncelle(string pAdi, Poliklinik poliklinik)//güncellenecek pAdi,yeni Pokiklinik bilgileri
        {
            baglan.Open();
            string query = "update poliklinik set poliklinikAdi='" + poliklinik.PoliklinikAdi + "', durum = '" + poliklinik.Durum.ToString() + "', aciklama='" + poliklinik.Aciklama + "' Where poliklinikAdi='" + pAdi + "'";
            SqlCommand komut = new SqlCommand(query, baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Poliklinik Güncellendi!");
        }
        */
        /*
        public static void PoliGuncelle(string pAdi, Poliklinik poliklinik)//güncellenecek pAdi,yeni Pokiklinik bilgileri
        {
            baglan.Open();
            string query = "poliklinikGuncelle";
            SqlCommand komut = new SqlCommand(query, baglan);
            komut.CommandType = CommandType.StoredProcedure;
           // komut.Parameters.Add("@newPoliklinikAdi",);
           // komut.Parameters.Add("@durum",);
           // komut.Parameters.Add("@aciklama",);
           // komut.Parameters.Add("@poliklinikAdi",);
            //komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Poliklinik Güncellendi!");
        }
    */
        /*
        public static void PoliEkle(Poliklinik poliklinik)
        {
            baglan.Open();
            string query = "INSERT INTO poliklinik (poliklinikAdi,durum,aciklama) VALUES ('" + poliklinik.PoliklinikAdi + "','" + poliklinik.Durum + "','" + poliklinik.Aciklama + "')";
            SqlCommand komut = new SqlCommand(query, baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Poliklinik Eklendi!");
        }
        */
        public static void PoliSil(string pAdi)
        {
            baglan.Open();
            string query = "DELETE FROM poliklinik WHERE poliklinikAdi='" + pAdi + "'";
            SqlCommand komut = new SqlCommand(query, baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("" + pAdi + " poliklinik silindi.");
        }

        public static void Ekle(SqlCommand komut)
        {
            baglan.Open();
            /*Console.WriteLine(query);
            SqlCommand komut = new SqlCommand(query, baglan);
            */
            komut.Connection = baglan;
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Kayıt Başarılı!");
        }


        public static void Guncelle(SqlCommand komut)
        {
            baglan.Open();
            /*Console.WriteLine(query);
            SqlCommand komut = new SqlCommand(query, baglan);
            */
            komut.Connection = baglan;
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Güncelleme Başarılı!");
        }
        public static void Sil(SqlCommand komut)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silme İşlemi Başarılı!");
        }
        public static Hasta hastaGetir(SqlCommand komut)
        {
            Hasta hasta = null;
            baglan.Open();
            komut.Connection = baglan;
            SqlDataReader dataReader = komut.ExecuteReader();

            while (dataReader.Read())
            {
                hasta = new Hasta();
                hasta.TcKimlikNo = dataReader["tcKimlikNo"].ToString();
                hasta.DosyaNo = dataReader["dosyaNo"].ToString();
                hasta.Ad = dataReader["ad"].ToString();
                hasta.Soyad = dataReader["soyad"].ToString();
                hasta.DogumYeri = dataReader["dogumYeri"].ToString();
                hasta.DogumTarihi = DateTime.Parse(dataReader["dogumTarihi"].ToString());
                hasta.BabaAdi = dataReader["babaAdi"].ToString();
                hasta.AnneAdi = dataReader["anneAdi"].ToString();
                hasta.Cinsiyet = dataReader["cinsiyet"].ToString();
                hasta.KanGrubu = dataReader["kanGrubu"].ToString();
                hasta.MedeniHal = dataReader["medeniHal"].ToString();
                hasta.Adres = dataReader["adres"].ToString();
                hasta.Tel = dataReader["tel"].ToString();
                hasta.KurumSicilNo = dataReader["kurumSicilNo"].ToString();
                hasta.KurumAdi = dataReader["kurumAdi"].ToString();
                hasta.YakinTel = dataReader["yakinTel"].ToString();
                hasta.YakinKurumSicilNo = dataReader["yakinKurumSicilNo"].ToString();
                hasta.YakinKurumAdi = dataReader["yakinKurumAdi"].ToString();
            }
            baglan.Close();
            return hasta;
        }

        public static ComboBox DoktorNumaralari(SqlCommand komut, ComboBox comboBox)
        {
            komut.Connection = baglan;
            baglan.Open();
            SqlDataReader dataReader = komut.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox.Items.Add(dataReader["kullaniciId"].ToString());
            }
            baglan.Close();
            return comboBox;
        }
        public static ComboBox Islemler(SqlCommand komut, ComboBox comboBox, SortedDictionary<string, string> liste)
        {
            komut.Connection = baglan;
            baglan.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                if (!(liste.ContainsKey(dataReader["islemAdi"].ToString())))
                    liste.Add(dataReader["islemAdi"].ToString(), dataReader["birimFiyat"].ToString());
                else
                    liste[dataReader["islemAdi"].ToString()] = dataReader["birimFiyat"].ToString();
                comboBox.Items.Add(dataReader["islemAdi"].ToString());
            }
            baglan.Close();
            return comboBox;
        }
        public static int PoliklinikSira(SqlCommand komut)
        {

            int sira = 1;
            komut.Connection = baglan;
            baglan.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                // MessageBox.Show("" + dataReader["sira"].ToString());
                sira = int.Parse(dataReader["sira"].ToString());
                sira++;
            }
            if (sira == 1)
                sira = -1;
            baglan.Close();
            return sira;
        }

        /*
        public static void SevkEkle(SqlCommand komut){
            komut.Connection = baglan;
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
         }
         */
        public static List<Sevk> sevkGetir(SqlCommand komut, HastaIslemleri hastaIslemleri)
        {
            Sevk sevk;
            List<Sevk> sevkler = new List<Sevk>();
            komut.Connection = baglan;
            baglan.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                sevk = new Sevk();
                sevk.SevkTarihi = dataReader["sevkTarihi"].ToString();
                sevkler.Add(sevk);
                hastaIslemleri.sevkDataView.Rows.Add(
                dataReader["poliklinik"].ToString(), dataReader["sira"].ToString(),
                dataReader["saat"].ToString(), dataReader["yapilanIslem"].ToString(),
                dataReader["drKod"].ToString(), dataReader["miktar"].ToString(),
                dataReader["birimFiyat"].ToString(), dataReader["sevkTarihi"].ToString());
                if (i % 2 == 0)
                    hastaIslemleri.sevkDataView.Rows[i].DefaultCellStyle.BackColor = Color.Gold;

                i++;


            }

            baglan.Close();
            return sevkler;

        }
        public static void Arama(SqlCommand komut, DosyaBul form)
        {
            
            komut.Connection = baglan;
            baglan.Open();
           SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
               form.bulunanDataGrid.DataSource = dt;
            baglan.Close();
        }
        public static bool TaburcuDurumu(string dosyaNo,string sevkTarih)
        {
            bool durum = false ;
            SqlCommand komut = new SqlCommand("taburcuDurum",baglan);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.Add("@dosyaNo", dosyaNo);
            komut.Parameters.Add("@sevkTarihi", sevkTarih);

            baglan.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            while(dataReader.Read())
            {
                if(dataReader["taburcu"].ToString()!="")
                {
                    durum = true;
                }

            }
            baglan.Close();
            return durum;
        }
    }
}


/*
           baglan.Open();

           SqlCommand komut1 = new SqlCommand("Alter PROCEDURE HastaAdIleBul @ad nvarchar(15), @soyad nvarchar(15) AS BEGIN Select ad as Ad,soyad as Soyad ,dosyaNo as Dosya_No,tcKimlikNo as Tc_No,dogumYeri as Dogum_Yeri from hasta where ad=@ad and soyad=@soyad; END",baglan);
           komut1.ExecuteNonQuery();
           SqlCommand komut2 = new SqlCommand("Alter PROCEDURE KimlikNoIleBul @tcKimlikNo nvarchar(11) AS BEGIN Select tcKimlikNo as Tc_No,dosyaNo as Dosya_No,ad as Ad,soyad as Soyad,dogumYeri as Dogum_Yeri from hasta where tcKimlikNo=@tcKimlikNo; END",baglan);
           komut2.ExecuteNonQuery();
           SqlCommand komut3 = new SqlCommand("Alter PROCEDURE KurumSicilNoIleBul @kurumSicilNo nvarchar(10) AS BEGIN Select kurumSicilNo as Sicil_No,dosyaNo as Dosya_No ,ad as Ad ,soyad as Soyad,dogumYeri as Dogum_Yeri from hasta where kurumSicilNo=@kurumSicilNo;  END",baglan);
           komut3.ExecuteNonQuery();
           SqlCommand komut4 = new SqlCommand("Alter PROCEDURE DosyaNoIleBul @dosyaNo int AS BEGIN Select dosyaNo as Dosya_No,ad as Ad,soyad as Soyad,tcKimlikNo as Tc_No,dogumYeri as Dogum_Yeri from hasta where dosyaNo=@dosyaNo; END",baglan);
           komut4.ExecuteNonQuery();

           baglan.Close();
           */
//baglan.Open();
//SqlCommand komut = new SqlCommand("delete from sevk where sira!=-1", baglan);
//komut.ExecuteNonQuery();
//baglan.Close();
/*
baglan.Open();
SqlCommand komut = new SqlCommand("Alter PROCEDURE poliklinikSira @pAdi nvarchar(50), @sevkTarihi nvarchar(10) AS BEGIN Select Count(*) as sira from sevk where poliklinik = @pAdi and taburcu = '' and sevkTarihi =@sevkTarihi; END", baglan);
komut.ExecuteNonQuery();
baglan.Close();
*/
/*   baglan.Open();
   SqlCommand komut = new SqlCommand(" CREATE PROCEDURE tarihSevkleri @dosyaNo nvarchar(50),@sevkTarihi nvarchar(10) AS BEGIN Select* from sevk where dosyaNo = @dosyaNo and sevkTarihi = @sevkTarihi; END", baglan);
   komut.ExecuteNonQuery();
   baglan.Close();
  */         /*
baglan.Open();
SqlCommand komut = new SqlCommand("CREATE PROCEDURE sevkSil @dosyaNo nvarchar(50), @sevkTarihi nvarchar(10) AS BEGIN Delete from sevk where dosyaNo = @dosyaNo and sevkTarihi = @sevkTarihi; END", baglan);
komut.ExecuteNonQuery();
baglan.Close();
/*
  /*
baglan.Open();

SqlCommand komut = new SqlCommand("CREATE PROCEDURE sevkleriGetir @dosyaNo nvarchar(50) AS BEGIN Select* From sevk where dosyaNo = @dosyaNo; END",baglan);
komut.ExecuteNonQuery();
baglan.Close();
*/
             /*
             baglan.Open();
             SqlCommand komut = new SqlCommand(
   "CREATE PROCEDURE sevkEkle @sevkTarihi nvarchar(10),@dosyaNo nvarchar(50),@poliklinik nvarchar(50),@saat nvarchar(10),@yapilanIslem nvarchar(50),@drKod char(10),@miktar char(3),@birimFiyat nvarchar(20),@sira nvarchar(3),@toplamTutar nvarchar(50), @taburcu nvarchar(50) AS BEGIN Insert into sevk(sevkTarihi, dosyaNo, poliklinik, saat, yapilanIslem, drKod, miktar, birimFiyat, sira, toplamTutar, taburcu) values(@sevkTarihi, @dosyaNo, @poliklinik, @saat, @yapilanIslem, @drKod, @miktar, @birimFiyat, @sira, @toplamTutar, @taburcu); END", baglan);
             komut.ExecuteNonQuery();
             baglan.Close();
             */

/*
baglan.Open();
SqlCommand komut= new SqlCommand("Alter PROCEDURE poliklinikSira @pAdi nvarchar(50) AS BEGIN Select Count(*) as sira from sevk where poliklinik = @pAdi and taburcu = ''; END", baglan);
komut.ExecuteNonQuery();
baglan.Close();

*/
/*
baglan.Open();
SqlCommand komut1 = new SqlCommand("Insert into islem(islemAdi, birimFiyat) values('Muayene', 52)",baglan);
SqlCommand komut2 = new SqlCommand("Insert into islem(islemAdi, birimFiyat) values('Röntgen', 27)",baglan);
SqlCommand komut3= new SqlCommand("Insert into islem(islemAdi, birimFiyat) values('EKG', 32)",baglan);
SqlCommand komut4 = new SqlCommand("Insert into islem(islemAdi, birimFiyat) values('EKO', 48)",baglan);
SqlCommand komut5 = new SqlCommand("Insert into islem(islemAdi, birimFiyat) values('Diş Çekimi', 110)",baglan);
komut1.ExecuteNonQuery();
komut2.ExecuteNonQuery();
komut3.ExecuteNonQuery();
komut4.ExecuteNonQuery();
komut5.ExecuteNonQuery();
baglan.Close();
*/
/*
baglan.Open();
SqlCommand komut = new SqlCommand("CREATE PROCEDURE hastaBilgi @dosyaNo int AS BEGIN Select *FROM hasta where dosyaNo=@dosyaNo END",baglan);
komut.ExecuteNonQuery();
baglan.Close();
*/
/*
 *baglan.Open();
SqlCommand komut = new SqlCommand("CREATE PROCEDURE hastaEkle @ad nvarchar(15), @soyad nvarchar(15),  @dogumYeri nvarchar(15), @dogumTarihi datetime, @anneAd nvarchar(15), @babaAd nvarchar(15), @cinsiyet nvarchar(5), @kanGrubu nvarchar(5),@medeniHal nvarchar(5),@adres nvarchar(255),@tel nvarchar(11),@kurumSicilNo nvarchar(10),@kurumAdi nvarchar(50),@yakinTel nvarchar(11),@yakinKurumSicilNo nvarchar(10),@yakinKurumAdi nvarchar(50),@tcKimlikNo nvarchar(11) AS BEGIN insert into hasta (ad,soyad,dogumYeri,dogumTarihi,babaAdi,anneAdi,cinsiyet,kanGrubu,medeniHal,adres,tel,kurumSicilNo,kurumAdi,yakinTel,yakinKurumSicilNo,yakinKurumAdi,tcKimlikNo) VALUES (@ad,@soyad,@dogumYeri,@dogumTarihi,@babaAd,@anneAd,@cinsiyet,@kanGrubu,@medeniHal,@adres,@tel,@kurumSicilNo,@kurumAdi,@yakinTel,@yakinKurumSicilNo,@yakinKurumAdi,@tcKimlikNo) END",baglan);
komut.ExecuteNonQuery();
baglan.Close();
*/
/*
baglan.Open();
SqlCommand komut = new SqlCommand("ALTER TABLE hasta DROP COLUMN tcKimlikNo",baglan);

SqlCommand komut2 = new SqlCommand("ALTER TABLE hasta ADD tcKimlikNo nvarchar(11)",baglan);
komut.ExecuteNonQuery();
komut2.ExecuteNonQuery();
baglan.Close();
*/
/*
baglan.Open();
SqlCommand komut = new SqlCommand("CREATE PROCEDURE kullaniciSil @kullaniciId int AS BEGIN Delete from kullanici where kullaniciId = @kullaniciId END", baglan);
komut.ExecuteNonQuery();
baglan.Close();
*/
/*
baglan.Open();
SqlCommand komut = new SqlCommand("CREATE PROCEDURE poliklinikEkle @newPoliklinikAdi nvarchar(50), @durum nvarchar(5), @aciklama nvarchar(255) AS BEGIN insert into poliklinik(poliklinikAdi, durum, aciklama) values(@newPoliklinikAdi, @durum, @aciklama) END",baglan);
komut.ExecuteNonQuery();
baglan.Close();
*/
/*         baglan.Open();
// SqlCommand komut2 = new SqlCommand("delete from poliklinik where durum != 'true' and  durum != 'false'", baglan);
// komut2.ExecuteNonQuery();
baglan.Close();
*/

//SqlCommand kullaniciEkleProceduru = new SqlCommand("CREATE PROCEDURE kullaniciEkle @kullaniciId int, @ad nvarchar(20), @soyad nvarchar(20), @sifre nvarchar(20), @yetki nvarchar(5), @evtel nvarchar(11), @ceptel nvarchar(11), @adres nvarchar(255), @unvan nvarchar(15), @iseBaslama datetime, @maas nvarchar(20), @dogumYeri nvarchar(50), @anneAd nvarchar(20), @babaAd nvarchar(20), @cinsiyet nvarchar(5), @kanGrubu nvarchar(10), @medeniHal nvarchar(10), @dogumTarihi datetime, @tcKimlikNo nvarchar(11), @userName nvarchar(50) AS BEGIN insert into kullanici(ad,soyad,unvan,maas,tcKimlikNo,dogumYeri,babaAd,anneAd,Evtel,Ceptel,yetki,cinsiyet,medeniHal,kanGrubu,adres,userName,sifre,iseBaslama,dogumTarihi) VALUES (@ad,@soyad,@unvan,@maas,@tcKimlikNo,@dogumYeri,@babaAd,@anneAd,@EvTel,@CepTel,@yetki,@cinsiyet,@medeniHal,@kanGrubu,@adres,@userName,@sifre,@iseBaslama,@dogumTarihi); END ",baglan);


/*
baglan.Open();
SqlCommand sqlCommand = new SqlCommand("CREATE PROCEDURE kullaniciGuncelle " +"@kullaniciId int," +"@ad nvarchar(20)," +"@soyad nvarchar(20)," +"@sifre nvarchar(20)," +
"@yetki nvarchar(5)," +"@evtel nvarchar(11)," +"@ceptel nvarchar(11)," +"@adres nvarchar(255), " +"@unvan nvarchar(15)," +"@iseBaslama datetime," +"@maas nvarchar(20), " +"@dogumYeri nvarchar(50)," +
"@anneAd nvarchar(20)," +"@babaAd nvarchar(20)," +"@cinsiyet nvarchar(5)," +"@kanGrubu nvarchar(10)," +"@medeniHal nvarchar(10)," +"@dogumTarihi datetime," +
"@tcKimlikNo nvarchar(11)," +"@userName nvarchar(50)" +"AS" +" BEGIN" +" update kullanici set ad = @ad, soyad = @soyad, unvan = @unvan, maas = @maas, tcKimlikNo = @tcKimlikNo, dogumYeri = @dogumYeri, babaAd = @babaAd, anneAd = @anneAd, Evtel = @evtel, Ceptel = @ceptel, yetki = @yetki, cinsiyet = @cinsiyet, medeniHal = @medeniHal, kanGrubu = @kanGrubu, adres = @adres, userName = @userName, sifre = @sifre, iseBaslama = @iseBaslama, dogumTarihi = @dogumTarihi Where kullaniciId = @kullaniciId; end",baglan);
sqlCommand.ExecuteNonQuery();
baglan.Close();
*/

/*if (durum == 0)
{
    baglan.Open();
    SqlCommand komut = new SqlCommand("CREATE PROCEDURE poliklinikGuncelle @poliklinikAdi nvarchar(50), @newPoliklinikAdi nvarchar(50), @durum nvarchar(5),@aciklama nvarchar(255) AS BEGIN update poliklinik set poliklinikAdi = @newPoliklinikAdi, durum = @durum, aciklama = @aciklama Where poliklinikAdi = @poliklinikAdi END", baglan);
    komut.ExecuteNonQuery();
    baglan.Close();
    durum++;
}
*/
/*
if (durum == 0)
{

    baglan.Open();
    SqlCommand komut2 = new SqlCommand("kullaniciGetir", baglan);
    komut2.CommandType = CommandType.StoredProcedure;
    komut2.Parameters.Add("@kAdi","dryunus");
    SqlDataReader dataReader = komut2.ExecuteReader();
    while (dataReader.Read())
    {
        MessageBox.Show("dr yunus : " + dataReader["ad"].ToString());
    }
    ///  komut.ExecuteNonQuery();

    baglan.Close();
    durum++;
}
*/
//if (durum == 0)
//{
//    baglan.Open();
//    SqlCommand komut = new SqlCommand("CREATE PROCEDURE kullanicilar AS BEGIN Select* FROM kullanici END",baglan);
//    komut.ExecuteNonQuery();
//    baglan.Close();
//    durum++;
//}

/*
if(durum==0)
{
    baglan.Open();
    SqlCommand komut = new SqlCommand("ALTER TABLE hasta DROP COLUMN dosyaNo",baglan);
    komut.ExecuteNonQuery();
    SqlCommand komut2 = new SqlCommand("ALTER TABLE hasta ADD dosyaNo  INTEGER Identity(1,1)",baglan);
    komut2.ExecuteNonQuery();
    baglan.Close();
    durum++;
}
*/
//Tabloda düzeltme yaptım...




/*
                sevk = new Sevk();
               sevk.SevkTarihi = dataReader["sevkTarihi"].ToString();
               sevk.DosyaNo = dataReader["dosyaNo"].ToString();
               sevk.Poliklinik = dataReader["poliklinik"].ToString();
               sevk.Saat = dataReader["saat"].ToString();
               sevk.YapilanIslem = dataReader["yapilanIslem"].ToString();
               sevk.DrKod = dataReader["drKod"].ToString();
               sevk.Miktar = dataReader["miktar"].ToString();
               sevk.BirimFiyat = dataReader["birimFiyat"].ToString();
               sevk.Sira = dataReader["sira"].ToString();
               sevk.ToplamTutar = dataReader["toplamTutar"].ToString();
               sevk.Taburcu = dataReader["taburcu"].ToString();
               sevkler.Add(sevk);
                 */
