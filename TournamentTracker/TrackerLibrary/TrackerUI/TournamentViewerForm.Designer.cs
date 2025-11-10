namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.Header_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Round_lbl = new System.Windows.Forms.Label();
            this.RoundDropdown_cb = new System.Windows.Forms.ComboBox();
            this.UnplayedOnly_cb = new System.Windows.Forms.CheckBox();
            this.MatchupListbox_lb = new System.Windows.Forms.ListBox();
            this.TeamName1_lbl = new System.Windows.Forms.Label();
            this.Score2_txt = new System.Windows.Forms.TextBox();
            this.Score2_lbl = new System.Windows.Forms.Label();
            this.TeamName2_lbl = new System.Windows.Forms.Label();
            this.VS_lbl = new System.Windows.Forms.Label();
            this.Score_btn = new System.Windows.Forms.Button();
            this.Score1_txt = new System.Windows.Forms.TextBox();
            this.Score1_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header_lbl
            // 
            this.Header_lbl.AutoSize = true;
            this.Header_lbl.Location = new System.Drawing.Point(15, 26);
            this.Header_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Header_lbl.Name = "Header_lbl";
            this.Header_lbl.Size = new System.Drawing.Size(156, 41);
            this.Header_lbl.TabIndex = 0;
            this.Header_lbl.Text = "Tournament:\r\n";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(183, 26);
            this.Name_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(114, 41);
            this.Name_lbl.TabIndex = 1;
            this.Name_lbl.Text = "<none>";
            // 
            // Round_lbl
            // 
            this.Round_lbl.AutoSize = true;
            this.Round_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Round_lbl.Location = new System.Drawing.Point(34, 127);
            this.Round_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Round_lbl.Name = "Round_lbl";
            this.Round_lbl.Size = new System.Drawing.Size(74, 34);
            this.Round_lbl.TabIndex = 2;
            this.Round_lbl.Text = "Round";
            // 
            // RoundDropdown_cb
            // 
            this.RoundDropdown_cb.FormattingEnabled = true;
            this.RoundDropdown_cb.Location = new System.Drawing.Point(117, 112);
            this.RoundDropdown_cb.Name = "RoundDropdown_cb";
            this.RoundDropdown_cb.Size = new System.Drawing.Size(238, 49);
            this.RoundDropdown_cb.TabIndex = 3;
            // 
            // UnplayedOnly_cb
            // 
            this.UnplayedOnly_cb.AutoSize = true;
            this.UnplayedOnly_cb.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnly_cb.Location = new System.Drawing.Point(188, 167);
            this.UnplayedOnly_cb.Name = "UnplayedOnly_cb";
            this.UnplayedOnly_cb.Size = new System.Drawing.Size(167, 38);
            this.UnplayedOnly_cb.TabIndex = 4;
            this.UnplayedOnly_cb.Text = "Unplayed Only";
            this.UnplayedOnly_cb.UseVisualStyleBackColor = true;
            // 
            // MatchupListbox_lb
            // 
            this.MatchupListbox_lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListbox_lb.FormattingEnabled = true;
            this.MatchupListbox_lb.ItemHeight = 41;
            this.MatchupListbox_lb.Location = new System.Drawing.Point(40, 225);
            this.MatchupListbox_lb.Name = "MatchupListbox_lb";
            this.MatchupListbox_lb.Size = new System.Drawing.Size(315, 248);
            this.MatchupListbox_lb.TabIndex = 5;
            // 
            // TeamName1_lbl
            // 
            this.TeamName1_lbl.AutoSize = true;
            this.TeamName1_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName1_lbl.Location = new System.Drawing.Point(399, 225);
            this.TeamName1_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TeamName1_lbl.Name = "TeamName1_lbl";
            this.TeamName1_lbl.Size = new System.Drawing.Size(138, 34);
            this.TeamName1_lbl.TabIndex = 6;
            this.TeamName1_lbl.Text = "<Team One>";
            // 
            // Score2_txt
            // 
            this.Score2_txt.Location = new System.Drawing.Point(471, 457);
            this.Score2_txt.Name = "Score2_txt";
            this.Score2_txt.Size = new System.Drawing.Size(137, 49);
            this.Score2_txt.TabIndex = 11;
            // 
            // Score2_lbl
            // 
            this.Score2_lbl.AutoSize = true;
            this.Score2_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2_lbl.Location = new System.Drawing.Point(399, 457);
            this.Score2_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Score2_lbl.Name = "Score2_lbl";
            this.Score2_lbl.Size = new System.Drawing.Size(63, 34);
            this.Score2_lbl.TabIndex = 10;
            this.Score2_lbl.Text = "Score";
            // 
            // TeamName2_lbl
            // 
            this.TeamName2_lbl.AutoSize = true;
            this.TeamName2_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName2_lbl.Location = new System.Drawing.Point(399, 408);
            this.TeamName2_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TeamName2_lbl.Name = "TeamName2_lbl";
            this.TeamName2_lbl.Size = new System.Drawing.Size(136, 34);
            this.TeamName2_lbl.TabIndex = 9;
            this.TeamName2_lbl.Text = "<Team Two>";
            // 
            // VS_lbl
            // 
            this.VS_lbl.AutoSize = true;
            this.VS_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VS_lbl.Location = new System.Drawing.Point(465, 348);
            this.VS_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.VS_lbl.Name = "VS_lbl";
            this.VS_lbl.Size = new System.Drawing.Size(53, 34);
            this.VS_lbl.TabIndex = 12;
            this.VS_lbl.Text = "-VS-";
            // 
            // Score_btn
            // 
            this.Score_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Score_btn.Location = new System.Drawing.Point(646, 328);
            this.Score_btn.Name = "Score_btn";
            this.Score_btn.Size = new System.Drawing.Size(124, 54);
            this.Score_btn.TabIndex = 13;
            this.Score_btn.Text = "Score";
            this.Score_btn.UseVisualStyleBackColor = true;
            // 
            // Score1_txt
            // 
            this.Score1_txt.Location = new System.Drawing.Point(471, 274);
            this.Score1_txt.Name = "Score1_txt";
            this.Score1_txt.Size = new System.Drawing.Size(137, 49);
            this.Score1_txt.TabIndex = 15;
            // 
            // Score1_lbl
            // 
            this.Score1_lbl.AutoSize = true;
            this.Score1_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score1_lbl.Location = new System.Drawing.Point(399, 274);
            this.Score1_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Score1_lbl.Name = "Score1_lbl";
            this.Score1_lbl.Size = new System.Drawing.Size(63, 34);
            this.Score1_lbl.TabIndex = 14;
            this.Score1_lbl.Text = "Score";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(813, 666);
            this.Controls.Add(this.Score1_txt);
            this.Controls.Add(this.Score1_lbl);
            this.Controls.Add(this.Score_btn);
            this.Controls.Add(this.VS_lbl);
            this.Controls.Add(this.Score2_txt);
            this.Controls.Add(this.Score2_lbl);
            this.Controls.Add(this.TeamName2_lbl);
            this.Controls.Add(this.TeamName1_lbl);
            this.Controls.Add(this.MatchupListbox_lb);
            this.Controls.Add(this.UnplayedOnly_cb);
            this.Controls.Add(this.RoundDropdown_cb);
            this.Controls.Add(this.Round_lbl);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Header_lbl);
            this.Font = new System.Drawing.Font("Myriad Pro Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Label Round_lbl;
        private System.Windows.Forms.ComboBox RoundDropdown_cb;
        private System.Windows.Forms.CheckBox UnplayedOnly_cb;
        private System.Windows.Forms.ListBox MatchupListbox_lb;
        private System.Windows.Forms.Label TeamName1_lbl;
        private System.Windows.Forms.TextBox Score2_txt;
        private System.Windows.Forms.Label Score2_lbl;
        private System.Windows.Forms.Label TeamName2_lbl;
        private System.Windows.Forms.Label VS_lbl;
        private System.Windows.Forms.Button Score_btn;
        private System.Windows.Forms.TextBox Score1_txt;
        private System.Windows.Forms.Label Score1_lbl;
    }
}

