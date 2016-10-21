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
    public partial class patientHome : Form
    {
        public patientHome()
        {
            InitializeComponent();
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

        private void newApp_Click(object sender, EventArgs e)
        {
            newApp nA = new newApp();
            this.Hide();
            nA.Show();
        }

        private void appList_Click(object sender, EventArgs e)
        {
            appoListPatient aL = new appoListPatient();
            this.Hide();
            aL.Show();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            editPatient eP = new editPatient();
            this.Hide();
            eP.Show();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            changePass cP = new changePass();
            this.Hide();
            cP.Show();
        }
    }
}
