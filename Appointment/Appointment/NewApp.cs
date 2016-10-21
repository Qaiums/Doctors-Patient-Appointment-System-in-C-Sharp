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
    public partial class newApp : Form
    {
        public DateTime MinDate { get; set; }

        public newApp()
        {
            InitializeComponent();
            this.dateTimePicker.MinDate = DateTime.Today.AddDays(1);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            patientHome pH = new patientHome();
            this.Hide();
            pH.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if ((this.comments.Text == ""))
            {
                MessageBox.Show("Please, add your symptoms or preferred doctor details if any");
                this.comments.Focus();
            }
            else
            {
                string query = "INSERT INTO Appointment (Date, Time, Comment, PatientId, Status, DoctorName) VALUES (@one, @two, @three, @four, @five, @six)";
                SqlConnection conn = Program.getConn();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand cmd2 = new SqlCommand("SELECT Id FROM Patient WHERE Username='" + Program.userName + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Parameters.AddWithValue("@one", this.dateTimePicker.Value.ToLongDateString());
                cmd.Parameters.AddWithValue("@two", this.dateTimePicker1.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@three", this.comments.Text);
                cmd.Parameters.AddWithValue("@four", dt.Rows[0][0].ToString());
                cmd.Parameters.AddWithValue("@five", "New");
                cmd.Parameters.AddWithValue("@six", "Not Assigned Yet");
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException exception)
                {
                    throw exception;
                }
                finally
                {
                    conn.Close();
                    MessageBox.Show("Appointmnt submission Successful");
                    patientHome H1 = new patientHome();
                    this.Hide();
                    H1.Show();                    
                }
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
