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
    public partial class appoListStaff : Form
    {
        public appoListStaff()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            staffHome sH = new staffHome();
            this.Hide();
            sH.Show();
        }

        private void invalidApp_Click(object sender, EventArgs e)
        {
            invalid_AppoList iA = new invalid_AppoList();
            this.Hide();
            iA.Show();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please, select at least one row to confirm");
            }
            else
            {
                SelectDoctor sD = new SelectDoctor();
                sD.ShowDialog();
                if (Program.doctorUsername != "")
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        string query = "UPDATE Appointment SET Doctor = @one, Status = @two, DoctorName = @three WHERE Id = @four";
                        SqlConnection conn = Program.getConn();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@one", Program.doctorUsername);
                        cmd.Parameters.AddWithValue("@two", "Confirmed");
                        cmd.Parameters.AddWithValue("@three", Program.doctorName);
                        cmd.Parameters.AddWithValue("@four", row.Cells[0].Value.ToString());
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
                    MessageBox.Show("Appointmnt/s Successfully Confirmed");
                    SqlConnection conn2 = Program.getConn();
                    SqlCommand cmd2 = new SqlCommand("SELECT Id, Date, Time, Comment, Status, Doctor FROM Appointment WHERE Status <> 'Closed' AND Status <> 'Cancelled' ORDER BY Date DESC", conn2);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dataGridView1.DataSource = dt;
                    this.dataGridView1.Columns[0].Visible = false;
                    Program.doctorName = "";
                    Program.doctorUsername = "";
                }
            }
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

        private void appoListStaff_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Program.getConn();
            SqlCommand cmd2 = new SqlCommand("SELECT Id, Date, Time, Comment, Status, Doctor FROM Appointment WHERE Status <> 'Closed' AND Status <> 'Cancelled' ORDER BY Date DESC", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void print_Click(object sender, EventArgs e)
        {
            Program.getPDF(dataGridView1);
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
