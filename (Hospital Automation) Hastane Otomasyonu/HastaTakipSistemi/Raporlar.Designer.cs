namespace HastaTakipSistemi
{
    partial class Raporlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bitisTarih = new System.Windows.Forms.DateTimePicker();
            this.BaslangicTarih = new System.Windows.Forms.DateTimePicker();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.rbTaburcuOlmamis = new System.Windows.Forms.RadioButton();
            this.rbTaburcuOlmus = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.raporDataGrid = new System.Windows.Forms.DataGridView();
            this.sevkTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poliklinik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yapilanIslem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taburcu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.ppDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bitisTarih);
            this.panel1.Controls.Add(this.BaslangicTarih);
            this.panel1.Controls.Add(this.btnYazdir);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnSorgula);
            this.panel1.Controls.Add(this.rbHepsi);
            this.panel1.Controls.Add(this.rbTaburcuOlmamis);
            this.panel1.Controls.Add(this.rbTaburcuOlmus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 76);
            this.panel1.TabIndex = 24;
            // 
            // bitisTarih
            // 
            this.bitisTarih.CustomFormat = "dd.MM.yyyy";
            this.bitisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bitisTarih.Location = new System.Drawing.Point(125, 38);
            this.bitisTarih.Margin = new System.Windows.Forms.Padding(2);
            this.bitisTarih.Name = "bitisTarih";
            this.bitisTarih.Size = new System.Drawing.Size(149, 20);
            this.bitisTarih.TabIndex = 39;
            this.bitisTarih.Value = new System.DateTime(2018, 12, 27, 0, 0, 0, 0);
            // 
            // BaslangicTarih
            // 
            this.BaslangicTarih.CustomFormat = "dd.MM.yyyy";
            this.BaslangicTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BaslangicTarih.Location = new System.Drawing.Point(125, 4);
            this.BaslangicTarih.Margin = new System.Windows.Forms.Padding(2);
            this.BaslangicTarih.Name = "BaslangicTarih";
            this.BaslangicTarih.Size = new System.Drawing.Size(149, 20);
            this.BaslangicTarih.TabIndex = 38;
            this.BaslangicTarih.Value = new System.DateTime(2018, 12, 27, 0, 0, 0, 0);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(689, 10);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(92, 51);
            this.btnYazdir.TabIndex = 37;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(591, 10);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(92, 51);
            this.btnTemizle.TabIndex = 36;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.Location = new System.Drawing.Point(493, 10);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(92, 51);
            this.btnSorgula.TabIndex = 35;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.Location = new System.Drawing.Point(346, 49);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(52, 17);
            this.rbHepsi.TabIndex = 34;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = true;
            // 
            // rbTaburcuOlmamis
            // 
            this.rbTaburcuOlmamis.AutoSize = true;
            this.rbTaburcuOlmamis.Location = new System.Drawing.Point(346, 27);
            this.rbTaburcuOlmamis.Name = "rbTaburcuOlmamis";
            this.rbTaburcuOlmamis.Size = new System.Drawing.Size(107, 17);
            this.rbTaburcuOlmamis.TabIndex = 33;
            this.rbTaburcuOlmamis.TabStop = true;
            this.rbTaburcuOlmamis.Text = "Taburcu Olmamıs";
            this.rbTaburcuOlmamis.UseVisualStyleBackColor = true;
            // 
            // rbTaburcuOlmus
            // 
            this.rbTaburcuOlmus.AutoSize = true;
            this.rbTaburcuOlmus.Location = new System.Drawing.Point(346, 4);
            this.rbTaburcuOlmus.Name = "rbTaburcuOlmus";
            this.rbTaburcuOlmus.Size = new System.Drawing.Size(97, 17);
            this.rbTaburcuOlmus.TabIndex = 32;
            this.rbTaburcuOlmus.TabStop = true;
            this.rbTaburcuOlmus.Text = "Taburcu Olmuş";
            this.rbTaburcuOlmus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Bitiş Tarihi ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Başlangıç Tarihi ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // raporDataGrid
            // 
            this.raporDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raporDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sevkTarihi,
            this.dosyaNo,
            this.poliklinik,
            this.yapilanIslem,
            this.toplamTutar,
            this.taburcu});
            this.raporDataGrid.Location = new System.Drawing.Point(0, 74);
            this.raporDataGrid.Name = "raporDataGrid";
            this.raporDataGrid.Size = new System.Drawing.Size(800, 375);
            this.raporDataGrid.TabIndex = 25;
            // 
            // sevkTarihi
            // 
            this.sevkTarihi.HeaderText = "Sevk Tarihi";
            this.sevkTarihi.Name = "sevkTarihi";
            // 
            // dosyaNo
            // 
            this.dosyaNo.HeaderText = "Dosya No";
            this.dosyaNo.Name = "dosyaNo";
            // 
            // poliklinik
            // 
            this.poliklinik.HeaderText = "Poliklinik";
            this.poliklinik.Name = "poliklinik";
            // 
            // yapilanIslem
            // 
            this.yapilanIslem.HeaderText = "Yapilan Islem";
            this.yapilanIslem.Name = "yapilanIslem";
            // 
            // toplamTutar
            // 
            this.toplamTutar.HeaderText = "ToplamTutar";
            this.toplamTutar.Name = "toplamTutar";
            // 
            // taburcu
            // 
            this.taburcu.HeaderText = "Taburcu";
            this.taburcu.Name = "taburcu";
            // 
            // pdYazici
            // 
            this.pdYazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_PrintPage);
            // 
            // ppDialog
            // 
            this.ppDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppDialog.Enabled = true;
            this.ppDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppDialog.Icon")));
            this.ppDialog.Name = "ppDialog";
            this.ppDialog.Text = "Baskı önizleme";
            this.ppDialog.Visible = false;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.raporDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "Raporlar";
            this.Text = "FormDosyaIslem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.RadioButton rbHepsi;
        private System.Windows.Forms.RadioButton rbTaburcuOlmamis;
        private System.Windows.Forms.RadioButton rbTaburcuOlmus;
        public System.Windows.Forms.DateTimePicker bitisTarih;
        public System.Windows.Forms.DateTimePicker BaslangicTarih;
        public System.Windows.Forms.DataGridView raporDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sevkTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn poliklinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapilanIslem;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn taburcu;
        private System.Drawing.Printing.PrintDocument pdYazici;
        private System.Windows.Forms.PrintPreviewDialog ppDialog;
    }
}