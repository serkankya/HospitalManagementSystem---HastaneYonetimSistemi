using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospSystem
{
    public partial class frmYeniDoktor : Form
    {
        public frmYeniDoktor()
        {
            InitializeComponent();
        }

        int olusturulanNo;
        void randomNo()
        {
            Random rnd = new Random();
            olusturulanNo = rnd.Next(100000, 300000);
            olusturulanNo.ToString();
            NoGenerator();
        }

        void NoGenerator()
        {
            dbControl.check();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_doktorBilgi WHERE DoktorNo = @p1", sql.con);
            cmd.Parameters.AddWithValue("@p1", olusturulanNo);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                sql.con.Close();
                randomNo();
            }
            else
            {
                lblNumara.Text = olusturulanNo.ToString();
            }
            dr.Close();
            sql.con.Close();
        }

        private void btnNumaraOlustur_Click(object sender, EventArgs e)
        {
            randomNo();
            btnKaydet.Enabled = true;
        }

        private void frmYeniDoktor_Load(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;

            dbControl.check();
            SqlCommand cmd = new SqlCommand("SELECT *FROM tbl_branslar", sql.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbBrans.Items.Add(dr["BransAdi"].ToString());
            }
            dr.Close();
            sql.con.Close();
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşleminiz iptal ediliyor.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtAdSoyad.Text.Length < 4 ||txtDogumTarihi.Text.Length != 10 || txtTcKimlik.Text.Length != 11 || txtUniversite.Text.Length <4 || txtUnvan.Text.Length<4 || cmbBrans.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ilgili yerleri doğru şekilde doldurunuz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    dbControl.check();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_doktorBilgi (DoktorNo,DoktorAdSoyad,DoktorBrans,DoktorUnvan,DoktorUniversite,DoktorTCNo,DoktorDogumTarih) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", sql.con);
                    cmd.Parameters.AddWithValue("@p1", lblNumara.Text);
                    cmd.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
                    cmd.Parameters.AddWithValue("@p3", cmbBrans.Text);
                    cmd.Parameters.AddWithValue("@p4", txtUnvan.Text);
                    cmd.Parameters.AddWithValue("@p5", txtUniversite.Text);
                    cmd.Parameters.AddWithValue("@p6", txtTcKimlik.Text);
                    cmd.Parameters.AddWithValue("@p7", txtDogumTarihi.Text);
                    cmd.ExecuteNonQuery();
                    sql.con.Close();
                    MessageBox.Show("Kayıt başarı ile tamamlandı.");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu. Lütfen bilgileri doğru girdiğinizden emin olun. Hata : " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }             
            }
        }
    }
}

