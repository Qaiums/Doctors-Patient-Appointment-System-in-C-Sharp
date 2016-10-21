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
    public partial class appoListDoctor : Form
    {
        public appoListDoctor()
        {
            InitializeComponent();
        }

        private void invalidApp_Click(object sender, EventArgs e)
        {
            invalid_AppoList iL = new invalid_AppoList();
            this.Hide();
            iL.Show();
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

        private void goBack_Click(object sender, EventArgs e)
        {
            doctorHome dH = new doctorHome();
            this.Hide();
            dH.Show();
        }

        private void postpone_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please, select at least one row to postpone");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string query = "UPDATE Appointment SET Status = @one WHERE Id = @two";
                    SqlConnection conn = Program.getConn();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@one", "Cancelled");
                    cmd.Parameters.AddWithValue("@two", row.Cells[0].Value.ToString());
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
                    }
                }
                MessageBox.Show("Appointmnt/s Successfully postponed");
                SqlConnection conn2 = Program.getConn();
                SqlCommand cmd2 = new SqlCommand("SELECT Id, Date, Time, Comment FROM Appointment WHERE Doctor = '" + Program.userName + "' AND Status <> 'Closed' AND Status <> 'Cancelled' ORDER BY Id DESC", conn2);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[0].Visible = false;
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            Program.getPDF(dataGridView1);
        }

        private void appoListDoctor_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Program.getConn();
            SqlCommand cmd2 = new SqlCommand("SELECT Id, Date, Time, Comment FROM Appointment WHERE Doctor = '" + Program.userName + "' AND Status <> 'Closed' AND Status <> 'Cancelled' ORDER BY Id DESC", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please, select at least one row to close.");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string query = "UPDATE Appointment SET Status = @one WHERE Id = @two";
                    SqlConnection conn = Program.getConn();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@one", "Closed");
                    cmd.Parameters.AddWithValue("@two", row.Cells[0].Value.ToString());
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
                    }
                }
                MessageBox.Show("Appointmnt/s Successfully closed");
                SqlConnection conn2 = Program.getConn();
                SqlCommand cmd2 = new SqlCommand("SELECT Id, Date, Time, Comment FROM Appointment WHERE Doctor = '" + Program.userName + "' AND Status <> 'Closed' AND Status <> 'Cancelled' ORDER BY Id DESC", conn2);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[0].Visible = false;
            }
        }
    }
}
