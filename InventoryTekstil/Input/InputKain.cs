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
   
    public partial class InputKain : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=inventory_tekstil");

        public InputKain()
        {
            InitializeComponent();
            
        }

        private void InputKain_Load(object sender, EventArgs e)
        {
            loadJenisKain();
        }

        private void loadJenisKain()
        {
            conn.Open();
            try
            {
                string query = "SELECT * FROM tbl_jenis_kain";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "tbl_jenis_kain");
                jenisKainComboBox.DisplayMember = "nama";
                jenisKainComboBox.ValueMember = "kd_jenis";
                jenisKainComboBox.DataSource = ds.Tables["tbl_jenis_kain"];
            } catch(Exception ex)
            {
                MessageBox.Show("Error Occured!");
            }
           
            
            conn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string kodeJenis = "";
            if (jenisKainComboBox.SelectedItem != null)
            {
                DataRowView drv = jenisKainComboBox.SelectedItem as DataRowView;
                kodeJenis = drv.Row["kd_jenis"].ToString();
            }
            string lot = tbLot.Text.ToString();
            string kodeKain = checkFromKain(kodeJenis, lot);
            string gramasi = tbGramasi.Text.ToString();
            string stok = tbStok.Text.ToString();
            string panjang = tbPanjang.Text.ToString();

            if (kodeKain != null)
            {
                kodeKain = updateKain(kodeKain, stok);
            }
            else
            {
                kodeKain = insertKain(kodeJenis, lot, panjang, gramasi, stok);
            }

            Utils.DatabaseHelper db = new Utils.DatabaseHelper();
            db.insertTblIn(kodeKain, "kain", stok);

            MessageBox.Show("Data kain berhasil disimpan");
        }
        
        private string insertKain(string kodeJenis, string lot, string panjang, string gramasi, string stok)
        {
            
            // insert
            conn.Open();
            string query = "INSERT INTO tbl_kain (kd_jenis, lot, panjang, gramasi, stok )" +
                " VALUES('" + kodeJenis + "', '" + lot + "'" +
                ", '" + panjang + "','" + gramasi + "','" + stok + "')";

            // create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //Execute command
            cmd.ExecuteNonQuery();
            conn.Close();
            return getLastKode();
        }
        private string updateKain(string kodeKain, string stok)
        {

            // insert
            conn.Open();
            string query = "UPDATE tbl_kain SET stok = stok + '"+ stok +"' WHERE kd_kain = '" + kodeKain + "'";

            // create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //Execute command
            cmd.ExecuteNonQuery();
            conn.Close();
            
            return kodeKain;
        }
        private string getLastKode()
        {
            Utils.DatabaseHelper db = new Utils.DatabaseHelper();
            return db.getLastId("tbl_kain", "kd_kain");
        }
        private string checkFromKain(string kodeJenis, string lot) { 
       
            string kodeKain = null;
            try
            {
                conn.Open();
                string query = "SELECT * FROM tbl_kain where kd_jenis ='" + kodeJenis + "' AND lot ='" + lot + "'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    kodeKain = reader["kd_kain"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured!");
            }


            conn.Close();
            return kodeKain;

  
        }

    }
}
