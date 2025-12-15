using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gibberish
{
    public partial class Form1 : Form
    {
        string connStr = "server=localhost;user=root;password=root;database=sms;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM login WHERE Username=@user AND Password=@pass";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Login Successful!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirect to Student form
                        this.Hide();
                        Student studentForm = new Student();
                        studentForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
    }
}
