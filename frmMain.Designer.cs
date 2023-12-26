namespace hospSystem
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGun = new System.Windows.Forms.Label();
            this.btnDoktorBilgileri = new System.Windows.Forms.Button();
            this.btnYeniDoktor = new System.Windows.Forms.Button();
            this.btnYetkiliGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(27, 42);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(761, 41);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Kayıt Oluştur";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(24, 6);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(175, 24);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "14.05.2000 14:05:59";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGun.ForeColor = System.Drawing.Color.White;
            this.lblGun.Location = new System.Drawing.Point(205, 6);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(60, 24);
            this.lblGun.TabIndex = 1;
            this.lblGun.Text = "label1";
            // 
            // btnDoktorBilgileri
            // 
            this.btnDoktorBilgileri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoktorBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorBilgileri.Location = new System.Drawing.Point(27, 89);
            this.btnDoktorBilgileri.Name = "btnDoktorBilgileri";
            this.btnDoktorBilgileri.Size = new System.Drawing.Size(761, 42);
            this.btnDoktorBilgileri.TabIndex = 2;
            this.btnDoktorBilgileri.Text = "Doktor Bilgi Paneli";
            this.btnDoktorBilgileri.UseVisualStyleBackColor = true;
            this.btnDoktorBilgileri.Click += new System.EventHandler(this.btnDoktorBilgileri_Click);
            // 
            // btnYeniDoktor
            // 
            this.btnYeniDoktor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniDoktor.Location = new System.Drawing.Point(27, 137);
            this.btnYeniDoktor.Name = "btnYeniDoktor";
            this.btnYeniDoktor.Size = new System.Drawing.Size(761, 44);
            this.btnYeniDoktor.TabIndex = 3;
            this.btnYeniDoktor.Text = "Yeni Doktor Ekleme Paneli";
            this.btnYeniDoktor.UseVisualStyleBackColor = true;
            this.btnYeniDoktor.Click += new System.EventHandler(this.btnYeniDoktor_Click);
            // 
            // btnYetkiliGirisi
            // 
            this.btnYetkiliGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkiliGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiliGirisi.Location = new System.Drawing.Point(27, 187);
            this.btnYetkiliGirisi.Name = "btnYetkiliGirisi";
            this.btnYetkiliGirisi.Size = new System.Drawing.Size(760, 44);
            this.btnYetkiliGirisi.TabIndex = 4;
            this.btnYetkiliGirisi.Text = "Yetkili Girişi";
            this.btnYetkiliGirisi.UseVisualStyleBackColor = true;
            this.btnYetkiliGirisi.Click += new System.EventHandler(this.btnYetkiliGirisi_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 253);
            this.Controls.Add(this.btnYetkiliGirisi);
            this.Controls.Add(this.btnYeniDoktor);
            this.Controls.Add(this.btnDoktorBilgileri);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Button btnDoktorBilgileri;
        private System.Windows.Forms.Button btnYeniDoktor;
        private System.Windows.Forms.Button btnYetkiliGirisi;
    }
}