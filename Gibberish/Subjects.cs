using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gibberish
{
    public partial class Subjects : Form
    {
        // 🔗 MySQL Connection String
        string connectionString =
            "server=localhost;userid=root;password=root;database=sms";

        int selectedSubjectId = 0;

        public Subjects()
        {
            InitializeComponent();
        }

        // =========================
        // SAVE SUBJECT
        // =========================
        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSubjectName.Text))
            {
                MessageBox.Show("Please enter subject name.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query =
                        "INSERT INTO subject (subject_name) VALUES (@name)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", textBoxSubjectName.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Subject saved successfully!");
                    LoadSubjects();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // =========================
        // DISPLAY SUBJECTS
        // =========================
        private void bttnDisplay_Click(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                MySqlDataAdapter da =
                    new MySqlDataAdapter("SELECT * FROM subject", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        // =========================
        // CLICK ROW → LOAD DATA
        // =========================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedSubjectId = Convert.ToInt32(row.Cells["subject_id"].Value);
                textBoxID.Text = selectedSubjectId.ToString();
                textBoxSubjectName.Text = row.Cells["subject_name"].Value.ToString();
            }
        }

        // =========================
        // UPDATE SUBJECT
        // =========================
        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == 0)
            {
                MessageBox.Show("Select a subject first.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                    "UPDATE subject SET subject_name=@name WHERE subject_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", textBoxSubjectName.Text);
                cmd.Parameters.AddWithValue("@id", selectedSubjectId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Subject updated!");
                LoadSubjects();
                ClearFields();
            }
        }

        // =========================
        // DELETE SUBJECT
        // =========================
        private void bttnDeleted_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == 0)
            {
                MessageBox.Show("Select a subject first.");
                return;
            }

            if (MessageBox.Show("Delete this subject?",
                "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    MySqlCommand cmd =
                        new MySqlCommand(
                            "DELETE FROM subject WHERE subject_id=@id", conn);

                    cmd.Parameters.AddWithValue("@id", selectedSubjectId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Subject deleted!");
                LoadSubjects();
                ClearFields();
            }
        }

        // =========================
        // NEW / CLEAR
        // =========================
        private void bttnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxID.Clear();
            textBoxSubjectName.Clear();
            selectedSubjectId = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
