namespace Appointment
{
    partial class appoListStaff
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
            this.invalidApp = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // invalidApp
            // 
            this.invalidApp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.invalidApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidApp.ForeColor = System.Drawing.Color.White;
            this.invalidApp.Location = new System.Drawing.Point(515, 351);
            this.invalidApp.Name = "invalidApp";
            this.invalidApp.Size = new System.Drawing.Size(203, 40);
            this.invalidApp.TabIndex = 6;
            this.invalidApp.Text = "PAST APPOINTMENTS";
            this.invalidApp.UseVisualStyleBackColor = false;
            this.invalidApp.Click += new System.EventHandler(this.invalidApp_Click);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.Location = new System.Drawing.Point(63, 416);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(203, 40);
            this.print.TabIndex = 5;
            this.print.Text = "PRINT";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBack.ForeColor = System.Drawing.Color.White;
            this.goBack.Location = new System.Drawing.Point(286, 416);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(203, 40);
            this.goBack.TabIndex = 4;
            this.goBack.Text = "GO BACK";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.Location = new System.Drawing.Point(286, 351);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(203, 40);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "CONFIRM";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(63, 351);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(203, 40);
            this.edit.TabIndex = 2;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(46, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(693, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(515, 416);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(189, 40);
            this.logout.TabIndex = 7;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // appoListStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.invalidApp);
            this.Controls.Add(this.print);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "appoListStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALL APPOINTMENTS";
            this.Load += new System.EventHandler(this.appoListStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button invalidApp;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logout;
    }
}