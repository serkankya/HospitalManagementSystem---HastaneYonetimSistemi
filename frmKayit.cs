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
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            TextBox t = ((TextBox)sender);
            t.BackColor = Color.White;
        }

        private void txtAd_Enter(object sender, EventArgs e)
        {
            TextBox t = ((TextBox)sender);
            t.BackColor = Color.Yellow;
        }

        private void txtSikayet_Leave(object sender, EventArgs e)
        {
            RichTextBox t = ((RichTextBox)sender);
            t.BackColor = Color.White;
        }

        private void txtSikayet_Enter(object sender, EventArgs e)
        {
            RichTextBox t = ((RichTextBox)sender);
            t.BackColor = Color.Yellow;
        }

        private void txtDogumTarihi_Leave(object sender, EventArgs e)
        {
            MaskedTextBox t = ((MaskedTextBox)sender);
            t.BackColor = Color.White;
        }

        private void txtDogumTarihi_Enter(object sender, EventArgs e)
        {
            MaskedTextBox t = ((MaskedTextBox)sender);
            t.BackColor = Color.Yellow;
        }

        private void cmbDoktor_Leave(object sender, EventArgs e)
        {
            ComboBox t = ((ComboBox)sender);
            t.BackColor = Color.White;
        }

        private void cmbDoktor_Enter(object sender, EventArgs e)
        {
            ComboBox t = ((ComboBox)sender);
            t.BackColor = Color.Yellow;
        }

        private void frmKayit_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(848, 511);
            this.MaximumSize = new Size(848, 511);

            dbControl.check();
            SqlCommand cmd = new SqlCommand("SELECT DoktorAdSoyad FROM tbl_doktorBilgi", sql.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr.GetString(0));
            }
            dr.Close();

            sql.con.Close();
        }

        bool onayla = false;

        void BosMu()
        {
            bool varMi = false;
            foreach (Control item in grpHasta.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txtBox = (TextBox)item;
                    if (string.IsNullOrEmpty(item.Text) || item.Text.Length < 3)
                    {
                        varMi = true;
                        break;
                    }
                }
                if (item is RichTextBox)
                {
                    RichTextBox txtRich = (RichTextBox)item;
                    if (string.IsNullOrEmpty(item.Text) || item.Text.Length < 3)
                    {
                        varMi = true;
                        break;
                    }
                }
            }

            foreach (Control item in grpDoktor.Controls)
            {
                if (item is RichTextBox)
                {
                    RichTextBox txtRich = (RichTextBox)item;
                    if (string.IsNullOrEmpty(item.Text) || item.Text.Length < 3)
                    {
                        varMi = true;
                        break;
                    }
                }
            }

            if (varMi == true)
            {
                MessageBox.Show("Kutucukları boş bırakamazsınız.");
            }
            else
            {
                if (cmbDoktor.SelectedItem == null)
                {
                    MessageBox.Show("Doktor seçiniz.");
                }
                else
                {
                    if (txtDogumTarihi.Text.Length != 10)
                    {
                        MessageBox.Show("Tarih seçiniz.");
                    }
                    else
                    {
                        onayla = true;
                        varMi = false;

                    }
                }
            }
        }

        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            BosMu();
            if (onayla == true)
            {
                try
                {
                    dbControl.check();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_hastaBilgi (HastaTcKimlik,HastaAd,HastaSoyad,HastaAnneAdi,HastaBabaAdi,HastaDogumTarihi,HastaSikayet,Doktor,DoktorTeshis,DoktorIlac) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", sql.con);
                    cmd.Parameters.AddWithValue("@p1", txtTcKimlik.Text);
                    cmd.Parameters.AddWithValue("@p2", txtAd.Text);
                    cmd.Parameters.AddWithValue("@p3", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@p4", txtAnneAdi.Text);
                    cmd.Parameters.AddWithValue("@p5", txtBabaAdi.Text);
                    cmd.Parameters.AddWithValue("@p6", txtDogumTarihi.Text);
                    cmd.Parameters.AddWithValue("@p7", txtSikayet.Text);
                    cmd.Parameters.AddWithValue("@p8", cmbDoktor.SelectedItem);
                    cmd.Parameters.AddWithValue("@p9", txtTeshis.Text);
                    cmd.Parameters.AddWithValue("@p10", txtIlaclar.Text);
                    cmd.ExecuteNonQuery();
                    sql.con.Close();
                    MessageBox.Show("Hasta başarıyla kaydedildi.");
                    onayla = false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu. Hata : " + ex.Message, "KAYIT HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHastaIptal_Click(object sender, EventArgs e)
        {
            foreach (Control item in grpHasta.Controls)
            {
                if (item is TextBox || item is RichTextBox || item is MaskedTextBox)
                    item.Text = string.Empty;
            }

            foreach (Control item in grpDoktor.Controls)
            {
                if (item is RichTextBox || item is ComboBox)
                    item.Text = string.Empty;
            }
        }
    }
}
