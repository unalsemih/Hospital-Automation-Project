using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    public partial class PoliklinikForm : Form
    {
        public PoliklinikForm()
        {
            InitializeComponent();
            formAc = new FormAc();
            //poliklinikler = DatabaseControl.Poliklinikler();
            Poliklinik.comboBoxPoliklinik(poliklinikAdlari);
        }
        FormAc formAc;
        //List<Poliklinikler> poliklinikler;
        private void enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (poliklinikAdlari.Text == "")
                    MessageBox.Show("Lütfen bir poliklinik seçiniz...");
                else
                { Poliklinik p;
                    if ((p=(Poliklinik.poliklinikVarMi(poliklinikAdlari.Text)))==null)
                    {
                        //poliklinik yok. Oluşturma formu açılacak
                        DialogResult result = MessageBox.Show("Böyle bir poliklinik yok! Oluşturmak ister misiniz?", "Dikkat", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No) { }
                        else
                        {
                            Poliklinik.PoliklinikCreateShow(this, poliklinikAdlari.Text);
                            this.Close();
                        }

                    }
                    else
                    {
                        //Poliklinik varsa ... Güncelleme sayası açılacak...
                        Poliklinik.PoliklinikShow(
                            this,p.PoliklinikAdi,p.Durum,p.Aciklama);
                        this.Close();
                    }
                        
                }
            }
        }

        private void PoliklinikForm_Load(object sender, EventArgs e)
        {

        }
    }
}
