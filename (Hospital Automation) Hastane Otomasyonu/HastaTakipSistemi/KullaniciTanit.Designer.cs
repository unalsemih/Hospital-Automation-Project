namespace HastaTakipSistemi
{
    partial class KullaniciTanit
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
            this.cmBoxKullanicilar = new System.Windows.Forms.ComboBox();
            this.btnYeniKullanici = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmBoxKullanicilar
            // 
            this.cmBoxKullanicilar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxKullanicilar.FormattingEnabled = true;
            this.cmBoxKullanicilar.Location = new System.Drawing.Point(131, 63);
            this.cmBoxKullanicilar.Name = "cmBoxKullanicilar";
            this.cmBoxKullanicilar.Size = new System.Drawing.Size(132, 21);
            this.cmBoxKullanicilar.TabIndex = 27;
            this.cmBoxKullanicilar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.BackColor = System.Drawing.Color.LightGray;
            this.btnYeniKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKullanici.ForeColor = System.Drawing.Color.Green;
            this.btnYeniKullanici.Location = new System.Drawing.Point(46, 109);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(207, 32);
            this.btnYeniKullanici.TabIndex = 26;
            this.btnYeniKullanici.Text = "Yeni Kullanıcı Ekle";
            this.btnYeniKullanici.UseVisualStyleBackColor = false;
            this.btnYeniKullanici.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kullanıcı Kodu";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(296, 30);
            this.label1.MinimumSize = new System.Drawing.Size(296, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "  SOHATS - Kullanıcı Tanıtma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KullaniciTanit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 149);
            this.Controls.Add(this.cmBoxKullanicilar);
            this.Controls.Add(this.btnYeniKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciTanit";
            this.Text = "KullaniciTanit";
            this.Load += new System.EventHandler(this.KullaniciTanit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYeniKullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmBoxKullanicilar;
    }
}