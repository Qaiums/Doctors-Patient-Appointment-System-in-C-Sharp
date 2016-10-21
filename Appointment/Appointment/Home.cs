using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            this.Hide();
            l1.Show();
        }

        private void patientReg_Click(object sender, EventArgs e)
        {
            PatientReg P1 = new PatientReg();
            this.Hide();
            P1.Show();
        }

        private void doctorReg_Click(object sender, EventArgs e)
        {
            DoctorReg D1 = new DoctorReg();
            this.Hide();
            D1.Show();
        }

        private void staffReg_Click(object sender, EventArgs e)
        {
            StaffReg S1 = new StaffReg();
            this.Hide();
            S1.Show();
        }
    }
}
