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
using System.Configuration;
using System.IO;

namespace InventoryTekstil.Report
{
    public partial class ReportIn : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=inventory_tekstil");
        public string jenis = "kain";
        public ReportIn()
        {
            InitializeComponent();
        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        public void loadDataset()
        {
            try
            {
                conn.Open();
                string query = "";
                if (jenis == "kain"){
                    query = "Select tbl_in.tgl_masuk, tbl_jenis_kain.nama, tbl_in.stok, tbl_kain.lot, " +
                        "tbl_kain.gramasi, tbl_kain.panjang " +
                        "FROM tbl_in, tbl_kain, tbl_jenis_kain" +
                        " WHERE tbl_in.jenis = 'kain' " +
                        " and tbl_in.kd_item = tbl_kain.kd_kain AND tbl_kain.kd_jenis = tbl_jenis_kain.kd_jenis";

                } else if (jenis == "semical")
                {
                    query = "SELECT tbl_in.tgl_masuk, tbl_semical.kd_jenis, tbl_semical.supplier, " +
                        "tbl_semical.harga_beli, tbl_semical.no_lot, tbl_in.stok " +
                        "FROM tbl_in, tbl_semical " +
                        "WHERE tbl_in.jenis = 'semical' AND tbl_in.kd_item = tbl_semical.no_barang";
                } else if (jenis == "benang")
                {
                    query = "SELECT tbl_in.tgl_masuk, tbl_benang.jenis, tbl_benang.supplier, tbl_benang.harga_beli," +
                        " tbl_benang.no_lot, tbl_in.stok " +
                        "FROM tbl_in, tbl_benang " +
                        "WHERE tbl_in.jenis = 'benang' AND tbl_in.kd_item = tbl_benang.no_barang";
                }
                
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error : " + ex.Message);
            }
        }

        private void ReportIn_Load(object sender, EventArgs e)
        {
            loadDataset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }
    }
}
