using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventoryTekstil
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

       


        private void dashboardMenu_Click(object sender, EventArgs e)
        {
            Dashboard.DashboardDetail reg = new Dashboard.DashboardDetail();
            reg.MdiParent = this;
            reg.Show();
        }

        private void showReport(String jenis) {
            ReportForm f = new ReportForm();
            f.MdiParent = this;
            f.titleLabel = "REPORT " + jenis.ToUpper();
            f.jenis = jenis;
            f.Show();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            Dashboard.DashboardDetail reg = new Dashboard.DashboardDetail();
            reg.MdiParent = this;
            reg.Show();


            rawMaterialMenu.Visible = true;
            finishedGoodsMenu.Visible = true;
            reportMenu.Visible = true;
            settingMenu.Visible = true;
            userMenu.Visible = true;

            switch (Utils.Session.role)
            {
                case ("staff"):
                    userMenu.Visible = false;
                    reportMenu.Visible = false;
                    break;
                case ("manager"):
                    finishedGoodsMenu.Visible = false;
                    rawMaterialMenu.Visible = false;
                    settingMenu.Visible = false;
                    break;
                default:
                    break;
            }
        }
        
        // BENANG

        private void benangAdd_Click(object sender, EventArgs e)
        {
            Input.InputBenang benang = new Input.InputBenang();
            benang.MdiParent = this;
            benang.Show();
        }


        // SEMICAL
        private void semicalAdd_Click(object sender, EventArgs e)
        {
            Input.InputSemical semical = new Input.InputSemical();
            semical.MdiParent = this;
            semical.Show();
        }

        // KAIN
        private void kainAdd_Click(object sender, EventArgs e)
        {
            Input.InputKain kain = new Input.InputKain();
            kain.MdiParent = this;
            kain.Show();
        }

        private void kainTakeOut_Click(object sender, EventArgs e)
        {
            Dashboard.Takeout takeout = new Dashboard.Takeout();
            takeout.MdiParent = this;
            takeout.Show();
        }

        private void showReportIn(string jenis)
        {
            Report.ReportIn report = new Report.ReportIn();
            report.MdiParent = this;
            report.jenis = jenis;
            report.Show();
        }

        private void kainReportIn_Click(object sender, EventArgs e)
        {
            showReportIn("kain");
        }

        private void benangReportIn_Click(object sender, EventArgs e)
        {
            showReportIn("benang");
        }

        private void semicalReportIn_Click(object sender, EventArgs e)
        {
            showReportIn("semical");
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();

        }

        private void userMenu_Click(object sender, EventArgs e)
        {
            Login.Registrasi reg = new Login.Registrasi();
            reg.MdiParent = this;
            reg.Show();
        }
    }
}
