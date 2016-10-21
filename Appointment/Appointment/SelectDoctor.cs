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
    public partial class SelectDoctor : Form
    {
        private void SizeAllRows(Object sender, EventArgs e)
        {
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        public SelectDoctor()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SelectDoctor_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Program.getConn();
            SqlCommand cmd2 = new SqlCommand("SELECT Fullname, Username, Speciality, Schedule FROM Doctor", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please, select at least one row to confirm");
            }
            else if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Program.doctorName = row.Cells[0].Value.ToString();
                    Program.doctorUsername = row.Cells[1].Value.ToString();                    
                    this.Hide();
                }
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please, select one row at max.");
            }
        }
    }
}
