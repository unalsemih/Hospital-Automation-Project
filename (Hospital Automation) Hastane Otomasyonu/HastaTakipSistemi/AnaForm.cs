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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            formAc = new FormAc(this);

        }
        FormAc formAc;
      

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc.Open(new Raporlar());
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // loginGoster();
            FormAc.Open(new Login(this));
        }

        private void poliklinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAc.Open(new PoliklinikForm());

        }

        private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc.Open(new HastaIslemleri());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc.AnaForm.menuStrip.Enabled = false;
            FormAc.AnaForm.referanslarToolStripMenuItem.Enabled = false;
            FormAc.Open(new Login(this));
            //referans kısmını kilitler. Logout...
        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc.Open(new KullaniciTanit());
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
