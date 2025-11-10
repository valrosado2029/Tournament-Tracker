namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.SelectTeamDropdown_cb = new System.Windows.Forms.ComboBox();
            this.SelectTeam_lbl = new System.Windows.Forms.Label();
            this.TournamentName_lbl = new System.Windows.Forms.Label();
            this.Header_lbl = new System.Windows.Forms.Label();
            this.EntryFee_txt = new System.Windows.Forms.TextBox();
            this.EntryFee_lbl = new System.Windows.Forms.Label();
            this.TournamentName_txt = new System.Windows.Forms.TextBox();
            this.CreateNew_llbl = new System.Windows.Forms.LinkLabel();
            this.CreatePrize_btn = new System.Windows.Forms.Button();
            this.AddTeam_btn = new System.Windows.Forms.Button();
            this.TournamentPlayersListbox_lb = new System.Windows.Forms.ListBox();
            this.TournamentPlayers_lbl = new System.Windows.Forms.Label();
            this.DeleteSelected_btn = new System.Windows.Forms.Button();
            this.DeleteSelected2_btn = new System.Windows.Forms.Button();
            this.PrizesBox_lbl = new System.Windows.Forms.Label();
            this.PrizesListBox_lb = new System.Windows.Forms.ListBox();
            this.CreateTournament_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectTeamDropdown_cb
            // 
            this.SelectTeamDropdown_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamDropdown_cb.FormattingEnabled = true;
            this.SelectTeamDropdown_cb.Location = new System.Drawing.Point(69, 253);
            this.SelectTeamDropdown_cb.Name = "SelectTeamDropdown_cb";
            this.SelectTeamDropdown_cb.Size = new System.Drawing.Size(251, 32);
            this.SelectTeamDropdown_cb.TabIndex = 5;
            // 
            // SelectTeam_lbl
            // 
            this.SelectTeam_lbl.AutoSize = true;
            this.SelectTeam_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeam_lbl.Location = new System.Drawing.Point(63, 216);
            this.SelectTeam_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SelectTeam_lbl.Name = "SelectTeam_lbl";
            this.SelectTeam_lbl.Size = new System.Drawing.Size(121, 34);
            this.SelectTeam_lbl.TabIndex = 4;
            this.SelectTeam_lbl.Text = "Select Team";
            // 
            // TournamentName_lbl
            // 
            this.TournamentName_lbl.AutoSize = true;
            this.TournamentName_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName_lbl.Location = new System.Drawing.Point(63, 89);
            this.TournamentName_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TournamentName_lbl.Name = "TournamentName_lbl";
            this.TournamentName_lbl.Size = new System.Drawing.Size(188, 34);
            this.TournamentName_lbl.TabIndex = 6;
            this.TournamentName_lbl.Text = "Tournament Name:";
            // 
            // Header_lbl
            // 
            this.Header_lbl.AutoSize = true;
            this.Header_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_lbl.Location = new System.Drawing.Point(51, 41);
            this.Header_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Header_lbl.Name = "Header_lbl";
            this.Header_lbl.Size = new System.Drawing.Size(200, 37);
            this.Header_lbl.TabIndex = 8;
            this.Header_lbl.Text = "Tournament:\r\n";
            // 
            // EntryFee_txt
            // 
            this.EntryFee_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFee_txt.Location = new System.Drawing.Point(170, 161);
            this.EntryFee_txt.Name = "EntryFee_txt";
            this.EntryFee_txt.Size = new System.Drawing.Size(109, 29);
            this.EntryFee_txt.TabIndex = 10;
            this.EntryFee_txt.Text = "0";
            // 
            // EntryFee_lbl
            // 
            this.EntryFee_lbl.AutoSize = true;
            this.EntryFee_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFee_lbl.Location = new System.Drawing.Point(63, 156);
            this.EntryFee_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EntryFee_lbl.Name = "EntryFee_lbl";
            this.EntryFee_lbl.Size = new System.Drawing.Size(98, 34);
            this.EntryFee_lbl.TabIndex = 9;
            this.EntryFee_lbl.Text = "Entry Fee";
            // 
            // TournamentName_txt
            // 
            this.TournamentName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName_txt.Location = new System.Drawing.Point(69, 126);
            this.TournamentName_txt.Name = "TournamentName_txt";
            this.TournamentName_txt.Size = new System.Drawing.Size(251, 29);
            this.TournamentName_txt.TabIndex = 12;
            // 
            // CreateNew_llbl
            // 
            this.CreateNew_llbl.AutoSize = true;
            this.CreateNew_llbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNew_llbl.Location = new System.Drawing.Point(211, 224);
            this.CreateNew_llbl.Name = "CreateNew_llbl";
            this.CreateNew_llbl.Size = new System.Drawing.Size(109, 24);
            this.CreateNew_llbl.TabIndex = 13;
            this.CreateNew_llbl.TabStop = true;
            this.CreateNew_llbl.Text = "Create New";
            // 
            // CreatePrize_btn
            // 
            this.CreatePrize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrize_btn.Location = new System.Drawing.Point(143, 358);
            this.CreatePrize_btn.Name = "CreatePrize_btn";
            this.CreatePrize_btn.Size = new System.Drawing.Size(124, 36);
            this.CreatePrize_btn.TabIndex = 14;
            this.CreatePrize_btn.Text = "Create Prize";
            this.CreatePrize_btn.UseVisualStyleBackColor = true;
            // 
            // AddTeam_btn
            // 
            this.AddTeam_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeam_btn.Location = new System.Drawing.Point(143, 301);
            this.AddTeam_btn.Name = "AddTeam_btn";
            this.AddTeam_btn.Size = new System.Drawing.Size(124, 38);
            this.AddTeam_btn.TabIndex = 15;
            this.AddTeam_btn.Text = "Add Team";
            this.AddTeam_btn.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListbox_lb
            // 
            this.TournamentPlayersListbox_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayersListbox_lb.FormattingEnabled = true;
            this.TournamentPlayersListbox_lb.Location = new System.Drawing.Point(427, 126);
            this.TournamentPlayersListbox_lb.Name = "TournamentPlayersListbox_lb";
            this.TournamentPlayersListbox_lb.Size = new System.Drawing.Size(227, 93);
            this.TournamentPlayersListbox_lb.TabIndex = 16;
            // 
            // TournamentPlayers_lbl
            // 
            this.TournamentPlayers_lbl.AutoSize = true;
            this.TournamentPlayers_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentPlayers_lbl.Location = new System.Drawing.Point(421, 89);
            this.TournamentPlayers_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TournamentPlayers_lbl.Name = "TournamentPlayers_lbl";
            this.TournamentPlayers_lbl.Size = new System.Drawing.Size(154, 34);
            this.TournamentPlayers_lbl.TabIndex = 17;
            this.TournamentPlayers_lbl.Text = "Teams / Players";
            // 
            // DeleteSelected_btn
            // 
            this.DeleteSelected_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelected_btn.Location = new System.Drawing.Point(664, 156);
            this.DeleteSelected_btn.Name = "DeleteSelected_btn";
            this.DeleteSelected_btn.Size = new System.Drawing.Size(124, 38);
            this.DeleteSelected_btn.TabIndex = 18;
            this.DeleteSelected_btn.Text = "Delete Selected";
            this.DeleteSelected_btn.UseVisualStyleBackColor = true;
            // 
            // DeleteSelected2_btn
            // 
            this.DeleteSelected2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelected2_btn.Location = new System.Drawing.Point(650, 312);
            this.DeleteSelected2_btn.Name = "DeleteSelected2_btn";
            this.DeleteSelected2_btn.Size = new System.Drawing.Size(124, 38);
            this.DeleteSelected2_btn.TabIndex = 21;
            this.DeleteSelected2_btn.Text = "Delete Selected";
            this.DeleteSelected2_btn.UseVisualStyleBackColor = true;
            // 
            // PrizesBox_lbl
            // 
            this.PrizesBox_lbl.AutoSize = true;
            this.PrizesBox_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizesBox_lbl.Location = new System.Drawing.Point(407, 245);
            this.PrizesBox_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PrizesBox_lbl.Name = "PrizesBox_lbl";
            this.PrizesBox_lbl.Size = new System.Drawing.Size(154, 34);
            this.PrizesBox_lbl.TabIndex = 20;
            this.PrizesBox_lbl.Text = "Teams / Players";
            // 
            // PrizesListBox_lb
            // 
            this.PrizesListBox_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox_lb.FormattingEnabled = true;
            this.PrizesListBox_lb.Location = new System.Drawing.Point(413, 282);
            this.PrizesListBox_lb.Name = "PrizesListBox_lb";
            this.PrizesListBox_lb.Size = new System.Drawing.Size(227, 93);
            this.PrizesListBox_lb.TabIndex = 19;
            // 
            // CreateTournament_btn
            // 
            this.CreateTournament_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournament_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournament_btn.Location = new System.Drawing.Point(277, 403);
            this.CreateTournament_btn.Name = "CreateTournament_btn";
            this.CreateTournament_btn.Size = new System.Drawing.Size(183, 57);
            this.CreateTournament_btn.TabIndex = 22;
            this.CreateTournament_btn.Text = "Create Tournament";
            this.CreateTournament_btn.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.CreateTournament_btn);
            this.Controls.Add(this.DeleteSelected2_btn);
            this.Controls.Add(this.PrizesBox_lbl);
            this.Controls.Add(this.PrizesListBox_lb);
            this.Controls.Add(this.DeleteSelected_btn);
            this.Controls.Add(this.TournamentPlayers_lbl);
            this.Controls.Add(this.TournamentPlayersListbox_lb);
            this.Controls.Add(this.AddTeam_btn);
            this.Controls.Add(this.CreatePrize_btn);
            this.Controls.Add(this.CreateNew_llbl);
            this.Controls.Add(this.TournamentName_txt);
            this.Controls.Add(this.EntryFee_txt);
            this.Controls.Add(this.EntryFee_lbl);
            this.Controls.Add(this.Header_lbl);
            this.Controls.Add(this.TournamentName_lbl);
            this.Controls.Add(this.SelectTeamDropdown_cb);
            this.Controls.Add(this.SelectTeam_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectTeamDropdown_cb;
        private System.Windows.Forms.Label SelectTeam_lbl;
        private System.Windows.Forms.Label TournamentName_lbl;
        private System.Windows.Forms.Label Header_lbl;
        private System.Windows.Forms.TextBox EntryFee_txt;
        private System.Windows.Forms.Label EntryFee_lbl;
        private System.Windows.Forms.TextBox TournamentName_txt;
        private System.Windows.Forms.LinkLabel CreateNew_llbl;
        private System.Windows.Forms.Button CreatePrize_btn;
        private System.Windows.Forms.Button AddTeam_btn;
        private System.Windows.Forms.ListBox TournamentPlayersListbox_lb;
        private System.Windows.Forms.Label TournamentPlayers_lbl;
        private System.Windows.Forms.Button DeleteSelected_btn;
        private System.Windows.Forms.Button DeleteSelected2_btn;
        private System.Windows.Forms.Label PrizesBox_lbl;
        private System.Windows.Forms.ListBox PrizesListBox_lb;
        private System.Windows.Forms.Button CreateTournament_btn;
    }
}