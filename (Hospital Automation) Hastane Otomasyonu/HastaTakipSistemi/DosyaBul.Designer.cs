namespace HastaTakipSistemi
{
    partial class DosyaBul
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
            this.bulunanDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.checkAnd = new System.Windows.Forms.CheckBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.cmBoxAramaKriter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAramaAdSoyad = new System.Windows.Forms.Panel();
            this.pnl2Arama = new System.Windows.Forms.Panel();
            this.txtAramaMetni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bulunanDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlAramaAdSoyad.SuspendLayout();
            this.pnl2Arama.SuspendLayout();
            this.SuspendLayout();
            // 
            // bulunanDataGrid
            // 
            this.bulunanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bulunanDataGrid.Location = new System.Drawing.Point(0, 49);
            this.bulunanDataGrid.Name = "bulunanDataGrid";
            this.bulunanDataGrid.Size = new System.Drawing.Size(667, 389);
            this.bulunanDataGrid.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pnl2Arama);
            this.panel1.Controls.Add(this.pnlAramaAdSoyad);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.cmBoxAramaKriter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 50);
            this.panel1.TabIndex = 16;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBul.Location = new System.Drawing.Point(575, 12);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(62, 29);
            this.btnBul.TabIndex = 33;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(206, 7);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.MaxLength = 15;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(113, 20);
            this.txtSoyad.TabIndex = 32;
            // 
            // checkAnd
            // 
            this.checkAnd.AutoSize = true;
            this.checkAnd.Location = new System.Drawing.Point(152, 10);
            this.checkAnd.Name = "checkAnd";
            this.checkAnd.Size = new System.Drawing.Size(38, 17);
            this.checkAnd.TabIndex = 31;
            this.checkAnd.Text = "ve";
            this.checkAnd.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(20, 6);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.MaxLength = 15;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(115, 20);
            this.txtAd.TabIndex = 30;
            // 
            // cmBoxAramaKriter
            // 
            this.cmBoxAramaKriter.FormattingEnabled = true;
            this.cmBoxAramaKriter.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.cmBoxAramaKriter.Location = new System.Drawing.Point(111, 14);
            this.cmBoxAramaKriter.Name = "cmBoxAramaKriter";
            this.cmBoxAramaKriter.Size = new System.Drawing.Size(118, 21);
            this.cmBoxAramaKriter.TabIndex = 29;
            this.cmBoxAramaKriter.SelectedValueChanged += new System.EventHandler(this.cmBoxAramaKriter_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Arama Kriteri";
            // 
            // pnlAramaAdSoyad
            // 
            this.pnlAramaAdSoyad.Controls.Add(this.txtAd);
            this.pnlAramaAdSoyad.Controls.Add(this.checkAnd);
            this.pnlAramaAdSoyad.Controls.Add(this.txtSoyad);
            this.pnlAramaAdSoyad.Location = new System.Drawing.Point(235, 10);
            this.pnlAramaAdSoyad.Name = "pnlAramaAdSoyad";
            this.pnlAramaAdSoyad.Size = new System.Drawing.Size(334, 31);
            this.pnlAramaAdSoyad.TabIndex = 35;
            // 
            // pnl2Arama
            // 
            this.pnl2Arama.Controls.Add(this.txtAramaMetni);
            this.pnl2Arama.Location = new System.Drawing.Point(235, 11);
            this.pnl2Arama.Name = "pnl2Arama";
            this.pnl2Arama.Size = new System.Drawing.Size(334, 31);
            this.pnl2Arama.TabIndex = 36;
            this.pnl2Arama.Visible = false;
            // 
            // txtAramaMetni
            // 
            this.txtAramaMetni.Location = new System.Drawing.Point(20, 6);
            this.txtAramaMetni.Margin = new System.Windows.Forms.Padding(2);
            this.txtAramaMetni.MaxLength = 12;
            this.txtAramaMetni.Name = "txtAramaMetni";
            this.txtAramaMetni.Size = new System.Drawing.Size(298, 20);
            this.txtAramaMetni.TabIndex = 30;
            // 
            // DosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bulunanDataGrid);
            this.Name = "DosyaBul";
            this.Text = "DosyaBul";
            ((System.ComponentModel.ISupportInitialize)(this.bulunanDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAramaAdSoyad.ResumeLayout(false);
            this.pnlAramaAdSoyad.PerformLayout();
            this.pnl2Arama.ResumeLayout(false);
            this.pnl2Arama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmBoxAramaKriter;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.CheckBox checkAnd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Panel pnl2Arama;
        private System.Windows.Forms.TextBox txtAramaMetni;
        private System.Windows.Forms.Panel pnlAramaAdSoyad;
        public System.Windows.Forms.DataGridView bulunanDataGrid;
    }
}