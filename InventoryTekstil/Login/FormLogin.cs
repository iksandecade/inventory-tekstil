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
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=inventory_tekstil");

        FormDashboard mainForm;
        public Form1()
        {
            InitializeComponent();
            mainForm = new FormDashboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Select * from user Where password ='" + passwordTb.Text.ToString() + "' AND username = '" + usernameTb.Text.ToString()
                + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string firstName = reader.GetString(2);
                string lastName = reader.GetString(3);
                string role = reader.GetString(5);

                Utils.Session.role = role;
                Utils.Session.username = usernameTb.Text.ToString();

                reader.Close();

                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
            conn.Close();
        }
    }
}
