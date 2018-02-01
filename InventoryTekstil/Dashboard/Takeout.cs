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

namespace InventoryTekstil.Dashboard
{
    public partial class Takeout : Form
    {
        public Takeout()
        {
            InitializeComponent();
        }
        MySqlConnection conn_user = new MySqlConnection("server=localhost; database=inventory_tekstil; UID=root; pwd=;");

        private void Takeout_Load(object sender, EventArgs e)
        {
            conn_user.Open();
            var sql = new MySqlCommand("SELECT * FROM tbl_jenis_kain", conn_user);
            MySqlDataReader read = sql.ExecuteReader();
            Dictionary<string, string> dick = new Dictionary<string, string>();
            while (read.Read())
            {
                comboBox1.Items.Add(read.GetString("nama"));
            }

            read.Close();
            conn_user.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn_user.Open();
            int stock = 0;
            int stockData = Int32.Parse(textBox1.Text.ToString());
            string query = "SELECT * FROM tbl_kain where kd_jenis=(select kd_jenis from tbl_jenis_kain where nama='" + comboBox1.Text + "') order by stock desc";
            var sql = new MySqlCommand(query, conn_user);
            MySqlDataReader read = sql.ExecuteReader();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            while (read.Read())
            {
                int stack = Int32.Parse(read.GetString("stock"));
                stock += stack;
                if (stack >= stockData)
                {

                    dataGridView1.Rows.Add(read.GetString("kd_kain"), read.GetString("kd_jenis"), read.GetString("lot"), read.GetString("panjang"), read.GetString("gramasi"), read.GetString("stock"));
                }
                else if (stack <= stockData && stock <= stockData)
                {
                    dataGridView1.Rows.Add(read.GetString("kd_kain"), read.GetString("kd_jenis"), read.GetString("lot"), read.GetString("panjang"), read.GetString("gramasi"), read.GetString("stock"));
                }
                else if (stack != stockData && stock <= stockData)
                {
                    dataGridView1.Rows.Add(read.GetString("kd_kain"), read.GetString("kd_jenis"), read.GetString("lot"), read.GetString("panjang"), read.GetString("gramasi"), read.GetString("stock"));
                }
                else
                {
                    stock -= stack;
                }

            }

            read.Close();
            conn_user.Close();
        }
    }
}
