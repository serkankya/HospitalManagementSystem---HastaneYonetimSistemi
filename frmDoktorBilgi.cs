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
    public partial class frmDoktorBilgi : Form
    {

        bool _yetkiliMi = false;
        public frmDoktorBilgi(bool yetkiliMi)
        {
            InitializeComponent();
            _yetkiliMi = yetkiliMi;
        }



        private void frmDoktorBilgi_Load(object sender, EventArgs e)
        {
        }

        private void txtDoktorBilgi_TextChanged(object sender, EventArgs e)
        {
            if (txtDoktorBilgi.Text != string.Empty)
            {
                dbControl.check();
                SqlCommand cmd = new SqlCommand("SELECT *FROM tbl_doktorBilgi WHERE DoktorAktifPasif=1 AND DoktorAdSoyad LIKE '%' + @p1 + '%' OR  DoktorNo LIKE '%' + @p1 + '%' ", sql.con);
                cmd.Parameters.AddWithValue("@p1", txtDoktorBilgi.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "DoktorBilgi");
                dataGridView1.DataSource = ds.Tables["DoktorBilgi"];
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["DoktorNo"].HeaderText = "Doktor Numarası";
                dataGridView1.Columns["DoktorAdSoyad"].HeaderText = "Ad - Soyad";
                dataGridView1.Columns["DoktorBrans"].HeaderText = "Branşı";
                dataGridView1.Columns["DoktorIzinBilgi"].HeaderText = "İzin Bilgisi(Seçili değilse izinli)";
                dataGridView1.Columns["DoktorAdSoyad"].Width = 200;
                dataGridView1.Columns["DoktorIzinBilgi"].Width = 160;
                dataGridView1.Columns["DoktorBrans"].Width = 120;
                dataGridView1.Columns["DoktorNo"].Width = 120;
                sql.con.Close();
            }
            else
            {
                lblBilgilendirme.ForeColor = Color.White;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_yetkiliMi) //yetkili ise bool değeri true olarak gidiyor
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                frmDoktorPopUp popUp = new frmDoktorPopUp(
                    dataGridView1.Rows[secilen].Cells[1].Value.ToString(),
                    dataGridView1.Rows[secilen].Cells[2].Value.ToString(),
                    dataGridView1.Rows[secilen].Cells[3].Value.ToString(),
                  bool.Parse(dataGridView1.Rows[secilen].Cells[4].Value.ToString()),
                  true
                    );
                popUp.ShowDialog();
                txtDoktorBilgi.Text = string.Empty;
            }
            else //yetkili değil ise bool değeri false olarak gidiyor
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                frmDoktorPopUp popUp = new frmDoktorPopUp(
                    dataGridView1.Rows[secilen].Cells[1].Value.ToString(),
                    dataGridView1.Rows[secilen].Cells[2].Value.ToString(),
                    dataGridView1.Rows[secilen].Cells[3].Value.ToString(),
                  bool.Parse(dataGridView1.Rows[secilen].Cells[4].Value.ToString()),
                  false
                    );
                popUp.ShowDialog();
                txtDoktorBilgi.Text = string.Empty;
            }
        }
    }
}
