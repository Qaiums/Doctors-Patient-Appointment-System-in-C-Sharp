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
    public partial class editApp : Form
    {
        public editApp()
        {
            InitializeComponent();
            if (Program.roleName == "Staff")
            {
                this.comments.Visible = false;
                this.label4.Visible = false;
                this.submit.Location = new System.Drawing.Point(154, 230);
                this.cancel.Location = new System.Drawing.Point(414, 230);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Program.appId = -1;
            if (Program.roleName == "Patient") {
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
            
        }

        private void editApp_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Program.getConn();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Date, Time, Comment FROM Appointment WHERE id = " + Program.appId, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "dates");
            foreach (DataRow row in ds.Tables["dates"].Rows)
            {
                this.dateTimePicker.Value = Convert.ToDateTime(row["Date"].ToString());
                this.dateTimePicker1.Value = Convert.ToDateTime(row["Time"].ToString());
                this.comments.Text = row["Comment"].ToString();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (Program.roleName == "Patient")
            {
                if ((this.comments.Text == ""))
                {
                    MessageBox.Show("Please, add your symptoms or preferred doctor details if any");
                    this.comments.Focus();
                }
                else
                {
                    string query = "UPDATE Appointment SET Date = @one, Time = @two, Comment = @three, Status = @four, DoctorName = @five WHERE Id = " + Program.appId;
                    SqlConnection conn = Program.getConn();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@one", this.dateTimePicker.Value.ToLongDateString());
                    cmd.Parameters.AddWithValue("@two", this.dateTimePicker1.Value.ToString("hh:mm tt"));
                    cmd.Parameters.AddWithValue("@three", this.comments.Text);
                    cmd.Parameters.AddWithValue("@four", "New");
                    cmd.Parameters.AddWithValue("@five", "Not Assigned Yet");
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
                        MessageBox.Show("Appointmnt successfully updated");
                        appoListPatient H1 = new appoListPatient();
                        Program.appId = -1;
                        this.Hide();
                        H1.Show();
                    }
                }
            }
            else if (Program.roleName == "Staff")
            {
                
                string query = "UPDATE Appointment SET Date = @one, Time = @two, Status = @three WHERE Id = " + Program.appId;
                SqlConnection conn = Program.getConn();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@one", this.dateTimePicker.Value.ToLongDateString());
                cmd.Parameters.AddWithValue("@two", this.dateTimePicker1.Value.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@three", "Confirmed");
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
                    MessageBox.Show("Appointmnt successfully updated");
                    appoListStaff H1 = new appoListStaff();
                    Program.appId = -1;
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
