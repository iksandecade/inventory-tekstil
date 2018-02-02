using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventoryTekstil.Utils
{
    class DatabaseHelper
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=inventory_tekstil");

        public string getLastId(string table, string idColumnName)
        {
            string kodeKain = null;
            try
            {
                conn.Open();
                string query = "SELECT * FROM "+ table +" ORDER_BY "+ idColumnName +" DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    kodeKain = reader[idColumnName].ToString();

                }
            }
            catch (Exception ex)
            {

            }
            conn.Close();
            return kodeKain;
        }

        public void insertTblIn(string kodeItem, string jenis, string stok)
        {
            conn.Open();
            string query = "INSERT INTO tbl_in (kd_item, jenis, stok)" +
                " VALUES('" + kodeItem + "', '" + jenis + "','" + stok + "')";

            // create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //Execute command
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
