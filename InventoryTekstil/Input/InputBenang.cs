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

namespace InventoryTekstil.Input
{
    public partial class InputBenang : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=inventory_tekstil");

        public InputBenang()
        {
            InitializeComponent();
        }

        private void clearData() {
            jenisComboBox.Text = "";
            tbSupplier.Text = "";
            tbHargaBeli.Text = "";
            tbLot.Text = "";
            tbStok.Text = "";

            loadDataset();
        }

        private void InputBenang_Load(object sender, EventArgs e)
        {
            loadDataset();
        }

        public void loadDataset()
        {
            try
            {
                conn.Open();
                string query = "Select * from tbl_benang";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    benangGridView.DataSource = ds.Tables[0];
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error : " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string jenis = jenisComboBox.SelectedItem.ToString();
            string lot = tbLot.Text.ToString();
            string kodeSemical = checkFromBenang(jenis, lot);
            string stok = tbStok.Text.ToString();
            string supplier = tbSupplier.Text.ToString();
            string hargaBeli = tbHargaBeli.Text.ToString();

            if (kodeSemical != null)
            {
                kodeSemical = updateBenang(kodeSemical, stok);
            }
            else
            {
                kodeSemical = insertBenang(jenis, lot, supplier, hargaBeli, stok);
            }

            Utils.DatabaseHelper db = new Utils.DatabaseHelper();
            db.insertTblIn(kodeSemical, "benang", stok);

            MessageBox.Show("Data benang berhasil disimpan");
            clearData();
        }

        private string insertBenang(string jenis, string lot, string supplier, string hargaBeli, string stok)
        {
            conn.Open();
            string query = "INSERT INTO tbl_benang (jenis, supplier, harga_beli, no_lot, stok )" +
                " VALUES('" + jenis + "', '" + supplier + "','" + hargaBeli + "','" + lot + "', '" + stok + "')";

            // create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //Execute command
            cmd.ExecuteNonQuery();
            conn.Close();
            return getLastKode();
        }
        private string updateBenang(string kodeBenang, string stok)
        {

            // insert
            conn.Open();
            string query = "UPDATE tbl_benang SET stok = stok + '" + stok + "' WHERE no_barang = '" + kodeBenang + "'";

            // create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //Execute command
            cmd.ExecuteNonQuery();
            conn.Close();

            return kodeBenang;
        }
        private string getLastKode()
        {
            Utils.DatabaseHelper db = new Utils.DatabaseHelper();
            return db.getLastId("tbl_benang", "no_barang");
        }
        private string checkFromBenang(string jenis, string lot)
        {

            string kodeBenang = null;
            try
            {
                conn.Open();
                string query = "SELECT * FROM tbl_benang where jenis ='" + jenis + "' AND no_lot ='" + lot + "'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    kodeBenang = reader["no_barang"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured!");
            }


            conn.Close();
            return kodeBenang;


        }
    }


}
