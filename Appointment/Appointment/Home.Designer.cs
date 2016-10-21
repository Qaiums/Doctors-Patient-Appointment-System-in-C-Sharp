namespace Appointment
{
    partial class home
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
            this.login = new System.Windows.Forms.Button();
            this.patientReg = new System.Windows.Forms.Button();
            this.doctorReg = new System.Windows.Forms.Button();
            this.staffReg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(175, 198);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(189, 43);
            this.login.TabIndex = 1;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // patientReg
            // 
            this.patientReg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.patientReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientReg.ForeColor = System.Drawing.Color.White;
            this.patientReg.Location = new System.Drawing.Point(414, 198);
            this.patientReg.Name = "patientReg";
            this.patientReg.Size = new System.Drawing.Size(189, 43);
            this.patientReg.TabIndex = 2;
            this.patientReg.Text = "PATIENT REGISTRATION";
            this.patientReg.UseVisualStyleBackColor = false;
            this.patientReg.Click += new System.EventHandler(this.patientReg_Click);
            // 
            // doctorReg
            // 
            this.doctorReg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.doctorReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorReg.ForeColor = System.Drawing.Color.White;
            this.doctorReg.Location = new System.Drawing.Point(175, 284);
            this.doctorReg.Name = "doctorReg";
            this.doctorReg.Size = new System.Drawing.Size(189, 43);
            this.doctorReg.TabIndex = 3;
            this.doctorReg.Text = "DOCTOR REGISTRATION";
            this.doctorReg.UseVisualStyleBackColor = false;
            this.doctorReg.Click += new System.EventHandler(this.doctorReg_Click);
            // 
            // staffReg
            // 
            this.staffReg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.staffReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffReg.ForeColor = System.Drawing.Color.White;
            this.staffReg.Location = new System.Drawing.Point(414, 284);
            this.staffReg.Name = "staffReg";
            this.staffReg.Size = new System.Drawing.Size(189, 43);
            this.staffReg.TabIndex = 4;
            this.staffReg.Text = "STAFF REGISTRATION";
            this.staffReg.UseVisualStyleBackColor = false;
            this.staffReg.Click += new System.EventHandler(this.staffReg_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(183, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 85);
            this.label2.TabIndex = 6;
            this.label2.Text = "PATIENT APPOINTMENT MANAGEMENT SYSTEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffReg);
            this.Controls.Add(this.doctorReg);
            this.Controls.Add(this.patientReg);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button patientReg;
        private System.Windows.Forms.Button doctorReg;
        private System.Windows.Forms.Button staffReg;
        private System.Windows.Forms.Label label2;
    }
}

