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
    public partial class invalid_AppoList : Form
    {
        public invalid_AppoList()
        {
            InitializeComponent();
        }

        private void print_Click(object sender, EventArgs e)
        {
            Program.getPDF(this.dataGridView1);
        }

        private void invalid_AppoList_Load(object sender, EventArgs e)
        {
            if (Program.roleName == "Patient")
            {
                SqlConnection conn = Program.getConn();
                SqlCommand cmd2 = new SqlCommand("SELECT Date, Time, Comment, Status, DoctorName FROM Appointment WHERE PatientId = " + Program.loginId + " AND (Status = 'Closed' OR Status = 'Cancelled') ORDER BY Id DESC", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[4].HeaderText = "Doctor Name";
            }
            else if (Program.roleName == "Doctor")
            {
                SqlConnection conn = Program.getConn();
                SqlCommand cmd2 = new SqlCommand("SELECT Date, Time, Comment, Status FROM Appointment WHERE Doctor = '" + Program.userName + "' AND (Status = 'Closed' OR Status = 'Cancelled') ORDER BY Id DESC", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
            else if (Program.roleName == "Staff")
            {
                SqlConnection conn = Program.getConn();
                SqlCommand cmd2 = new SqlCommand("SELECT Date, Time, Comment, Status, Doctor FROM Appointment WHERE Status = 'Closed' OR Status = 'Cancelled' ORDER BY Id DESC", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (Program.roleName == "Patient")
            {
                appoListPatient aL = new appoListPatient();
                this.Hide();
                aL.Show();
            }
            else if (Program.roleName == "Staff")
            {
                appoListStaff aL = new appoListStaff();
                this.Hide();
                aL.Show();
            }
            else if (Program.roleName == "Doctor")
            {
                appoListDoctor aL = new appoListDoctor();
                this.Hide();
                aL.Show();
            }
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
