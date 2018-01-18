using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryTekstil
{
    public partial class ReportForm : Form
    {
        public String titleLabel = "";
        public String jenis = "";
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=0616104004");

        public ReportForm()
        {
            InitializeComponent();
            
        }

        void loadDataset()
        {
            
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            label1.Text = titleLabel;
        }
    }
}
