namespace hospSystem
{
    partial class frmKayit
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTeshis = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIlaclar = new System.Windows.Forms.RichTextBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.grpDoktor = new System.Windows.Forms.GroupBox();
            this.btnHastaIptal = new System.Windows.Forms.Button();
            this.btnHastaKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtAnneAdi = new System.Windows.Forms.TextBox();
            this.txtDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txtSikayet = new System.Windows.Forms.RichTextBox();
            this.grpHasta = new System.Windows.Forms.GroupBox();
            this.txtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.grpDoktor.SuspendLayout();
            this.grpHasta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Verilen İlaçlar(Varsa) : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(62, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Yapılan Teşhis : ";
            // 
            // txtTeshis
            // 
            this.txtTeshis.Location = new System.Drawing.Point(179, 67);
            this.txtTeshis.Name = "txtTeshis";
            this.txtTeshis.Size = new System.Drawing.Size(215, 150);
            this.txtTeshis.TabIndex = 1;
            this.txtTeshis.Text = "";
            this.txtTeshis.Enter += new System.EventHandler(this.txtSikayet_Enter);
            this.txtTeshis.Leave += new System.EventHandler(this.txtSikayet_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tedaviyi Yapan Doktor : ";
            // 
            // txtIlaclar
            // 
            this.txtIlaclar.Location = new System.Drawing.Point(179, 223);
            this.txtIlaclar.Name = "txtIlaclar";
            this.txtIlaclar.Size = new System.Drawing.Size(215, 150);
            this.txtIlaclar.TabIndex = 2;
            this.txtIlaclar.Text = "";
            this.txtIlaclar.Enter += new System.EventHandler(this.txtSikayet_Enter);
            this.txtIlaclar.Leave += new System.EventHandler(this.txtSikayet_Leave);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(179, 29);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(215, 28);
            this.cmbDoktor.TabIndex = 0;
            this.cmbDoktor.Enter += new System.EventHandler(this.cmbDoktor_Enter);
            this.cmbDoktor.Leave += new System.EventHandler(this.cmbDoktor_Leave);
            // 
            // grpDoktor
            // 
            this.grpDoktor.Controls.Add(this.btnHastaIptal);
            this.grpDoktor.Controls.Add(this.btnHastaKaydet);
            this.grpDoktor.Controls.Add(this.cmbDoktor);
            this.grpDoktor.Controls.Add(this.txtIlaclar);
            this.grpDoktor.Controls.Add(this.label6);
            this.grpDoktor.Controls.Add(this.txtTeshis);
            this.grpDoktor.Controls.Add(this.label7);
            this.grpDoktor.Controls.Add(this.label8);
            this.grpDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpDoktor.Location = new System.Drawing.Point(360, 0);
            this.grpDoktor.Name = "grpDoktor";
            this.grpDoktor.Size = new System.Drawing.Size(418, 448);
            this.grpDoktor.TabIndex = 6;
            this.grpDoktor.TabStop = false;
            this.grpDoktor.Text = "Doktor Teşhisi";
            // 
            // btnHastaIptal
            // 
            this.btnHastaIptal.BackColor = System.Drawing.Color.IndianRed;
            this.btnHastaIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaIptal.Location = new System.Drawing.Point(179, 387);
            this.btnHastaIptal.Name = "btnHastaIptal";
            this.btnHastaIptal.Size = new System.Drawing.Size(101, 33);
            this.btnHastaIptal.TabIndex = 7;
            this.btnHastaIptal.Text = "İPTAL";
            this.btnHastaIptal.UseVisualStyleBackColor = false;
            this.btnHastaIptal.Click += new System.EventHandler(this.btnHastaIptal_Click);
            // 
            // btnHastaKaydet
            // 
            this.btnHastaKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHastaKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaKaydet.Location = new System.Drawing.Point(293, 387);
            this.btnHastaKaydet.Name = "btnHastaKaydet";
            this.btnHastaKaydet.Size = new System.Drawing.Size(101, 33);
            this.btnHastaKaydet.TabIndex = 8;
            this.btnHastaKaydet.Text = "KAYDET";
            this.btnHastaKaydet.UseVisualStyleBackColor = false;
            this.btnHastaKaydet.Click += new System.EventHandler(this.btnHastaKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC Kimlik No : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şikayet : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Anne Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad : ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(113, 53);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(215, 24);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtSoyad.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(34, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Baba Adı : ";
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBabaAdi.Location = new System.Drawing.Point(113, 110);
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(215, 24);
            this.txtBabaAdi.TabIndex = 3;
            this.txtBabaAdi.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtBabaAdi.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(113, 23);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(215, 24);
            this.txtAd.TabIndex = 0;
            this.txtAd.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtAnneAdi
            // 
            this.txtAnneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAnneAdi.Location = new System.Drawing.Point(113, 84);
            this.txtAnneAdi.Name = "txtAnneAdi";
            this.txtAnneAdi.Size = new System.Drawing.Size(215, 24);
            this.txtAnneAdi.TabIndex = 2;
            this.txtAnneAdi.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtAnneAdi.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDogumTarihi.Location = new System.Drawing.Point(113, 174);
            this.txtDogumTarihi.Mask = "00/00/0000";
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(215, 26);
            this.txtDogumTarihi.TabIndex = 5;
            this.txtDogumTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDogumTarihi.ValidatingType = typeof(System.DateTime);
            this.txtDogumTarihi.Enter += new System.EventHandler(this.txtDogumTarihi_Enter);
            this.txtDogumTarihi.Leave += new System.EventHandler(this.txtDogumTarihi_Leave);
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(113, 223);
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(215, 197);
            this.txtSikayet.TabIndex = 6;
            this.txtSikayet.Text = "";
            this.txtSikayet.Enter += new System.EventHandler(this.txtSikayet_Enter);
            this.txtSikayet.Leave += new System.EventHandler(this.txtSikayet_Leave);
            // 
            // grpHasta
            // 
            this.grpHasta.Controls.Add(this.txtTcKimlik);
            this.grpHasta.Controls.Add(this.txtSikayet);
            this.grpHasta.Controls.Add(this.txtDogumTarihi);
            this.grpHasta.Controls.Add(this.txtAnneAdi);
            this.grpHasta.Controls.Add(this.txtAd);
            this.grpHasta.Controls.Add(this.label4);
            this.grpHasta.Controls.Add(this.txtBabaAdi);
            this.grpHasta.Controls.Add(this.label10);
            this.grpHasta.Controls.Add(this.txtSoyad);
            this.grpHasta.Controls.Add(this.label2);
            this.grpHasta.Controls.Add(this.label9);
            this.grpHasta.Controls.Add(this.label5);
            this.grpHasta.Controls.Add(this.label1);
            this.grpHasta.Controls.Add(this.label3);
            this.grpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpHasta.Location = new System.Drawing.Point(0, 0);
            this.grpHasta.Name = "grpHasta";
            this.grpHasta.Size = new System.Drawing.Size(354, 448);
            this.grpHasta.TabIndex = 3;
            this.grpHasta.TabStop = false;
            this.grpHasta.Text = "Hasta Bilgileri";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(113, 141);
            this.txtTcKimlik.Mask = "00000000000";
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(215, 26);
            this.txtTcKimlik.TabIndex = 7;
            this.txtTcKimlik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTcKimlik.ValidatingType = typeof(int);
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(786, 457);
            this.Controls.Add(this.grpDoktor);
            this.Controls.Add(this.grpHasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kayıt Formu";
            this.Load += new System.EventHandler(this.frmKayit_Load);
            this.grpDoktor.ResumeLayout(false);
            this.grpDoktor.PerformLayout();
            this.grpHasta.ResumeLayout(false);
            this.grpHasta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtTeshis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtIlaclar;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.GroupBox grpDoktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBabaAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtAnneAdi;
        private System.Windows.Forms.MaskedTextBox txtDogumTarihi;
        private System.Windows.Forms.RichTextBox txtSikayet;
        private System.Windows.Forms.Button btnHastaIptal;
        private System.Windows.Forms.Button btnHastaKaydet;
        private System.Windows.Forms.GroupBox grpHasta;
        private System.Windows.Forms.MaskedTextBox txtTcKimlik;
    }
}