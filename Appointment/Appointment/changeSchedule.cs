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
    public partial class changeSchedule : Form
    {
        public changeSchedule()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            doctorHome dH = new doctorHome();
            this.Hide();
            dH.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Doctor SET Schedule = @one WHERE Username = @two";
            SqlConnection conn = Program.getConn();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@one", this.schedule.Text);
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
                MessageBox.Show("Schedule updated successfully");
                conn.Close();
                doctorHome dH = new doctorHome();
                this.Hide();
                dH.Show();
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

        private void changeSchedule_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Program.getConn();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Schedule FROM Doctor WHERE id = " + Program.loginId, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "schedule");
            foreach (DataRow row in ds.Tables["schedule"].Rows)
            {
                this.schedule.Text = row["Schedule"].ToString();
            }
        }
    }
}
