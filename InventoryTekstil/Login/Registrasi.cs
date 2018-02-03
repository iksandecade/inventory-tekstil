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

namespace InventoryTekstil.Login
{
    public partial class Registrasi : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; database=inventory_tekstil");
        String selectedId = "";
        public Registrasi()
        {
            InitializeComponent();
            loadDataset();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void loadDataset()
        {
            try
            {
                conn.Open();
                string query = "Select * from user";
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
        public void clearForm()
        {
            firstNameTb.Text = "";
            lastNameTb.Text = "";
            usernameTb.Text = "";
            passwordTb.Text = "";
            roleCb.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO user (username, firstname, lastname, password, role )" +
                " VALUES('" + usernameTb.Text.ToString() + "', '" + firstNameTb.Text.ToString() + "'" +
                ", '" + lastNameTb.Text.ToString() + "','" + passwordTb.Text.ToString() + "','" + roleCb.SelectedItem.ToString() + "')";

            // create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //Execute command
            cmd.ExecuteNonQuery();
            conn.Close();

            clearForm();

            loadDataset();
            MessageBox.Show("Data berhasil di simpan");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE user SET " +
                "username = '" + usernameTb.Text.ToString() + "'" +
               ", firstname = '" + firstNameTb.Text.ToString() + "', lastname = '" + lastNameTb.Text.ToString() + "', " +
               "password = '" + passwordTb.Text.ToString() + "', role = '" + roleCb.SelectedItem.ToString() + "' WHERE user.user_id = '" + selectedId + "'";
            cmd.ExecuteNonQuery();

            conn.Close();

            clearForm();

            loadDataset();
            MessageBox.Show("Data berhasil di update");
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];

            selectedId = selectedRow.Cells["user_id"].Value.ToString();
            usernameTb.Text = selectedRow.Cells["username"].Value.ToString();

            firstNameTb.Text = selectedRow.Cells["firstname"].Value.ToString();
            lastNameTb.Text = selectedRow.Cells["lastname"].Value.ToString();
            roleCb.Text = selectedRow.Cells["role"].Value.ToString();
            passwordTb.Text = selectedRow.Cells["password"].Value.ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin menghapus data " + usernameTb.Text.ToString() + "?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM user WHERE user.user_id = '" + selectedId + "'";
                cmd.ExecuteNonQuery();

                conn.Close();

                clearForm();

                loadDataset();

                MessageBox.Show("Data berhasil di hapus");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
