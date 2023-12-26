using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospSystem
{
    public partial class frmDoktorPopUp : Form
    {
        bool _yetkiliMi = false;
        string doktorNo;
        public frmDoktorPopUp(string no, string adSoyad, string brans, bool izin, bool yetkiliMi)
        {
            InitializeComponent();

            doktorNo = no;
            _yetkiliMi = yetkiliMi;

            lblDoktorNo.Text = no;
            txtDoktorAdSoyad.Text = adSoyad;
            cmbBrans.Text = brans;
            if (izin)
            {
                rbGorevde.Checked = true;
                rbIzinli.Enabled = false;
            }
            else
            {
                rbIzinli.Checked = true;
                rbGorevde.Enabled = false;
            }
            _yetkiliMi = yetkiliMi;
        }

        void aktiflestirButon(bool kapat)
        {
            foreach (Control item in Controls)
            {
                if (item is Button)
                    item.Visible = kapat;
            }
        }

        private void frmDoktorPopUp_Load(object sender, EventArgs e)
        {
            aktiflestirButon(false);
            panel1.Visible = false;
            btnKapat.Visible = true;
            this.Size = new System.Drawing.Size(398, 166);
            if (_yetkiliMi)
            {
                aktiflestirButon(true);
                panel1.Visible = true;
                this.Size = new System.Drawing.Size(398, 253);
            }

            dbControl.check();
            SqlCommand cmd = new SqlCommand("SELECT *FROM tbl_branslar", sql.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Items.Add(dr["BransAdi"].ToString());
            }
            dr.Close();
            sql.con.Close();

            lblTarih.Text = DateTime.Now.ToString();
            timer1.Start();
            txtDoktorAdSoyad.Enabled = false;
            cmbBrans.Enabled = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDegisiklik_Click(object sender, EventArgs e)
        {
            btnDegisiklik.Visible = false;
            txtDoktorAdSoyad.Enabled = true;
            cmbBrans.Enabled = true;
            rbGorevde.Enabled = true;
            rbIzinli.Enabled = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Değişiklikler kaydedilmedi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool sonucIzin = true;
            if (rbGorevde.Checked)
                sonucIzin = true;
            else
                sonucIzin = false;
            try
            {
                dbControl.check();
                SqlCommand cmd = new SqlCommand("UPDATE tbl_doktorBilgi SET DoktorAdSoyad=@p1,DoktorBrans=@p2,DoktorIzinBilgi=@p3 WHERE DoktorNo=@p4", sql.con);
                cmd.Parameters.AddWithValue("@p1", txtDoktorAdSoyad.Text);
                cmd.Parameters.AddWithValue("@p2", cmbBrans.Text);
                cmd.Parameters.AddWithValue("@p3", sonucIzin);
                cmd.Parameters.AddWithValue("@p4", lblDoktorNo.Text);
                cmd.ExecuteNonQuery();
                sql.con.Close();
                MessageBox.Show("Bilgiler başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veri aktarılırken bir hata oluştu. Hata : " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString();
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            
            if (btnDegisiklik.Text != "Bu doktorun kaydı silinmiştir!")
            {
                try
                {
                    dbControl.check();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_doktorBilgi SET DoktorAktifPasif = 0 WHERE DoktorNo = @p1", sql.con);
                    cmd.Parameters.AddWithValue("@p1", doktorNo);
                    cmd.ExecuteNonQuery();
                    sql.con.Close();
                    MessageBox.Show("Doktor bilgisi güncellenmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDegisiklik.Enabled = false;
                    rbGorevde.Checked = false;
                    rbIzinli.Checked = false;
                    btnDegisiklik.Text = "Bu doktorun kaydı silinmiştir!";
                    btnDoktorSil.Text = "Kaydı Tekrar Aktifleştir!";
                    btnDoktorSil.BackColor = Color.Lime;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu. Hata : " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    dbControl.check();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_doktorBilgi SET DoktorAktifPasif = 1 WHERE DoktorNo = @p1", sql.con);
                    cmd.Parameters.AddWithValue("@p1", doktorNo);
                    cmd.ExecuteNonQuery();
                    sql.con.Close();
                    MessageBox.Show("Doktor bilgisi güncellenmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDegisiklik.Enabled = true;
                    rbGorevde.Checked = true;
                    rbIzinli.Checked = true;
                    btnDegisiklik.Text = "Değişiklik Yap";
                    btnDoktorSil.Text = "Doktor Kaydını Sil";
                    btnDoktorSil.BackColor = Color.IndianRed;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu. Hata : " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
