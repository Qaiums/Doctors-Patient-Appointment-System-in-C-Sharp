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
    public partial class appoListPatient : Form
    {
        public appoListPatient()
        {
            InitializeComponent();

        }

        private void appoListPatient_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Program.getConn();
            SqlCommand cmd2 = new SqlCommand("SELECT Id, Date, Time, Comment, Status, DoctorName FROM Appointment WHERE PatientId = " + Program.loginId + " AND Status <> 'Closed' AND Status <> 'Cancelled' ORDER BY Id DESC", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[5].HeaderText = "Doctor Name";
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please, select at least one row to edit");
            }
            else if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Program.appId = Convert.ToInt32(row.Cells[0].Value);
                    editApp eA = new editApp();
                    this.Hide();
                    eA.Show();
                }
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please, select one row at a time.");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please, select at least one row to delete");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string query = "DELETE FROM Appointment WHERE Id = @one";
                    SqlConnection conn = Program.getConn();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@one", row.Cells[0].Value.ToString());
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
                MessageBox.Show("Appointmnt/s Successfully Deleted");
                SqlConnection conn2 = Program.getConn();
                SqlCommand cmd2 = new SqlCommand("SELECT Id, Date, Time, Comment, Status, DoctorName FROM Appointment WHERE PatientId = " + Program.loginId + " AND Status <> 'Closed' AND Status <> 'Cancelled' ORDER BY Id DESC", conn2);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[5].HeaderText = "Doctor Name";
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            patientHome pH = new patientHome();
            this.Hide();
            pH.Show();
        }

        private void print_Click(object sender, EventArgs e)
        {
            Program.getPDF(dataGridView1);
        }

        private void invalidApp_Click(object sender, EventArgs e)
        {
            invalid_AppoList iA = new invalid_AppoList();
            this.Hide();
            iA.Show();
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
