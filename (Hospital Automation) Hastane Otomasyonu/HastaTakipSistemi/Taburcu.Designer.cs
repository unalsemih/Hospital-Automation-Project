namespace HastaTakipSistemi
{
    partial class Taburcu
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBoxOdeme = new System.Windows.Forms.ComboBox();
            this.cmBoxCikis = new System.Windows.Forms.ComboBox();
            this.cmBoxSevk = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dosya No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Enabled = false;
            this.txtDosyaNo.Location = new System.Drawing.Point(112, 15);
            this.txtDosyaNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(136, 20);
            this.txtDosyaNo.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sevk Tarihi ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Çıkış Tarihi ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ödeme Şekli";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmBoxOdeme
            // 
            this.cmBoxOdeme.FormattingEnabled = true;
            this.cmBoxOdeme.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit"});
            this.cmBoxOdeme.Location = new System.Drawing.Point(112, 102);
            this.cmBoxOdeme.Name = "cmBoxOdeme";
            this.cmBoxOdeme.Size = new System.Drawing.Size(136, 21);
            this.cmBoxOdeme.TabIndex = 38;
            // 
            // cmBoxCikis
            // 
            this.cmBoxCikis.Enabled = false;
            this.cmBoxCikis.FormattingEnabled = true;
            this.cmBoxCikis.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.cmBoxCikis.Location = new System.Drawing.Point(112, 72);
            this.cmBoxCikis.Name = "cmBoxCikis";
            this.cmBoxCikis.Size = new System.Drawing.Size(136, 21);
            this.cmBoxCikis.TabIndex = 39;
            // 
            // cmBoxSevk
            // 
            this.cmBoxSevk.Enabled = false;
            this.cmBoxSevk.FormattingEnabled = true;
            this.cmBoxSevk.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.cmBoxSevk.Location = new System.Drawing.Point(112, 43);
            this.cmBoxSevk.Name = "cmBoxSevk";
            this.cmBoxSevk.Size = new System.Drawing.Size(136, 21);
            this.cmBoxSevk.TabIndex = 40;
            // 
            // txtTutar
            // 
            this.txtTutar.Enabled = false;
            this.txtTutar.Location = new System.Drawing.Point(112, 133);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(136, 20);
            this.txtTutar.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Toplam Tutar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.txtDosyaNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmBoxSevk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmBoxCikis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmBoxOdeme);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 167);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVazgec.Location = new System.Drawing.Point(49, 182);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(80, 31);
            this.btnVazgec.TabIndex = 45;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnKaydet.Location = new System.Drawing.Point(149, 182);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 31);
            this.btnKaydet.TabIndex = 46;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Taburcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(280, 212);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.groupBox1);
            this.Name = "Taburcu";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Taburcu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBoxOdeme;
        public System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.ComboBox cmBoxCikis;
        public System.Windows.Forms.ComboBox cmBoxSevk;
    }
}