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
    public partial class editPatient : Form
    {
        public editPatient()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            patientHome pH = new patientHome();
            this.Hide();
            pH.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if ((this.phone.Text == "") && (this.address.Text == ""))
            {
                MessageBox.Show("Both fields can't be empty.");
            }
            else if ((this.phone.Text == "") && (this.address.Text != ""))
            {
                string query = "UPDATE Patient SET address = @one WHERE username = @two";
                SqlConnection conn = Program.getConn();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@one", this.address.Text);
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
                    MessageBox.Show("Address updated successfully");
                    patientHome pH = new patientHome();
                    this.Hide();
                    pH.Show();
                    conn.Close();
                }
            }
            else if ((this.phone.Text != "") && (this.address.Text == ""))
            {
                string query = "UPDATE Patient SET Phone = @one WHERE username = @two";
                SqlConnection conn = Program.getConn();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@one", this.phone.Text);
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
                    MessageBox.Show("Phone number updated successfully");
                    patientHome pH = new patientHome();
                    this.Hide();
                    pH.Show();
                    conn.Close();
                }
            }
            else
            {
                string query = "UPDATE Patient SET Phone = @one, Address = @two WHERE username = @three";
                SqlConnection conn = Program.getConn();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@one", this.phone.Text);
                cmd.Parameters.AddWithValue("@two", this.address.Text);
                cmd.Parameters.AddWithValue("@three", Program.userName);
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
                    MessageBox.Show("Profile updated successfully");
                    patientHome pH = new patientHome();
                    this.Hide();
                    pH.Show();
                    conn.Close();
                }
            }
        }

        private void editPatient_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Program.getConn();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Address, Phone FROM Patient WHERE id = " + Program.loginId, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "profiles");
            foreach (DataRow row in ds.Tables["profiles"].Rows)
            {
                this.address.Text = row["Address"].ToString();
                this.phone.Text = row["Phone"].ToString();
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
