using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            raporDataGrid.Rows.Clear();
            SqlCommand komut = new SqlCommand("Select sevkTarihi,dosyaNo,poliklinik,yapilanIslem,toplamTutar,taburcu From sevk", DatabaseControl.baglan);
            DatabaseControl.baglan.Open();
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                if (rbTaburcuOlmamis.Checked)
                {
                    if (DateTime.Parse(dataReader["sevkTarihi"].ToString()) > BaslangicTarih.Value && DateTime.Parse(dataReader["sevkTarihi"].ToString()) < bitisTarih.Value && dataReader["taburcu"].ToString() == "")
                    {
                        /*    raporDataGrid.Rows.Add(
                    dataReader["sevkTarihi"].ToString(), dataReader["dosyaNo"].ToString(),
                    dataReader["poliklinik"].ToString(), dataReader["yapilanIslem"].ToString(),
                    dataReader["toplamTutar"].ToString(), dataReader["taburcu"].ToString());
        */
                        raporGridDoldur(raporDataGrid, dataReader);
    }
                }
                if (rbTaburcuOlmus.Checked)
                {
                    if (DateTime.Parse(dataReader["sevkTarihi"].ToString()) >= BaslangicTarih.Value && DateTime.Parse(dataReader["sevkTarihi"].ToString()) <= bitisTarih.Value && dataReader["taburcu"].ToString() != "")
                    {
                        raporGridDoldur(raporDataGrid, dataReader);
                    }
                }
                if (rbHepsi.Checked)
                {
                    if (DateTime.Parse(dataReader["sevkTarihi"].ToString()) >= BaslangicTarih.Value && DateTime.Parse(dataReader["sevkTarihi"].ToString()) <= bitisTarih.Value)
                    {
                        raporGridDoldur(raporDataGrid, dataReader);
                    }
                }

            }
            DatabaseControl.baglan.Close();
        }
        private void raporGridDoldur(DataGridView gridView,SqlDataReader dataReader)
        {
                            gridView.Rows.Add(
                           dataReader["sevkTarihi"].ToString(), dataReader["dosyaNo"].ToString(),
                           dataReader["poliklinik"].ToString(), dataReader["yapilanIslem"].ToString(),
                           dataReader["toplamTutar"].ToString(), dataReader["taburcu"].ToString());
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            raporDataGrid.Rows.Clear();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog yazdir = new PrintDialog();
            yazdir.Document = pdYazici;
            yazdir.UseEXDialog = true;
            if (yazdir.ShowDialog() == DialogResult.OK)
            {
                pdYazici.Print();
            }
        }
        Font altBilgi = new Font("Verdana", 8, FontStyle.Bold);
        Font baslik = new Font("Verdana", 16, FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush brush = new SolidBrush(Color.Black);
        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int j=800;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Rapor Tarih : " + DateTime.Now.Date.ToLongDateString(), govde, brush, 70, 20);
            e.Graphics.DrawString("Sevk Tarihi       Dosya No     Poliklinik          İşlem                Tutar     Taburcu ", govde, brush, 70, 150);
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", govde, brush, 70, 170);
            for (int i = 0; i < raporDataGrid.Rows.Count; i++)
            {
                e.Graphics.DrawString(raporDataGrid.Rows[i].Cells[0].Value + "          " +
                    raporDataGrid.Rows[i].Cells[1].Value + "           " + raporDataGrid.Rows[i].Cells[2].Value + "       " +
                     raporDataGrid.Rows[i].Cells[3].Value + "    \t" + raporDataGrid.Rows[i].Cells[4].Value + "     " +
                      raporDataGrid.Rows[i].Cells[5].Value, govde, brush, 70, 190 + (i * 30));
                j = i;
            }
            e.Graphics.DrawString("\n\n\n\n", govde, brush, 70, 150);
            e.Graphics.DrawString("------------------------------------------------------------------------------------------", govde, brush, 70, 190 + (j * 30) + 80);
            e.Graphics.DrawString("**Bu rapor " + BaslangicTarih.Value +" -- " + bitisTarih.Value + " tarihleri arasındaki sevkleri gösterir**", altBilgi, brush, 70, 190 + (j * 30)+100);
        }
    }
}
