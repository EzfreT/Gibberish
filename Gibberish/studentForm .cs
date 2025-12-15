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
    }
}
