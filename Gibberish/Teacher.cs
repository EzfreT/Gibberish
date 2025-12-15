using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gibberish
{
    public partial class Teacher : Form
    {
        string connStr = "server=localhost;userid=root;password=root;database=sms;";

        public Teacher()
        {
            InitializeComponent();
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    string query = "SELECT * FROM teacher";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ================= SAVE =================
        private void bttnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO teacher 
                                    (teacher_name, gender, phone, subject_department)
                                    VALUES (@name, @gender, @phone, @subject)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", textBoxTeacherName.Text);
                    cmd.Parameters.AddWithValue("@gender", textBoxgGender.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@subject", textBoxSubDep.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher record saved!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ================= UPDATE =================
        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE teacher 
                                    SET teacher_name=@name,
                                        gender=@gender,
                                        phone=@phone,
                                        subject_department=@subject
                                    WHERE teacher_id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", textBoxID.Text);
                    cmd.Parameters.AddWithValue("@name", textBoxTeacherName.Text);
                    cmd.Parameters.AddWithValue("@gender", textBoxgGender.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                    cmd.Parameters.AddWithValue("@subject", textBoxSubDep.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher record updated!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ================= DELETE =================
        private void bttnDeleted_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM teacher WHERE teacher_id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", textBoxID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher record deleted!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ================= NEW / CLEAR =================
        private void bttnNew_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxTeacherName.Clear();
            textBoxgGender.Clear();
            textBoxPhone.Clear();
            textBoxSubDep.Clear();
        }

        // ================= DISPLAY =================
        private void bttnDisplay_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // ================= GRID CLICK =================
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBoxID.Text = row.Cells["teacher_id"].Value.ToString();
                textBoxTeacherName.Text = row.Cells["teacher_name"].Value.ToString();
                textBoxgGender.Text = row.Cells["gender"].Value.ToString();
                textBoxPhone.Text = row.Cells["phone"].Value.ToString();
                textBoxSubDep.Text = row.Cells["subject_department"].Value.ToString();
            }
        }

        private void textBoxTeacherID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
