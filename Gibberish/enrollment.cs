using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gibberish
{
    public partial class enrollment : Form
    {
        MySqlConnection conn = new MySqlConnection(
            "server=localhost;userid=root;password=root;database=sms;"
        );

        public enrollment()
        {
            InitializeComponent();
            LoadData();
        }

        // ================= LOAD DATA =================
        void LoadData()
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(
                    "SELECT * FROM enrollment", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        // ================= SAVE =================
        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO enrollment (student_name, section, enrollment_date) " +
                    "VALUES (@name, @section, @date)", conn);

                cmd.Parameters.AddWithValue("@name", textBoxStudentName.Text);
                cmd.Parameters.AddWithValue("@section", textBoxSection.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Saved Successfully!");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        // ================= UPDATE =================
        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE enrollment SET student_name=@name, section=@section, " +
                    "enrollment_date=@date WHERE enrollment_id=@id", conn);


                cmd.Parameters.AddWithValue("@id", textEnrollmentID.Text);
                cmd.Parameters.AddWithValue("@name", textBoxStudentName.Text);
                cmd.Parameters.AddWithValue("@section", textBoxSection.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Updated Successfully!");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        // ================= DELETE =================
        private void bttnDeleted_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM enrollment WHERE enrollment_id=@id", conn);

                cmd.Parameters.AddWithValue("@id", textEnrollmentID.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Deleted Successfully!");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        // ================= DISPLAY =================
        private void bttnDisplay_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // ================= NEW =================
        private void bttnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // ================= GRID CLICK =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textEnrollmentID.Text = row.Cells["enrollment_id"].Value.ToString();
                textBoxStudentName.Text = row.Cells["student_name"].Value.ToString();
                textBoxSection.Text = row.Cells["section"].Value.ToString();
                dateTimePicker1.Value =
                    Convert.ToDateTime(row.Cells["enrollment_date"].Value);
            }
        }

        // ================= CLEAR =================
        void ClearFields()
        {
            textEnrollmentID.Clear();
            textBoxStudentName.Clear();
            textBoxSection.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textEnrollmentID.Text = row.Cells["enrollment_id"].Value.ToString();
                textBoxStudentName.Text = row.Cells["student_name"].Value.ToString();
                textBoxSection.Text = row.Cells["section"].Value.ToString();
                dateTimePicker1.Value =
                    Convert.ToDateTime(row.Cells["enrollment_date"].Value);
            }
            }
        }
    }
