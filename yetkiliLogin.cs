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

namespace hospSystem
{
    public partial class yetkiliLogin : Form
    {
        public yetkiliLogin()
        {
            InitializeComponent();
        }

        int hata = 0;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            dbControl.check();
            SqlCommand cmd = new SqlCommand("SELECT *FROM tbl_yetkili WHERE YetkiliKullaniciAdi = @p1 AND YetkiliSifre = @p2 AND YetkiliAktifPasif=1", sql.con);
            cmd.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş başarılı. Hoş geldiniz, Sayın " + txtKullaniciAdi.Text, "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr.Close();
                frmYetkili yetkiliFormu = new frmYetkili();
                yetkiliFormu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
            sql.con.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            frmYetkili yetkiliFormu = new frmYetkili();
            this.Close();

        }
    }
}
