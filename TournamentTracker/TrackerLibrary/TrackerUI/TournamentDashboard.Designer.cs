namespace TrackerUI
{
    partial class TournamentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboard));
            this.Header_lbl = new System.Windows.Forms.Label();
            this.LoadTournament_cb = new System.Windows.Forms.ComboBox();
            this.LoadTournament_lbl = new System.Windows.Forms.Label();
            this.LoadTournament_btn = new System.Windows.Forms.Button();
            this.CreateTournament_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header_lbl
            // 
            this.Header_lbl.AutoSize = true;
            this.Header_lbl.Font = new System.Drawing.Font("Myriad Pro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_lbl.Location = new System.Drawing.Point(108, 40);
            this.Header_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Header_lbl.Name = "Header_lbl";
            this.Header_lbl.Size = new System.Drawing.Size(501, 58);
            this.Header_lbl.TabIndex = 1;
            this.Header_lbl.Text = "Tournament Dashboard\r\n";
            // 
            // LoadTournament_cb
            // 
            this.LoadTournament_cb.Font = new System.Drawing.Font("Myriad Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournament_cb.FormattingEnabled = true;
            this.LoadTournament_cb.Location = new System.Drawing.Point(175, 210);
            this.LoadTournament_cb.Name = "LoadTournament_cb";
            this.LoadTournament_cb.Size = new System.Drawing.Size(367, 40);
            this.LoadTournament_cb.TabIndex = 5;
            // 
            // LoadTournament_lbl
            // 
            this.LoadTournament_lbl.AutoSize = true;
            this.LoadTournament_lbl.Font = new System.Drawing.Font("Myriad Pro Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournament_lbl.Location = new System.Drawing.Point(222, 169);
            this.LoadTournament_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LoadTournament_lbl.Name = "LoadTournament_lbl";
            this.LoadTournament_lbl.Size = new System.Drawing.Size(270, 38);
            this.LoadTournament_lbl.TabIndex = 4;
            this.LoadTournament_lbl.Text = "Load Existing Tournament";
            // 
            // LoadTournament_btn
            // 
            this.LoadTournament_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournament_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournament_btn.Location = new System.Drawing.Point(267, 290);
            this.LoadTournament_btn.Name = "LoadTournament_btn";
            this.LoadTournament_btn.Size = new System.Drawing.Size(183, 57);
            this.LoadTournament_btn.TabIndex = 28;
            this.LoadTournament_btn.Text = "Load Tournament";
            this.LoadTournament_btn.UseVisualStyleBackColor = true;
            // 
            // CreateTournament_btn
            // 
            this.CreateTournament_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournament_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournament_btn.Location = new System.Drawing.Point(253, 367);
            this.CreateTournament_btn.Name = "CreateTournament_btn";
            this.CreateTournament_btn.Size = new System.Drawing.Size(210, 76);
            this.CreateTournament_btn.TabIndex = 29;
            this.CreateTournament_btn.Text = "Create Tournament";
            this.CreateTournament_btn.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(716, 487);
            this.Controls.Add(this.CreateTournament_btn);
            this.Controls.Add(this.LoadTournament_btn);
            this.Controls.Add(this.LoadTournament_cb);
            this.Controls.Add(this.LoadTournament_lbl);
            this.Controls.Add(this.Header_lbl);
            this.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TournamentDashboard";
            this.Text = "TournamentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header_lbl;
        private System.Windows.Forms.ComboBox LoadTournament_cb;
        private System.Windows.Forms.Label LoadTournament_lbl;
        private System.Windows.Forms.Button LoadTournament_btn;
        private System.Windows.Forms.Button CreateTournament_btn;
    }
}