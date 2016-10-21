using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Appointment
{
    public partial class doctorsList : Form
    {
        private void SizeAllRows(Object sender, EventArgs e)
        {
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        public doctorsList()
        {
            InitializeComponent();
        }

        private void doctorsList_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Program.getConn();
            SqlCommand cmd2 = new SqlCommand("SELECT Fullname, Username, Speciality, Schedule FROM Doctor", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            staffHome sH = new staffHome();
            this.Hide();
            sH.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            home H1 = new home();
            Program.userName = "";
            Program.roleName = "";
            Program.loginId = -1;
            Program.appId = -1;
            Program.doctorUsername = "";
            Program.doctorName = "";
            this.Hide();
            H1.Show();
        }
    }
}
