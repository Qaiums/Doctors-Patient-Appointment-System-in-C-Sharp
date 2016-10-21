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
    public partial class staffHome : Form
    {
        public staffHome()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            home H1 = new home();
            Program.userName = "";
            Program.roleName = "";
            Program.loginId = -1;
            Program.doctorUsername = "";
            Program.doctorName = "";
            this.Hide();
            H1.Show();
        }

        private void appList_Click(object sender, EventArgs e)
        {
            appoListStaff aLS = new appoListStaff();
            this.Hide();
            aLS.Show();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            changePass cP = new changePass();
            this.Hide();
            cP.Show();
        }

        private void doctorsList_Click(object sender, EventArgs e)
        {
            doctorsList dL = new doctorsList();
            this.Hide();
            dL.Show();
        }
    }
}
