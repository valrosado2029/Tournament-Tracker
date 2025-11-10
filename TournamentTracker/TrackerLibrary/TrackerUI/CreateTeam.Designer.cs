namespace TrackerUI
{
    partial class CreateTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeam));
            this.TournamentName_txt = new System.Windows.Forms.TextBox();
            this.Header_lbl = new System.Windows.Forms.Label();
            this.TeamName_lbl = new System.Windows.Forms.Label();
            this.SelectTeamDropdown_cb = new System.Windows.Forms.ComboBox();
            this.SelectTeamMember_lbl = new System.Windows.Forms.Label();
            this.AddTeamMember_btn = new System.Windows.Forms.Button();
            this.AddNewMember_gb = new System.Windows.Forms.GroupBox();
            this.CreateTeamMember_btn = new System.Windows.Forms.Button();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.Phone_lbl = new System.Windows.Forms.Label();
            this.LName_txt = new System.Windows.Forms.TextBox();
            this.LName_lbl = new System.Windows.Forms.Label();
            this.FName_txt = new System.Windows.Forms.TextBox();
            this.FName_lbl = new System.Windows.Forms.Label();
            this.TeamMembersListbox_lb = new System.Windows.Forms.ListBox();
            this.DeleteSelected_btn = new System.Windows.Forms.Button();
            this.CreateTeam_btn = new System.Windows.Forms.Button();
            this.AddNewMember_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // TournamentName_txt
            // 
            this.TournamentName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName_txt.Location = new System.Drawing.Point(33, 105);
            this.TournamentName_txt.Name = "TournamentName_txt";
            this.TournamentName_txt.Size = new System.Drawing.Size(271, 29);
            this.TournamentName_txt.TabIndex = 15;
            // 
            // Header_lbl
            // 
            this.Header_lbl.AutoSize = true;
            this.Header_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_lbl.Location = new System.Drawing.Point(15, 20);
            this.Header_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Header_lbl.Name = "Header_lbl";
            this.Header_lbl.Size = new System.Drawing.Size(212, 37);
            this.Header_lbl.TabIndex = 14;
            this.Header_lbl.Text = "Create Team:";
            // 
            // TeamName_lbl
            // 
            this.TeamName_lbl.AutoSize = true;
            this.TeamName_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName_lbl.Location = new System.Drawing.Point(27, 68);
            this.TeamName_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TeamName_lbl.Name = "TeamName_lbl";
            this.TeamName_lbl.Size = new System.Drawing.Size(127, 34);
            this.TeamName_lbl.TabIndex = 13;
            this.TeamName_lbl.Text = "Team Name:";
            // 
            // SelectTeamDropdown_cb
            // 
            this.SelectTeamDropdown_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamDropdown_cb.FormattingEnabled = true;
            this.SelectTeamDropdown_cb.Location = new System.Drawing.Point(33, 196);
            this.SelectTeamDropdown_cb.Name = "SelectTeamDropdown_cb";
            this.SelectTeamDropdown_cb.Size = new System.Drawing.Size(271, 32);
            this.SelectTeamDropdown_cb.TabIndex = 17;
            // 
            // SelectTeamMember_lbl
            // 
            this.SelectTeamMember_lbl.AutoSize = true;
            this.SelectTeamMember_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMember_lbl.Location = new System.Drawing.Point(27, 159);
            this.SelectTeamMember_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SelectTeamMember_lbl.Name = "SelectTeamMember_lbl";
            this.SelectTeamMember_lbl.Size = new System.Drawing.Size(202, 34);
            this.SelectTeamMember_lbl.TabIndex = 16;
            this.SelectTeamMember_lbl.Text = "Select Team Member";
            // 
            // AddTeamMember_btn
            // 
            this.AddTeamMember_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamMember_btn.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamMember_btn.Location = new System.Drawing.Point(83, 244);
            this.AddTeamMember_btn.Name = "AddTeamMember_btn";
            this.AddTeamMember_btn.Size = new System.Drawing.Size(146, 43);
            this.AddTeamMember_btn.TabIndex = 18;
            this.AddTeamMember_btn.Text = "Add Team Member";
            this.AddTeamMember_btn.UseVisualStyleBackColor = true;
            // 
            // AddNewMember_gb
            // 
            this.AddNewMember_gb.Controls.Add(this.CreateTeamMember_btn);
            this.AddNewMember_gb.Controls.Add(this.Email_txt);
            this.AddNewMember_gb.Controls.Add(this.Email_lbl);
            this.AddNewMember_gb.Controls.Add(this.Phone_txt);
            this.AddNewMember_gb.Controls.Add(this.Phone_lbl);
            this.AddNewMember_gb.Controls.Add(this.LName_txt);
            this.AddNewMember_gb.Controls.Add(this.LName_lbl);
            this.AddNewMember_gb.Controls.Add(this.FName_txt);
            this.AddNewMember_gb.Controls.Add(this.FName_lbl);
            this.AddNewMember_gb.Font = new System.Drawing.Font("Myriad Pro Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewMember_gb.Location = new System.Drawing.Point(33, 306);
            this.AddNewMember_gb.Name = "AddNewMember_gb";
            this.AddNewMember_gb.Size = new System.Drawing.Size(345, 304);
            this.AddNewMember_gb.TabIndex = 19;
            this.AddNewMember_gb.TabStop = false;
            this.AddNewMember_gb.Text = "Add New Member";
            // 
            // CreateTeamMember_btn
            // 
            this.CreateTeamMember_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamMember_btn.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamMember_btn.Location = new System.Drawing.Point(63, 245);
            this.CreateTeamMember_btn.Name = "CreateTeamMember_btn";
            this.CreateTeamMember_btn.Size = new System.Drawing.Size(159, 43);
            this.CreateTeamMember_btn.TabIndex = 20;
            this.CreateTeamMember_btn.Text = "Create Team Member";
            this.CreateTeamMember_btn.UseVisualStyleBackColor = true;
            this.CreateTeamMember_btn.Click += new System.EventHandler(this.CreateTeamMember_btn_Click);
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(130, 189);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(191, 40);
            this.Email_txt.TabIndex = 23;
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.Location = new System.Drawing.Point(9, 189);
            this.Email_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(65, 34);
            this.Email_lbl.TabIndex = 22;
            this.Email_lbl.Text = "Email";
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(130, 143);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(191, 40);
            this.Phone_txt.TabIndex = 21;
            // 
            // Phone_lbl
            // 
            this.Phone_lbl.AutoSize = true;
            this.Phone_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_lbl.Location = new System.Drawing.Point(9, 143);
            this.Phone_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Phone_lbl.Name = "Phone_lbl";
            this.Phone_lbl.Size = new System.Drawing.Size(73, 34);
            this.Phone_lbl.TabIndex = 20;
            this.Phone_lbl.Text = "Phone";
            // 
            // LName_txt
            // 
            this.LName_txt.Location = new System.Drawing.Point(130, 97);
            this.LName_txt.Name = "LName_txt";
            this.LName_txt.Size = new System.Drawing.Size(191, 40);
            this.LName_txt.TabIndex = 19;
            // 
            // LName_lbl
            // 
            this.LName_lbl.AutoSize = true;
            this.LName_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName_lbl.Location = new System.Drawing.Point(9, 97);
            this.LName_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LName_lbl.Name = "LName_lbl";
            this.LName_lbl.Size = new System.Drawing.Size(109, 34);
            this.LName_lbl.TabIndex = 18;
            this.LName_lbl.Text = "Last Name";
            // 
            // FName_txt
            // 
            this.FName_txt.Location = new System.Drawing.Point(130, 51);
            this.FName_txt.Name = "FName_txt";
            this.FName_txt.Size = new System.Drawing.Size(191, 40);
            this.FName_txt.TabIndex = 17;
            // 
            // FName_lbl
            // 
            this.FName_lbl.AutoSize = true;
            this.FName_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName_lbl.Location = new System.Drawing.Point(9, 56);
            this.FName_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FName_lbl.Name = "FName_lbl";
            this.FName_lbl.Size = new System.Drawing.Size(110, 34);
            this.FName_lbl.TabIndex = 16;
            this.FName_lbl.Text = "First Name";
            // 
            // TeamMembersListbox_lb
            // 
            this.TeamMembersListbox_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListbox_lb.FormattingEnabled = true;
            this.TeamMembersListbox_lb.ItemHeight = 19;
            this.TeamMembersListbox_lb.Location = new System.Drawing.Point(409, 88);
            this.TeamMembersListbox_lb.Name = "TeamMembersListbox_lb";
            this.TeamMembersListbox_lb.Size = new System.Drawing.Size(280, 515);
            this.TeamMembersListbox_lb.TabIndex = 20;
            // 
            // DeleteSelected_btn
            // 
            this.DeleteSelected_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelected_btn.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelected_btn.Location = new System.Drawing.Point(724, 306);
            this.DeleteSelected_btn.Name = "DeleteSelected_btn";
            this.DeleteSelected_btn.Size = new System.Drawing.Size(124, 38);
            this.DeleteSelected_btn.TabIndex = 21;
            this.DeleteSelected_btn.Text = "Delete Selected";
            this.DeleteSelected_btn.UseVisualStyleBackColor = true;
            // 
            // CreateTeam_btn
            // 
            this.CreateTeam_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeam_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeam_btn.Location = new System.Drawing.Point(327, 621);
            this.CreateTeam_btn.Name = "CreateTeam_btn";
            this.CreateTeam_btn.Size = new System.Drawing.Size(183, 57);
            this.CreateTeam_btn.TabIndex = 23;
            this.CreateTeam_btn.Text = "Create Team";
            this.CreateTeam_btn.UseVisualStyleBackColor = true;
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(881, 690);
            this.Controls.Add(this.CreateTeam_btn);
            this.Controls.Add(this.DeleteSelected_btn);
            this.Controls.Add(this.TeamMembersListbox_lb);
            this.Controls.Add(this.AddNewMember_gb);
            this.Controls.Add(this.AddTeamMember_btn);
            this.Controls.Add(this.SelectTeamDropdown_cb);
            this.Controls.Add(this.SelectTeamMember_lbl);
            this.Controls.Add(this.TournamentName_txt);
            this.Controls.Add(this.Header_lbl);
            this.Controls.Add(this.TeamName_lbl);
            this.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateTeam";
            this.Text = "CreateTeam";
            this.AddNewMember_gb.ResumeLayout(false);
            this.AddNewMember_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TournamentName_txt;
        private System.Windows.Forms.Label Header_lbl;
        private System.Windows.Forms.Label TeamName_lbl;
        private System.Windows.Forms.ComboBox SelectTeamDropdown_cb;
        private System.Windows.Forms.Label SelectTeamMember_lbl;
        private System.Windows.Forms.Button AddTeamMember_btn;
        private System.Windows.Forms.GroupBox AddNewMember_gb;
        private System.Windows.Forms.TextBox LName_txt;
        private System.Windows.Forms.Label LName_lbl;
        private System.Windows.Forms.TextBox FName_txt;
        private System.Windows.Forms.Label FName_lbl;
        private System.Windows.Forms.Button CreateTeamMember_btn;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.Label Phone_lbl;
        private System.Windows.Forms.ListBox TeamMembersListbox_lb;
        private System.Windows.Forms.Button DeleteSelected_btn;
        private System.Windows.Forms.Button CreateTeam_btn;
    }
}