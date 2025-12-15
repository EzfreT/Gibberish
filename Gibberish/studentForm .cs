using System;
using System.Windows.Forms;

namespace Gibberish
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentLog studentLog = new StudentLog();
            studentLog.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            subjects.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            section.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enrollment enrollment = new enrollment();
            enrollment.Show();
        }
    }
}
