using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    class Poliklinik
    {
        string poliklinikAdi;
        bool durum;
        string aciklama;
        public Poliklinik() { }
        public Poliklinik(string poliklinikAdi, bool durum, string aciklama)
        {
            this.poliklinikAdi = poliklinikAdi;
            this.durum = durum;
            this.aciklama = aciklama;
        }

        public string PoliklinikAdi { get => poliklinikAdi; set => poliklinikAdi = value; }
        public bool Durum { get => durum; set => durum = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }

        public static void comboBoxPoliklinik(ComboBox combobox)
        {
            List<Poliklinik> liste = DatabaseControl.Poliklinikler();
            for (int i = 0; i < liste.Count; i++)
            {
                combobox.Items.Add(liste[i].poliklinikAdi);
            }
        }
        public static Poliklinik poliklinikVarMi(string poliName)
        {//aranan poliklinik varsa bilgileri döndürülür yoksa null;;
            Poliklinik poliklinik = null;

            foreach (Poliklinik p in DatabaseControl.Poliklinikler())
            {
                if (p.PoliklinikAdi == poliName)
                {
                    poliklinik = new Poliklinik();
                    poliklinik.poliklinikAdi = p.poliklinikAdi;
                    poliklinik.durum = p.durum;
                    poliklinik.aciklama = p.aciklama;
                }
            }
            return poliklinik;
        }


        public static void PoliklinikCreateShow(Form form, string pAdi)
        {
            FormAc.AktifForm = null;//formu direk kapatmaması için..
            FormAc.Open(new PoliTanit());
            ((PoliTanit)(FormAc.AktifForm)).txtPoliklinik.Text = pAdi;
            ((PoliTanit)(FormAc.AktifForm)).btnOk.Text = "Kaydet";

            FormAc.Close((PoliklinikForm)form);
        }
        public static void PoliklinikShow(Form form, string pAdi, bool pDurum, string pAciklama)
        {
            FormAc.AktifForm = null;//formu direk kapatmaması için..
            FormAc.Open(new PoliTanit());
            ((PoliTanit)(FormAc.AktifForm)).txtPoliklinik.Text = pAdi;
            ((PoliTanit)(FormAc.AktifForm)).checkDurum.Checked = pDurum;
            ((PoliTanit)(FormAc.AktifForm)).textAciklama.Text = pAciklama;
            ((PoliTanit)(FormAc.AktifForm)).pAd = pAdi;

            FormAc.Close((PoliklinikForm)form);
        }


    }
}
