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
    public partial class frmYetkili : Form
    {
        public frmYetkili()
        {
            InitializeComponent();
        }

        private void frmYetkili_Load(object sender, EventArgs e)
        {
            dbControl.check();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbl_doktorBilgi WHERE DoktorAktifPasif=1", sql.con);
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM tbl_doktorBilgi WHERE DoktorAktifPasif=1 AND DoktorIzinBilgi=0", sql.con);
            int doktorAdet = (int)cmd.ExecuteScalar();
            int izinliAdet = (int)cmd2.ExecuteScalar();
            lblDoktorAdet.Text = doktorAdet.ToString();
            lblIzinliAdet.Text =izinliAdet.ToString();
            sql.con.Close();
        }

        private void btnDoktorAyarları_Click(object sender, EventArgs e)
        {
            frmDoktorBilgi bilgiFormu = new frmDoktorBilgi(true);
            bilgiFormu.ShowDialog();
        }
    }
}
