﻿using System;
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
    public partial class InputSemical : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=inventory_tekstil");

        public InputSemical()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputSemical_Load(object sender, EventArgs e)
        {
            loadJenisSemical();
        }




        private void loadJenisSemical()
        {
            conn.Open();
            try
            {
                string query = "SELECT * FROM tbl_jenis_semical";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tbl_jenis_semical");
                jenisComboBox.DisplayMember = "nama";
                jenisComboBox.ValueMember = "kd_jenis";
                jenisComboBox.DataSource = ds.Tables["tbl_jenis_semical"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured!");
            }


            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
                string kodeJenis = "";
                if (jenisComboBox.SelectedItem != null)
                {
                    DataRowView drv = jenisComboBox.SelectedItem as DataRowView;
                    kodeJenis = drv.Row["kd_jenis"].ToString();
                }
                string lot = tbLot.Text.ToString();
                string kodeSemical = checkFromSemical(kodeJenis, lot);
                string kuantitas = tbQty.Text.ToString();
                string stok = tbStok.Text.ToString();
                string supplier = tbSupplier.Text.ToString();
                string hargaBeli = tbHargaBeli.Text.ToString();

            if (kodeSemical != null)
                {
                 kodeSemical = updateSemical(kodeSemical, stok);
                }
                else
                {
                kodeSemical = insertSemical(kodeJenis, lot, kuantitas, supplier, hargaBeli, stok);
                }

                Utils.DatabaseHelper db = new Utils.DatabaseHelper();
                db.insertTblIn(kodeSemical, "semical", stok);

                MessageBox.Show("Data semical berhasil disimpan");
            }

            private string insertSemical(string kodeJenis, string lot, string kuantitas, string supplier, string hargaBeli, string stok)
            {
                conn.Open();
                string query = "INSERT INTO tbl_semical (kd_jenis, kuantitas, supplier, harga_beli, no_lot, stok )" +
                    " VALUES('" + kodeJenis + "', '" + kuantitas + "'" +
                    ", '" + supplier + "','" + hargaBeli + "','" + lot + "', '"+ stok +"')";

                // create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //Execute command
                cmd.ExecuteNonQuery();
                conn.Close();
                return getLastKode();
            }
            private string updateSemical(string kodeSemical, string stok)
            {

                // insert
                conn.Open();
                string query = "UPDATE tbl_semical SET stok = stok + '" + stok + "' WHERE no_barang = '" + kodeSemical + "'";

                // create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //Execute command
                cmd.ExecuteNonQuery();
                conn.Close();

                return kodeSemical;
            }
            private string getLastKode()
            {
                Utils.DatabaseHelper db = new Utils.DatabaseHelper();
                return db.getLastId("tbl_semical", "no_barang");
            }
            private string checkFromSemical(string kodeJenis, string lot)
            {

                string kodeSemical = null;
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_semical where kd_jenis ='" + kodeJenis + "' AND no_lot ='" + lot + "'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        kodeSemical = reader["no_barang"].ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured!");
                }


                conn.Close();
                return kodeSemical;


            }
        }
}
