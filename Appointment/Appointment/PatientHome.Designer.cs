namespace Appointment
{
    partial class patientHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.editProfile = new System.Windows.Forms.Button();
            this.appList = new System.Windows.Forms.Button();
            this.changePass = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.newApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(199, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "PATIENT HOME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editProfile
            // 
            this.editProfile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.editProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfile.ForeColor = System.Drawing.Color.White;
            this.editProfile.Location = new System.Drawing.Point(173, 226);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(189, 43);
            this.editProfile.TabIndex = 4;
            this.editProfile.Text = "EDIT PROFILE";
            this.editProfile.UseVisualStyleBackColor = false;
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // appList
            // 
            this.appList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.appList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appList.ForeColor = System.Drawing.Color.White;
            this.appList.Location = new System.Drawing.Point(416, 142);
            this.appList.Name = "appList";
            this.appList.Size = new System.Drawing.Size(189, 43);
            this.appList.TabIndex = 3;
            this.appList.Text = "APPOINTMENT LIST";
            this.appList.UseVisualStyleBackColor = false;
            this.appList.Click += new System.EventHandler(this.appList_Click);
            // 
            // changePass
            // 
            this.changePass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.changePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass.ForeColor = System.Drawing.Color.White;
            this.changePass.Location = new System.Drawing.Point(416, 227);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(189, 43);
            this.changePass.TabIndex = 5;
            this.changePass.Text = "CHANGE PASSWORD";
            this.changePass.UseVisualStyleBackColor = false;
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(294, 312);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(189, 43);
            this.logout.TabIndex = 6;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // newApp
            // 
            this.newApp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.newApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newApp.ForeColor = System.Drawing.Color.White;
            this.newApp.Location = new System.Drawing.Point(173, 142);
            this.newApp.Name = "newApp";
            this.newApp.Size = new System.Drawing.Size(189, 43);
            this.newApp.TabIndex = 2;
            this.newApp.Text = "MAKE NEW APPOINTMENT";
            this.newApp.UseVisualStyleBackColor = false;
            this.newApp.Click += new System.EventHandler(this.newApp_Click);
            // 
            // patientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editProfile);
            this.Controls.Add(this.newApp);
            this.Controls.Add(this.appList);
            this.Controls.Add(this.changePass);
            this.Controls.Add(this.logout);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "patientHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PATIENT HOME";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editProfile;
        private System.Windows.Forms.Button appList;
        private System.Windows.Forms.Button changePass;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button newApp;
    }
}