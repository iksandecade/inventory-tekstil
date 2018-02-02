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
        Int32 stockData;

        private void Takeout_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
            dataGridView2.Enabled = false;
            button1.Enabled = false;
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
            stockData = 0;
            stockData = Int32.Parse(textBox1.Text.ToString());
            string query = "SELECT * FROM tbl_kain where kd_jenis=(select kd_jenis from tbl_jenis_kain where nama='" + comboBox1.Text + "') order by stok asc";
            var sql = new MySqlCommand(query, conn_user);
            MySqlDataReader read = sql.ExecuteReader();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            while (read.Read())
            {
                dataGridView1.Rows.Add(read.GetString("kd_kain"), read.GetString("kd_jenis"), read.GetString("lot"), read.GetString("panjang"), read.GetString("gramasi"), read.GetString("stok"));
            }

            read.Close();
            conn_user.Close();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (selectedCellCount > 1)
                {
                    MessageBox.Show("All cell are selected", "Selected Cells");
                }
                else
                {                    

                    Int32 row = dataGridView1.SelectedCells[0].RowIndex;
                    string kodeKain = dataGridView1.Rows[row].Cells[0].Value.ToString();
                    string kodeJenis = dataGridView1.Rows[row].Cells[1].Value.ToString();
                    string lot = dataGridView1.Rows[row].Cells[2].Value.ToString();
                    string panjang = dataGridView1.Rows[row].Cells[3].Value.ToString();
                    string gramasi = dataGridView1.Rows[row].Cells[4].Value.ToString();
                    string stock = dataGridView1.Rows[row].Cells[5].Value.ToString();

                    if (Int32.Parse(stock) >= stockData)
                    {
                        Int32 sisaStock = Int32.Parse(stock) - stockData;
                        stock = (stockData).ToString();
                        if (sisaStock != 0) { 
                            dataGridView1.Rows[row].Cells[5].Value = sisaStock.ToString();
                        }
                        else
                        {
                            dataGridView1.Rows.RemoveAt(row);
                        }
                        stockData = 0;
                        button4.Enabled = false;
                        dataGridView1.Enabled = false;
                        button1.Enabled = true;
                    }
                    else
                    {
                        stockData = stockData - Int32.Parse(stock);
                        dataGridView1.Rows.RemoveAt(row);
                    }
                    dataGridView2.Rows.Add(kodeKain, kodeJenis, lot, panjang, gramasi, stock);
                    button5.Enabled = true;
                    dataGridView2.Enabled = true;                    
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridView2.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (selectedCellCount > 1)
                {
                    MessageBox.Show("All cell are selected", "Selected Cells");
                }
                else
                {

                    Int32 row = dataGridView2.SelectedCells[0].RowIndex;
                    string kodeKain = dataGridView2.Rows[row].Cells[0].Value.ToString();
                    string kodeJenis = dataGridView2.Rows[row].Cells[1].Value.ToString();
                    string lot = dataGridView2.Rows[row].Cells[2].Value.ToString();
                    string panjang = dataGridView2.Rows[row].Cells[3].Value.ToString();
                    string gramasi = dataGridView2.Rows[row].Cells[4].Value.ToString();
                    string stock = dataGridView2.Rows[row].Cells[5].Value.ToString();

                    Boolean isAvaialbe = false;
                    Int32 avaiableAt = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == kodeKain)
                        {
                            isAvaialbe = true;
                            avaiableAt = i;                          
                        }
                    }

                    if (isAvaialbe)
                    {                        
                        Int32 stock1 = Int32.Parse(dataGridView1.Rows[avaiableAt].Cells[5].Value.ToString());
                        Int32 stock2 = Int32.Parse(stock);
                        dataGridView1.Rows[avaiableAt].Cells[5].Value = (stock1 + stock2).ToString();
                        dataGridView2.Rows.RemoveAt(row);
                        stockData = stockData + stock2;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(kodeKain, kodeJenis, lot, panjang, gramasi, stock);
                        dataGridView2.Rows.RemoveAt(row);
                        stockData = stockData + Int32.Parse(stock);
                    }

                    if (dataGridView2.Rows.Count == 0)
                    {
                        button5.Enabled = false;
                        dataGridView2.Enabled = false;
                    }
                    button4.Enabled = true;
                    dataGridView1.Enabled = true;
                    button1.Enabled = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn_user.Open();

            for (int rows = 0; rows < dataGridView2.Rows.Count; rows++)
            {

                Int32 row = dataGridView2.SelectedCells[0].RowIndex;
                string kodeKain = dataGridView2.Rows[rows].Cells[0].Value.ToString();
                string stock = dataGridView2.Rows[rows].Cells[5].Value.ToString();
                DateTime today = DateTime.Today;
                string query = "insert into tbl_out (kd_item, jenis, tgl_keluar, jumlah) values ('" + kodeKain + "','" + comboBox1.Text + "','"+ today.ToString("yyyy-MM-dd hh:mm:ss") + "','" + stock + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn_user);                
                cmd.ExecuteNonQuery();
                string query2 = "SELECT * FROM tbl_kain where kd_kain='"+ kodeKain + "' and stok='"+ stock + "'" ;
                var sql = new MySqlCommand(query2, conn_user);
                MySqlDataReader read = sql.ExecuteReader();
                if (read.Read())
                {
                    conn_user.Close();
                    conn_user.Open();
                    string query3 = "delete from tbl_kain where kd_kain='" + kodeKain + "'";
                    var sql2 = new MySqlCommand(query3, conn_user);
                    sql2.ExecuteNonQuery();
                }
                else
                {
                    conn_user.Close();
                    conn_user.Open();
                    string query3 = "SELECT * FROM tbl_kain where kd_kain='" + kodeKain + "'";                    
                    var sql2 = new MySqlCommand(query3, conn_user);
                    MySqlDataReader read2 = sql2.ExecuteReader();
                    if (read2.Read())
                    {
                        Int32 jumlah = Int32.Parse(read2.GetString("stok")) - Int32.Parse(stock);
                        string query4 = "update tbl_kain set stok='" + jumlah + "' where kd_kain='" + kodeKain + "'";
                        var sql3 = new MySqlCommand(query4, conn_user);
                        conn_user.Close();
                        conn_user.Open();
                        sql3.ExecuteNonQuery();
                    }
                }

            }

            dataGridView2.Rows.Clear();
            button4.Enabled = true;
            button5.Enabled = false;
            button1.Enabled = false;
            dataGridView1.Enabled = true;
            dataGridView2.Enabled = false;
            conn_user.Close();            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
