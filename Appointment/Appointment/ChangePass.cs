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
    public partial class changePass : Form
    {
        public changePass()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (Program.roleName == "Patient")
            {
                patientHome pH = new patientHome();
                this.Hide();
                pH.Show();
            }
            else if (Program.roleName == "Doctor")
            {
                doctorHome dH = new doctorHome();
                this.Hide();
                dH.Show();
            }
            else if (Program.roleName == "Staff")
            {
                staffHome sH = new staffHome();
                this.Hide();
                sH.Show();
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            if ((this.confirmPassword.Text == "") || (this.password.Text == ""))
            {
                MessageBox.Show("Please, fill all the fields");
            }
            else if (this.confirmPassword.Text != this.password.Text)
            {
                MessageBox.Show("Password didn't match.");
                this.confirmPassword.Focus();
            }
            else
            {
                if (Program.roleName == "Patient")
                {                 
                    string query = "UPDATE Patient SET Password = @one WHERE Username = @two";
                    SqlConnection conn = Program.getConn();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@one", this.password.Text);
                    cmd.Parameters.AddWithValue("@two", Program.userName);
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
                        MessageBox.Show("Password Changed successfully");
                        patientHome pH = new patientHome();
                        this.Hide();
                        pH.Show();
                    }
                }
                else if (Program.roleName == "Doctor")
                {
                    string query = "UPDATE Doctor SET Password = @one WHERE Username = @two";
                    SqlConnection conn = Program.getConn();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@one", this.password.Text);
                    cmd.Parameters.AddWithValue("@two", Program.userName);
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
                        MessageBox.Show("Password Changed successfully");
                        doctorHome dH = new doctorHome();
                        this.Hide();
                        dH.Show();
                    }
                }
                else if (Program.roleName == "Staff")
                {
                    string query = "UPDATE Staff SET Password = @one WHERE Username = @two";
                    SqlConnection conn = Program.getConn();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@one", this.password.Text);
                    cmd.Parameters.AddWithValue("@two", Program.userName);
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
                        MessageBox.Show("Password Changed successfully");
                        staffHome sH = new staffHome();
                        this.Hide();
                        sH.Show();
                    }
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
