using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmKayit kayitFormu = new frmKayit();
            kayitFormu.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString();
            string day = DateTime.Now.DayOfWeek.ToString();

            switch (day)
            {
                case "Monday": lblGun.Text = "Pazartesi"; break;
                case "Tuesday": lblGun.Text = "Salı"; break;
                case "Wednesday": lblGun.Text = "Çarşamba"; break;
                case "Thursday": lblGun.Text = "Perşembe"; break;
                case "Friday": lblGun.Text = "Cuma"; break;
                case "Saturday": lblGun.Text = "Cumartesi"; break;
                case "Sunday": lblGun.Text = "Pazar"; break;
            }
        }

        private void btnDoktorBilgileri_Click(object sender, EventArgs e)
        {
            frmDoktorBilgi doktorFormu = new frmDoktorBilgi(false);
            doktorFormu.ShowDialog();
        }

        private void btnYeniDoktor_Click(object sender, EventArgs e)
        {
            frmYeniDoktor yeniDoktorFormu = new frmYeniDoktor();
            yeniDoktorFormu.ShowDialog();
        }

        private void btnYetkiliGirisi_Click(object sender, EventArgs e)
        {
            yetkiliLogin login = new yetkiliLogin();
            login.ShowDialog();
        }
    }
}
