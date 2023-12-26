namespace hospSystem
{
    partial class frmYetkili
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoktorAdet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIzinliAdet = new System.Windows.Forms.Label();
            this.btnDoktorAyarları = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Saynız : ";
            // 
            // lblDoktorAdet
            // 
            this.lblDoktorAdet.AutoSize = true;
            this.lblDoktorAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorAdet.Location = new System.Drawing.Point(180, 10);
            this.lblDoktorAdet.Name = "lblDoktorAdet";
            this.lblDoktorAdet.Size = new System.Drawing.Size(118, 22);
            this.lblDoktorAdet.TabIndex = 1;
            this.lblDoktorAdet.Text = "lblDoktorAdet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "İzinli Doktor Sayısı : ";
            // 
            // lblIzinliAdet
            // 
            this.lblIzinliAdet.AutoSize = true;
            this.lblIzinliAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIzinliAdet.Location = new System.Drawing.Point(180, 43);
            this.lblIzinliAdet.Name = "lblIzinliAdet";
            this.lblIzinliAdet.Size = new System.Drawing.Size(99, 22);
            this.lblIzinliAdet.TabIndex = 1;
            this.lblIzinliAdet.Text = "lblIzinliAdet";
            // 
            // btnDoktorAyarları
            // 
            this.btnDoktorAyarları.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorAyarları.Location = new System.Drawing.Point(16, 81);
            this.btnDoktorAyarları.Name = "btnDoktorAyarları";
            this.btnDoktorAyarları.Size = new System.Drawing.Size(326, 85);
            this.btnDoktorAyarları.TabIndex = 2;
            this.btnDoktorAyarları.Text = "Doktorları Göster\r\nveya\r\nDoktor Kayıtlarını Düzenle";
            this.btnDoktorAyarları.UseVisualStyleBackColor = true;
            this.btnDoktorAyarları.Click += new System.EventHandler(this.btnDoktorAyarları_Click);
            // 
            // frmYetkili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.btnDoktorAyarları);
            this.Controls.Add(this.lblIzinliAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDoktorAdet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmYetkili";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Paneli";
            this.Load += new System.EventHandler(this.frmYetkili_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDoktorAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIzinliAdet;
        private System.Windows.Forms.Button btnDoktorAyarları;
    }
}