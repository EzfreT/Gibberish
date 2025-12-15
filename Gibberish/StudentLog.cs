using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gibberish
{
    public partial class StudentLog : Form
    {
        // 🔗 MySQL Connection
        string connectionString =
            "server=localhost;userid=root;password=root;database=sms";

        int selectedStudentId = 0;

        public StudentLog()
        {
            InitializeComponent();
        }

        // ======================
        // SAVE STUDENT
        // ======================
        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateGender()) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO studentreg
                                    (first_name, last_name, email, gender, date_of_birth)
                                    VALUES
                                    (@fname, @lname, @email, @gender, @dob)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@fname", txtboxFirstName.Text);
                    cmd.Parameters.AddWithValue("@lname", textboxLastName.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@gender", textBoxGender.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student saved successfully!");
                    LoadStudents();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ======================
        // DISPLAY STUDENTS
        // ======================
        private void bttnDisplay_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter da =
                    new MySqlDataAdapter("SELECT * FROM studentreg", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // ======================
        // CLICK ROW → LOAD DATA
        // ======================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedStudentId = Convert.ToInt32(row.Cells["id"].Value);
                txtboxFirstName.Text = row.Cells["first_name"].Value.ToString();
                textboxLastName.Text = row.Cells["last_name"].Value.ToString();
                textBoxEmail.Text = row.Cells["email"].Value.ToString();
                textBoxGender.Text = row.Cells["gender"].Value.ToString();
                dateTimePicker1.Value =
                    Convert.ToDateTime(row.Cells["date_of_birth"].Value);
            }
        }

        // ======================
        // UPDATE STUDENT
        // ======================
        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            if (!ValidateGender()) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE studentreg SET
                                first_name=@fname,
                                last_name=@lname,
                                email=@email,
                                gender=@gender,
                                date_of_birth=@dob
                                WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@fname", txtboxFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", textboxLastName.Text);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@gender", textBoxGender.Text.ToUpper());
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@id", selectedStudentId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student updated!");
                LoadStudents();
                ClearFields();
            }
        }

        // ======================
        // DELETE STUDENT
        // ======================
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            if (MessageBox.Show("Delete this student?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd =
                        new MySqlCommand("DELETE FROM studentreg WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", selectedStudentId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student deleted!");
                LoadStudents();
                ClearFields();
            }
        }

        // ======================
        // NEW / CLEAR
        // ======================
        private void bttnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtboxFirstName.Clear();
            textboxLastName.Clear();
            textBoxEmail.Clear();
            textBoxGender.Clear();
            dateTimePicker1.Value = DateTime.Now;
            selectedStudentId = 0;
        }

        // ======================
        // GENDER VALIDATION
        // ======================
        private bool ValidateGender()
        {
            string gender = textBoxGender.Text.ToUpper();

            if (gender != "M" && gender != "F")
            {
                MessageBox.Show("Gender must be 'M' or 'F'");
                return false;
            }
            return true;
        }
    }
}
