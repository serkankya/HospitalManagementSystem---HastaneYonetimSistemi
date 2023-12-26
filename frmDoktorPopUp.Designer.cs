namespace hospSystem
{
    partial class frmDoktorPopUp
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
            this.txtDoktorAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.rbIzinli = new System.Windows.Forms.RadioButton();
            this.rbGorevde = new System.Windows.Forms.RadioButton();
            this.lblDoktorNo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarih = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDegisiklik = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDoktorAdSoyad
            // 
            this.txtDoktorAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorAdSoyad.Location = new System.Drawing.Point(143, 69);
            this.txtDoktorAdSoyad.Name = "txtDoktorAdSoyad";
            this.txtDoktorAdSoyad.Size = new System.Drawing.Size(246, 26);
            this.txtDoktorAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doktor Numarası : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı - Soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Branşı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "İzin Durumu : ";
            // 
            // btnKapat
            // 
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(346, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(43, 28);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // rbIzinli
            // 
            this.rbIzinli.AutoSize = true;
            this.rbIzinli.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rbIzinli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbIzinli.Location = new System.Drawing.Point(143, 135);
            this.rbIzinli.Name = "rbIzinli";
            this.rbIzinli.Size = new System.Drawing.Size(58, 24);
            this.rbIzinli.TabIndex = 2;
            this.rbIzinli.TabStop = true;
            this.rbIzinli.Text = "İzinli";
            this.rbIzinli.UseVisualStyleBackColor = false;
            // 
            // rbGorevde
            // 
            this.rbGorevde.AutoSize = true;
            this.rbGorevde.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rbGorevde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbGorevde.Location = new System.Drawing.Point(207, 135);
            this.rbGorevde.Name = "rbGorevde";
            this.rbGorevde.Size = new System.Drawing.Size(88, 24);
            this.rbGorevde.TabIndex = 3;
            this.rbGorevde.TabStop = true;
            this.rbGorevde.Text = "Görevde";
            this.rbGorevde.UseVisualStyleBackColor = false;
            // 
            // lblDoktorNo
            // 
            this.lblDoktorNo.AutoSize = true;
            this.lblDoktorNo.BackColor = System.Drawing.Color.Gray;
            this.lblDoktorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorNo.Location = new System.Drawing.Point(144, 39);
            this.lblDoktorNo.Name = "lblDoktorNo";
            this.lblDoktorNo.Size = new System.Drawing.Size(70, 22);
            this.lblDoktorNo.TabIndex = 6;
            this.lblDoktorNo.Text = "123456";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTarih.Location = new System.Drawing.Point(7, 9);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(41, 15);
            this.lblTarih.TabIndex = 7;
            this.lblTarih.Text = "label5";
            // 
            // cmbBrans
            // 
            this.cmbBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(143, 101);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(246, 28);
            this.cmbBrans.TabIndex = 8;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.IndianRed;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(3, 3);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(120, 31);
            this.btnIptal.TabIndex = 0;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LawnGreen;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(123, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 31);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDegisiklik
            // 
            this.btnDegisiklik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDegisiklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegisiklik.Location = new System.Drawing.Point(0, 0);
            this.btnDegisiklik.Name = "btnDegisiklik";
            this.btnDegisiklik.Size = new System.Drawing.Size(246, 37);
            this.btnDegisiklik.TabIndex = 1;
            this.btnDegisiklik.Text = "Değişiklik Yap";
            this.btnDegisiklik.UseVisualStyleBackColor = true;
            this.btnDegisiklik.Click += new System.EventHandler(this.btnDegisiklik_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDegisiklik);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Location = new System.Drawing.Point(143, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 37);
            this.panel1.TabIndex = 5;
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnDoktorSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDoktorSil.Location = new System.Drawing.Point(143, 208);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(246, 37);
            this.btnDoktorSil.TabIndex = 9;
            this.btnDoktorSil.Text = "Doktor Kaydını Sil";
            this.btnDoktorSil.UseVisualStyleBackColor = false;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // frmDoktorPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(398, 253);
            this.Controls.Add(this.btnDoktorSil);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblDoktorNo);
            this.Controls.Add(this.rbGorevde);
            this.Controls.Add(this.rbIzinli);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.txtDoktorAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoktorPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoktorPopUp";
            this.Load += new System.EventHandler(this.frmDoktorPopUp_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDoktorAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.RadioButton rbIzinli;
        private System.Windows.Forms.RadioButton rbGorevde;
        private System.Windows.Forms.Label lblDoktorNo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDegisiklik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoktorSil;
    }
}