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

        private void benangMenu_Click(object sender, EventArgs e)
        {
            showReport("benang");
        }

        private void semicalMenu_Click(object sender, EventArgs e)
        {
            showReport("semical");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
