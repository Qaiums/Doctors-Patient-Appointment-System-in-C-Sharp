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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if ((this.username.Text == "") || (this.password.Text == ""))
            {
                MessageBox.Show("Please, fill all the fields");
            }
            else
            {
                if (this.role.SelectedItem.ToString() == "Patient") {
                    SqlConnection conn = Program.getConn();
                    SqlCommand cmd = new SqlCommand("SELECT Id, Username, Password FROM Patient WHERE Username='" + this.username.Text + "'and Password='" + this.password.Text + "'", conn);  
                    SqlDataAdapter da = new SqlDataAdapter(cmd);  
                    DataTable dt = new DataTable();  
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)  
                    {
                        Program.loginId = dt.Rows[0].Field<int>(0);
                        Program.userName = this.username.Text.ToString();
                        Program.roleName = "Patient";                        
                        patientHome H1 = new patientHome();
                        this.Hide();
                        H1.Show();
                    }  
                    else {  
                        MessageBox.Show("Invalid Login! Please enter correct username and password");  
                    }  
                    conn.Close();
                }
                else if (this.role.SelectedItem.ToString() == "Staff") {
                    SqlConnection conn = Program.getConn();
                    SqlCommand cmd = new SqlCommand("SELECT Id, Username, Password FROM Staff WHERE Username='" + this.username.Text + "'and Password='" + this.password.Text + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0) {
                        Program.loginId = dt.Rows[0].Field<int>(0);
                        Program.userName = this.username.Text.ToString();
                        Program.roleName = "Staff";                        
                        staffHome H1 = new staffHome();
                        this.Hide();
                        H1.Show();
                    }
                    else {
                        MessageBox.Show("Invalid Login! Please check username and password");
                    }
                    conn.Close();
                }
                else if (this.role.SelectedItem.ToString() == "Doctor") {
                    SqlConnection conn = Program.getConn();
                    SqlCommand cmd = new SqlCommand("SELECT Id, Username, Password FROM Doctor WHERE Username='" + this.username.Text + "'and Password='" + this.password.Text + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Program.loginId = dt.Rows[0].Field<int>(0);
                        Program.userName = this.username.Text.ToString();
                        Program.roleName = "Doctor";                        
                        doctorHome H1 = new doctorHome();
                        this.Hide();
                        H1.Show();
                    }
                    else {
                        MessageBox.Show("Invalid Login! Please check username and password");
                    }
                    conn.Close();
                }
                else {
                    MessageBox.Show("Select the correct role from dropdown and then try.");
                }
            }
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            home H1 = new home();
            this.Hide();
            H1.Show();
        }
    }
}
