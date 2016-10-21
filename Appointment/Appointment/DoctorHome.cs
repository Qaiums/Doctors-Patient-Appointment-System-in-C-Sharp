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
    public partial class doctorHome : Form
    {
        public doctorHome()
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

        private void appList_Click(object sender, EventArgs e)
        {
            appoListDoctor aLD = new appoListDoctor();
            this.Hide();
            aLD.Show();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            changePass cP = new changePass();
            this.Hide();
            cP.Show();
        }

        private void chnageSchedule_Click(object sender, EventArgs e)
        {
            changeSchedule cS = new changeSchedule();
            this.Hide();
            cS.Show();
        }
    }
}
