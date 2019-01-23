using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    class User
    {
        string ad, soyad, sifre, evtel, ceptel, adres, unvan, maas, dogumYeri, userName;
        string anneAd, babaAd, cinsiyet, kanGrubu, medeniHal, tcKimlikNo;
        DateTime iseBaslama, dogumTarihi;
        bool yetki;
        int id;
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Evtel { get => evtel; set => evtel = value; }
        public string Ceptel { get => ceptel; set => ceptel = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Unvan { get => unvan; set => unvan = value; }
        public string Maas { get => maas; set => maas = value; }
        public string DogumYeri { get => dogumYeri; set => dogumYeri = value; }
        public string UserName { get => userName; set => userName = value; }
        public string AnneAd { get => anneAd; set => anneAd = value; }
        public string BabaAd { get => babaAd; set => babaAd = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
        public string KanGrubu { get => kanGrubu; set => kanGrubu = value; }
        public string MedeniHal { get => medeniHal; set => medeniHal = value; }
        public DateTime DogumTarihi { get => dogumTarihi; set => dogumTarihi = value; }
        public string TcKimlikNo { get => tcKimlikNo; set => tcKimlikNo = value; }
        public DateTime IseBaslama { get => iseBaslama; set => iseBaslama = value; }
        public bool Yetki { get => yetki; set => yetki = value; }
        public int Id { get => id; set => id = value; }

        static List<User> users;
        public static void KullanicilarComboBox(KullaniciTanit kTanit)
        {

            users = new List<User>();
            users = DatabaseControl.Kullanicilar("");//"" anlamı bütün kullanıcılar için sorgu isteniyor.
            for (int i = 0; i < users.Count; i++)
                kTanit.cmBoxKullanicilar.Items.Add(users[i].userName);

        }

        public static User acikUser;
        public static void KullaniciBilgileriGoster(Form form, string kAdi)
        {

            FormAc.AktifForm = null;//formu direk kapatmaması için..
            FormAc.Open(new KullaniciBilgileri());
            foreach (User user in users)
                if (user.userName == kAdi)
                {
                    acikUser = user;
                    KullaniciBilgileriDoldur(((KullaniciBilgileri)(FormAc.AktifForm)),user);

                }
            FormAc.Close((KullaniciTanit)form);
        }

        public static void KullaniciBilgileriDoldur(KullaniciBilgileri form,User user)
        {
            form.txtAd.Text = user.ad;
            form.txtSoyad.Text = user.soyad;
            form.cmBoxUnvan.Text = user.unvan;
            form.txtMaas.Text = user.maas;
            form.txtId.Text = user.Id.ToString();
            form.txtSoyad.Text = user.soyad;
            form.txtTcNo.Text = user.tcKimlikNo;
            form.txtDogumYeri.Text = user.dogumYeri;
            form.txtBabaAdı.Text = user.babaAd;
            form.txtAnneAdı.Text = user.anneAd;
            form.txtTel.Text = user.Evtel;
            form.txtGSM.Text = user.Ceptel;
            form.txtMaas.Text = user.maas;
            form.checkYetki.Checked = user.yetki;
            form.cinsiyet.Text = user.cinsiyet;
            form.medeniHali.Text = user.medeniHal;
            form.KanGrubu.Text = user.kanGrubu;
            form.txtAdres.Text = user.adres;
            form.txtUserName.Text = user.userName;
            form.txtSifre.Text = user.sifre;
            form.dateDogum.Value = user.dogumTarihi;
            form.dateIseBaslama.Value = user.iseBaslama;

        }

        public static User BilgileriGuncelle(KullaniciBilgileri form)
        {
            User user = new User();
            if(form.txtId.Text!="")
            user.Id =int.Parse(form.txtId.Text);
            user.ad = form.txtAd.Text;
            user.soyad = form.txtSoyad.Text;
            user.unvan = form.cmBoxUnvan.Text;
            user.maas = form.txtMaas.Text;
            user.tcKimlikNo =  form.txtTcNo.Text;
            user.dogumYeri = form.txtDogumYeri.Text;
            user.babaAd =form.txtBabaAdı.Text;
            user.anneAd = form.txtAnneAdı.Text;
            user.Evtel = form.txtTel.Text;
            user.Ceptel = form.txtGSM.Text;
            user.yetki = form.checkYetki.Checked;
            user.cinsiyet = form.cinsiyet.Text;
            user.medeniHal = form.medeniHali.Text;
            user.kanGrubu = form.KanGrubu.Text;
            user.adres = form.txtAdres.Text;
            user.userName = form.txtUserName.Text;
            user.sifre = form.txtSifre.Text;
            user.iseBaslama = form.dateIseBaslama.Value;
            user.dogumTarihi = form.dateDogum.Value;
            return user;
        }

        public static void yeniEkle(User user)
        {
         /*   
            string query = "insert into kullanici  (ad,soyad,unvan,maas,tcKimlikNo,dogumYeri,babaAd,anneAd,Evtel,Ceptel,yetki,cinsiyet,medeniHal,kanGrubu,adres,userName,sifre," +
                "iseBaslama,dogumTarihi) VALUES ('"+ user.ad + "','"+ user.soyad + "','"+ user.unvan + "','"+ user.maas +
                "','"+user.tcKimlikNo+"','"+user.dogumYeri+"','"+ user.babaAd + "','"+ user.anneAd + "','"+ user.evtel + "','"+ user.ceptel + "','"+ user.yetki + "','" + user.Cinsiyet + "','" + user.medeniHal + "','" + user.kanGrubu + "','" + user.adres + "','" + user.userName + "','" + user.sifre + "'," + (user.iseBaslama.ToString().Replace('.', '-').Split(' '))[0] + "," + (user.dogumTarihi.ToString().Replace('.','-').Split(' '))[0] + ")";
                DatabaseControl.Ekle(query);
                */
            
   
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "kullaniciEkle";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@kullaniciId", user.id);
            sqlCommand.Parameters.Add("@ad", user.ad);
            sqlCommand.Parameters.Add("@soyad", user.soyad);
            sqlCommand.Parameters.Add("@sifre", user.sifre);
            sqlCommand.Parameters.Add("@yetki", user.yetki.ToString());
            sqlCommand.Parameters.Add("@evtel", user.evtel);
            sqlCommand.Parameters.Add("@ceptel", user.ceptel);
            sqlCommand.Parameters.Add("@adres", user.adres);
            sqlCommand.Parameters.Add("@unvan", user.unvan);
            sqlCommand.Parameters.Add("@iseBaslama", user.iseBaslama);
            sqlCommand.Parameters.Add("@maas", user.maas);
            sqlCommand.Parameters.Add("@dogumYeri", user.dogumYeri);
            sqlCommand.Parameters.Add("@anneAd", user.anneAd);
            sqlCommand.Parameters.Add("@babaAd", user.babaAd);
            sqlCommand.Parameters.Add("@cinsiyet", user.cinsiyet);
            sqlCommand.Parameters.Add("@kanGrubu", user.kanGrubu);
            sqlCommand.Parameters.Add("@medeniHal ", user.medeniHal);
            sqlCommand.Parameters.Add("@dogumTarihi", user.dogumTarihi);
            MessageBox.Show("" + user.dogumTarihi);
            sqlCommand.Parameters.Add("@tcKimlikNo", user.tcKimlikNo);
            sqlCommand.Parameters.Add("@userName", user.userName);
            DatabaseControl.Ekle(sqlCommand);
            ((KullaniciBilgileri)(FormAc.AktifForm)).btnGuncelle.Text = "Güncelle";
            
        }

        public static void Guncelle(User user)
        {
         
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText =  "kullaniciGuncelle";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@kullaniciId", user.id);
            sqlCommand.Parameters.Add("@ad", user.ad);
            sqlCommand.Parameters.Add("@soyad", user.soyad);
            sqlCommand.Parameters.Add("@sifre", user.sifre);
            sqlCommand.Parameters.Add("@yetki",user.yetki.ToString());
            sqlCommand.Parameters.Add("@evtel", user.evtel);
            sqlCommand.Parameters.Add("@ceptel", user.ceptel);
            sqlCommand.Parameters.Add("@adres", user.adres);
            sqlCommand.Parameters.Add("@unvan", user.unvan);
            sqlCommand.Parameters.Add("@iseBaslama", user.iseBaslama);
            sqlCommand.Parameters.Add("@maas", user.maas);
            sqlCommand.Parameters.Add("@dogumYeri", user.dogumYeri);
            sqlCommand.Parameters.Add("@anneAd", user.anneAd);
            sqlCommand.Parameters.Add("@babaAd", user.babaAd);
            sqlCommand.Parameters.Add("@cinsiyet", user.cinsiyet);
            sqlCommand.Parameters.Add("@kanGrubu", user.kanGrubu);
            sqlCommand.Parameters.Add("@medeniHal ", user.medeniHal);
          //  MessageBox.Show("" + user.dogumTarihi);
            sqlCommand.Parameters.Add("@dogumTarihi", user.dogumTarihi);
            sqlCommand.Parameters.Add("@tcKimlikNo", user.tcKimlikNo);
            sqlCommand.Parameters.Add("@userName", user.userName);
            DatabaseControl.Guncelle(sqlCommand);

        }

    }
}
