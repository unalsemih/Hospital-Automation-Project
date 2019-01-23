using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    class FormAc
    {
        private AnaForm anaForm;
        private static Form aktifForm;

        public static AnaForm AnaForm;
        public static Form AktifForm { get => aktifForm; set => aktifForm = value; }
        public FormAc() { }
        public FormAc(AnaForm anaForm)
        {
            this.anaForm = anaForm;
            AnaForm = anaForm;
        }
        public static void Open(Form form)
        {
            if (AktifForm != null)
                AktifForm.Close();
            AktifForm = form;
            AktifForm.MdiParent = AnaForm;
        
            AktifForm.Show();
            newLocationLogin(form);
        }
        public static void Close(Form form)
        {
                form.Close();
        }
        static void newLocationLogin(Form form)
        {
            if (form.Name == "Login")
                ((Login)form).Location = new Point(302, 160);
            else if (form.Name == "HastaIslemleri")
                ((HastaIslemleri)form).Location = new Point(53, 10);
            else if (form.Name == "PoliTanit")
                ((PoliTanit)form).Location = new Point(300, 160);
            else if (form.Name == "PoliklinikForm")
                ((PoliklinikForm)form).Location = new Point(330, 150);
            else if (form.Name == "KullaniciTanit")
                ((KullaniciTanit)form).Location = new Point(330, 150);
            
        }


    }
}
