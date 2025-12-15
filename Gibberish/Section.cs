using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gibberish
{
    public partial class Section : Form
    {
        string connStr = "server=localhost;userid=root;password=root;database=sms;";

        public Section()
        {
            InitializeComponent();

            // Wire events
            bttnSave.Click += bttnSave_Click;
            bttnUpdate.Click += bttnUpdate_Click;
            bttnDelete.Click += bttnDelete_Click;
            bttnNew.Click += bttnNew_Click;
            bttnDisplay.Click += bttnDisplay_Click;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM sectionreg", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO sectionreg (section_name, student_id) VALUES (@s, @st)", conn);

                cmd.Parameters.AddWithValue("@s", textBoxSectionName.Text);
                cmd.Parameters.AddWithValue("@st", textBoxStudentID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved!");
                LoadData();
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE sectionreg SET section_name=@s, student_id=@st WHERE section_id=@id", conn);

                cmd.Parameters.AddWithValue("@id", textBoxID.Text);
                cmd.Parameters.AddWithValue("@s", textBoxSectionName.Text);
                cmd.Parameters.AddWithValue("@st", textBoxStudentID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated!");
                LoadData();
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM sectionreg WHERE section_id=@id", conn);

                cmd.Parameters.AddWithValue("@id", textBoxID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted!");
                LoadData();
            }
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxSectionName.Clear();
            textBoxStudentID.Clear();
        }

        private void bttnDisplay_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBoxID.Text = row.Cells["section_id"].Value.ToString();
                textBoxSectionName.Text = row.Cells["section_name"].Value.ToString();
                textBoxStudentID.Text = row.Cells["student_id"].Value.ToString();
            }
        }
    }
}
