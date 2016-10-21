namespace Appointment
{
    partial class staffHome
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
            this.appList = new System.Windows.Forms.Button();
            this.changePass = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.doctrsList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(191, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "STAFF HOME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appList
            // 
            this.appList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.appList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appList.ForeColor = System.Drawing.Color.White;
            this.appList.Location = new System.Drawing.Point(181, 144);
            this.appList.Name = "appList";
            this.appList.Size = new System.Drawing.Size(189, 43);
            this.appList.TabIndex = 2;
            this.appList.Text = "APPOINTMENT LIST";
            this.appList.UseVisualStyleBackColor = false;
            this.appList.Click += new System.EventHandler(this.appList_Click);
            // 
            // changePass
            // 
            this.changePass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.changePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass.ForeColor = System.Drawing.Color.White;
            this.changePass.Location = new System.Drawing.Point(426, 144);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(189, 43);
            this.changePass.TabIndex = 3;
            this.changePass.Text = "CHANGE PASSWORD";
            this.changePass.UseVisualStyleBackColor = false;
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(426, 229);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(189, 43);
            this.logout.TabIndex = 5;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // doctrsList
            // 
            this.doctrsList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.doctrsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctrsList.ForeColor = System.Drawing.Color.White;
            this.doctrsList.Location = new System.Drawing.Point(181, 228);
            this.doctrsList.Name = "doctrsList";
            this.doctrsList.Size = new System.Drawing.Size(189, 43);
            this.doctrsList.TabIndex = 4;
            this.doctrsList.Text = "DOCTORS LIST";
            this.doctrsList.UseVisualStyleBackColor = false;
            this.doctrsList.Click += new System.EventHandler(this.doctorsList_Click);
            // 
            // staffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appList);
            this.Controls.Add(this.changePass);
            this.Controls.Add(this.doctrsList);
            this.Controls.Add(this.logout);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "staffHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STAFF HOME";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button appList;
        private System.Windows.Forms.Button changePass;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button doctrsList;
    }
}