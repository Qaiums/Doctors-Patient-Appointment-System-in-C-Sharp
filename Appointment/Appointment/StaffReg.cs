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
    public partial class StaffReg : Form
    {
        public StaffReg()
        {
            InitializeComponent();
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            home H1 = new home();
            this.Hide();
            H1.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if ((this.username.Text == "") || (this.password.Text == "") || (this.fullName.Text == "") || (this.position.Text == ""))
            {
                MessageBox.Show("Please, fill all the fields");
            }
            else if (this.password.Text != this.confirmPassword.Text)
            {
                MessageBox.Show("Password didn't match.");
                this.password.Focus();
            }
            else
            {
                string query = "INSERT INTO Staff (Fullname, Username, Password, Position) VALUES (@one, @two, @three, @four)";
                SqlConnection conn = Program.getConn();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@one", this.fullName.Text);
                cmd.Parameters.AddWithValue("@two", this.username.Text);
                cmd.Parameters.AddWithValue("@three", this.password.Text);
                cmd.Parameters.AddWithValue("@four", this.position.Text);
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
                    MessageBox.Show("Registration Successful");
                    conn.Close();
                    home H1 = new home();
                    this.Hide();
                    H1.Show();                    
                }
            }
        }
        private void username_Leave(object sender, EventArgs e)
        {
            SqlConnection conn = Program.getConn();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Username FROM Staff", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "usernames");
            foreach (DataRow row in ds.Tables["usernames"].Rows)
            {
                if (row["Username"].ToString() == this.username.Text)
                {
                    MessageBox.Show("Username already taken. Try somehing else.");
                    this.username.Focus();
                }
            }
        }
    }
}
