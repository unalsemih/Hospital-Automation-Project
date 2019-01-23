using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    public partial class HastaIslemleri : Form
    {
        public HastaIslemleri()
        {
            InitializeComponent();
            sevkDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        Hasta hasta;
        string sevkTarihi;
        //   int tutar = 0;

        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            if (true == sayiKontrol(txtDosyaNo.Text) && txtDosyaNo.Text != "")
            {
                sevkDataView.Rows.Clear();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "hastaBilgi";
                sqlCommand.Parameters.Add("@dosyaNo", int.Parse(txtDosyaNo.Text));

                hasta = DatabaseControl.hastaGetir(sqlCommand);
                cmBoxOncekiIslemler.Items.Clear();
                Sevk.oncekiIslemler(txtDosyaNo.Text, this, cmBoxOncekiIslemler);
                /* Sonradan eklenen kod */
                //
                sevkDataView.Rows.Clear();
                //

                toplamTutarHesap();
                // Sevk.SevkleriGetir(txtDosyaNo.Text, this);
                if (hasta != null)
                    Hasta.BilgiGoster(this, hasta);
                else
                    MessageBox.Show("Bu dosya numarası yok");
            }
            else
            {
                if (txtDosyaNo.Text == "")
                {
                    DosyaBul dosyaBul = new DosyaBul();
                    dosyaBul.Show();
                }
                else
                    MessageBox.Show("Bir dosya numarası giriniz..");
            }

            //DosyaBul dosyaBul = new DosyaBul();

            //dosyaBul.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            HastaBilgileri hastaBilgileri = new HastaBilgileri();
            hastaBilgileri.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hasta != null)
            {
                if (true == sayiKontrol(txtDosyaNo.Text) && txtDosyaNo.Text != "")
                {
                    HastaBilgileri hastaBilgileri = new HastaBilgileri();
                    hastaBilgileri.Show();
                    Hasta.KullaniciBilgileriDoldur(hastaBilgileri, hasta);
                    hastaBilgileri.btnKaydet.Text = "Güncelle";
                }
                else
                    MessageBox.Show("Bir dosya numarası giriniz..");
            }
        }


        bool sayiKontrol(string deger)
        {//sayi ise true;;
            bool sonuc = true;
            for (int i = 0; i < deger.Length; i++)
                if (!(char.IsDigit(deger[i])))
                    sonuc = false;

            return sonuc;

        }


        private void HastaIslemleri_Load(object sender, EventArgs e)
        {
            Poliklinik.comboBoxPoliklinik(comboBoxPoliklinik);
            Doktor.Doktorlar(cmBoxDoktorlar);
            Islem.Islemler(cmBoxIslem);

        }
        int toplamFiyat;
        private void cmBoxIslem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmBoxIslem.Text != "")
                fiyat.Value = int.Parse(Islem.islemFiyatList[cmBoxIslem.Text].ToString());
            if (hasta != null && cmBoxIslem.Text != "")
                toplamFiyat = (int.Parse(Islem.islemFiyatList[cmBoxIslem.Text]) * Convert.ToInt32(numMiktar.Value));
        }

        private void comboBoxPoliklinik_SelectedValueChanged(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand();
            komut.CommandText = "poliklinikSira";
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.Add("@pAdi", comboBoxPoliklinik.Text);
            komut.Parameters.Add("@sevkTarihi", txtSevkTarih.Text);
            int sira = DatabaseControl.PoliklinikSira(komut);
            if (sira == -1 || sira == 0)
                sira = 1;
            txtSira.Text = sira.ToString();
        }
        string sevkT;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (hasta != null)
                if (comboBoxPoliklinik.Text == "" || cmBoxIslem.Text == "" || cmBoxDoktorlar.Text == "")
                {
                    MessageBox.Show("Eksik Bilgileri Doldurunuz!");
                }
                else
                {
                    if (DateTime.Parse(txtSevkTarih.Text) < DateTime.Now.Date)
                        MessageBox.Show("Önceki Tarihe sevk alamzsınız..");
                    else
                    {
                        sevkT = txtSevkTarih.Value.ToString().Split(' ')[0];
                        //sevk ekleme işlemi yapılıyor...
                        SqlCommand komut = new SqlCommand();
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.CommandText = "sevkEkle";
                        komut.Parameters.Add("@sevkTarihi", txtSevkTarih.Text);
                        komut.Parameters.Add("@dosyaNo", hasta.DosyaNo);
                        komut.Parameters.Add("@poliklinik", comboBoxPoliklinik.Text);
                        komut.Parameters.Add("@saat", DateTime.Now.ToLongTimeString());//DateTime.Now.Hour+":"+DateTime.Now.Minute);
                        komut.Parameters.Add("@yapilanIslem", cmBoxIslem.Text);
                        komut.Parameters.Add("@drKod", cmBoxDoktorlar.Text);
                        komut.Parameters.Add("@miktar", numMiktar.Value.ToString());
                        komut.Parameters.Add("@birimFiyat", fiyat.Value.ToString());
                        komut.Parameters.Add("@sira", txtSira.Text);
                        komut.Parameters.Add("@toplamTutar", toplamFiyat.ToString());
                        komut.Parameters.Add("@taburcu", "");
                        DatabaseControl.Ekle(komut);//sevk almak için komut oluşturdum

                        sevkGirisTemizle();
                        cmBoxOncekiIslemler.Items.Clear();
                        sevkDataView.Rows.Clear();

                        if (cmBoxOncekiIslemler.Text == "")
                            Sevk.SevkleriGetir(hasta.DosyaNo, this);//sevkleri gride aktardım.
                        else
                            Sevk.oncekiIslemler(txtDosyaNo.Text, this, cmBoxOncekiIslemler);
                        txtDosyaNo.Text = hasta.DosyaNo;
                        btnBul.PerformClick();

                        cmBoxOncekiIslemler.Text = sevkT.ToString();
                        btnGit.PerformClick();
                    }
                }
            else
                MessageBox.Show("Lütfen bir hasta seçiniz.");


        }

        void sevkGirisTemizle()
        {
            comboBoxPoliklinik.SelectedItem = null;
            txtSira.Text = "";
            cmBoxIslem.SelectedItem = null;
            cmBoxDoktorlar.SelectedItem = null;
            numMiktar.Value = 1;
            fiyat.Value = 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (hasta != null)
            {
             //   MessageBox.Show("DOSYANO :" + hasta.DosyaNo + " sevk Tarihi :" + sevkTarihi);
                bool degisim = false;
                SqlCommand komut = new SqlCommand();
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.Add("@dosyaNo", hasta.DosyaNo);

                komut.CommandText = "sevkSil";
                foreach (DataGridViewRow row in sevkDataView.Rows)
                {
                    if (row.Selected == true)
                    {
                        if ((komut.Parameters.Contains("@saat")))
                            komut.Parameters["@saat"].Value = row.Cells[2].Value.ToString();
                        else
                            komut.Parameters.Add("@saat", row.Cells[2].Value.ToString());

                        DatabaseControl.Sil(komut);
                        degisim = true;
                    }
                }
                if (degisim)
                {
                    sevkGirisTemizle();
                    sevkDataView.Rows.Clear();
                    //Sevk.SevkleriGetir(hasta.DosyaNo, this);
                    //txtDosyaNo.Text = hasta.DosyaNo;
                    //btnBul.PerformClick();
                    txtDosyaNo.Text = hasta.DosyaNo;
                    btnBul.PerformClick();

                    cmBoxOncekiIslemler.Text = sevkT.ToString();
                    btnGit.PerformClick();
                    // cmBoxOncekiIslemler.Items.Clear();
                    // Sevk.oncekiIslemler(txtDosyaNo.Text, this, cmBoxOncekiIslemler);
                }
            }
            else
                MessageBox.Show("Seçim yapınız..");
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            sevkT = cmBoxOncekiIslemler.Text.ToString().Split(' ')[0];
            sevkDataView.Rows.Clear();
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "tarihSevkleri";
           
            komut.Parameters.Add("@dosyaNo", hasta.DosyaNo.ToString());
            komut.Parameters.Add("@sevkTarihi", cmBoxOncekiIslemler.Text);
            DatabaseControl.sevkGetir(komut, this);
            sevkTarihi = cmBoxOncekiIslemler.Text;

            toplamTutarHesap();

        }

        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            if (sevkDataView.SelectedRows.Count != 0)
            {
                if (!(DatabaseControl.TaburcuDurumu(hasta.DosyaNo, sevkDataView.SelectedRows[0].Cells[7].Value.ToString())))
                {
                    Taburcu taburcu = new Taburcu();
                    taburcu.Show();
                    taburcu.txtDosyaNo.Text = hasta.DosyaNo;
                    taburcu.cmBoxSevk.Text = sevkDataView.SelectedRows[0].Cells[7].Value.ToString();
                    taburcu.cmBoxCikis.Text = DateTime.Now.Date.ToString();
                    taburcu.txtTutar.Text = toplamTutarHesap().ToString();
                }
                else
                    MessageBox.Show("Hasta bu sevkten taburcu edilmiş...");
            }
        }
        public int toplamTutarHesap()
        {
            toplamFiyat = 0;
            //MessageBox.Show(sevkDataView.Rows.Count.ToString());
            for (int i = 0; i < sevkDataView.Rows.Count - 1; i++)
            {
                toplamFiyat += int.Parse(sevkDataView.Rows[i].Cells[5].Value.ToString()) * int.Parse(sevkDataView.Rows[i].Cells[6].Value.ToString());
            }
            lbltoplamTutar.Text = "Toplam Tutar : " + toplamFiyat.ToString();
            return toplamFiyat;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaskiOnizleme_Click(object sender, EventArgs e)
        {
            if (hasta != null)
            {


                PrintPreviewDialog onizleme = new PrintPreviewDialog();
                onizleme.Document = pdYazici;
                onizleme.ShowDialog();
            }
            else
                MessageBox.Show("Hasta seçimi yapınız..");
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (hasta != null)
            {

                PrintDialog yazdir = new PrintDialog();
                yazdir.Document = pdYazici;
                yazdir.UseEXDialog = true;
                if (yazdir.ShowDialog() == DialogResult.OK)
                {
                    pdYazici.Print();
                }
            }
            else
                MessageBox.Show("Hasta seçimi yapınız..");
            }


        Font baslik = new Font("Verdana", 13, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush brush = new SolidBrush(Color.Black);
        private void pdYazici_PrintPage(object sender, PrintPageEventArgs e)
        {
            int j = 800;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Rapor Tarih : " + DateTime.Now.Date.ToLongDateString(), govde, brush, 70, 20);
            e.Graphics.DrawString(hasta.Ad + " " + hasta.Soyad + " -- Tahlil ve İşlem Sonuçları", baslik, brush, 200, 80);
            e.Graphics.DrawString("Poliklinik       Sıra No     Saat          İşlem     Dr.Kodu     Miktar     Birim", govde, brush, 70, 170);
            e.Graphics.DrawString("---------------------------------------------------------------------------------", govde, brush, 70, 190);
            for (int i = 0; i < sevkDataView.Rows.Count ; i++)
            {
                e.Graphics.DrawString(sevkDataView.Rows[i].Cells[0].Value + "       " +
                    sevkDataView.Rows[i].Cells[1].Value + "        " + sevkDataView.Rows[i].Cells[2].Value + "     " +
                     sevkDataView.Rows[i].Cells[3].Value + "      " + sevkDataView.Rows[i].Cells[4].Value + "     " +
                      sevkDataView.Rows[i].Cells[5].Value + "        " + sevkDataView.Rows[i].Cells[6].Value + "         ",govde,brush,70,210+(i*30));
                j = i;
            }
            e.Graphics.DrawString("  **Toplam Tutar : "+toplamTutarHesap()+" TL", govde, brush, 100, 210+(j*30)+50);
        }
    }

}
