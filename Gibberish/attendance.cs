using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gibberish
{
    public partial class attendance : Form
    {
        MySqlConnection conn = new MySqlConnection(
            "server=localhost;userid=root;password=root;database=sms;"
        );

        public attendance()
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
                    "SELECT * FROM attendance", conn);
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
            if (string.IsNullOrWhiteSpace(textBoxStudName.Text) ||
                string.IsNullOrWhiteSpace(textBoxStat.Text))
            {
                MessageBox.Show("Student Name and Status are required!");
                return;
            }

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO attendance (student_name, status, attendance_date) " +
                    "VALUES (@name, @status, CURDATE())", conn);

                cmd.Parameters.AddWithValue("@name", textBoxStudName.Text);
                cmd.Parameters.AddWithValue("@status", textBoxStat.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Attendance Saved!");
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
            if (string.IsNullOrWhiteSpace(textBoxAID.Text))
            {
                MessageBox.Show("Select a record first!");
                return;
            }

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE attendance SET student_name=@name, status=@status " +
                    "WHERE attendance_id=@id", conn);

                cmd.Parameters.AddWithValue("@id", textBoxAID.Text);
                cmd.Parameters.AddWithValue("@name", textBoxStudName.Text);
                cmd.Parameters.AddWithValue("@status", textBoxStat.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Attendance Updated!");
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
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAID.Text))
            {
                MessageBox.Show("Select a record first!");
                return;
            }

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM attendance WHERE attendance_id=@id", conn);

                cmd.Parameters.AddWithValue("@id", textBoxAID.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Attendance Deleted!");
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

                textBoxAID.Text = row.Cells["attendance_id"].Value.ToString();
                textBoxStudName.Text = row.Cells["student_name"].Value.ToString();
                textBoxStat.Text = row.Cells["status"].Value.ToString();
            }
        }

        // ================= CLEAR =================
        void ClearFields()
        {
            textBoxAID.Clear();
            textBoxStudName.Clear();
            textBoxStat.Clear();
        }
    }
}
