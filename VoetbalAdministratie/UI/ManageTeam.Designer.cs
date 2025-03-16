namespace VoetbalAdministratie
{
    partial class ManageTeam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnnewteam = new System.Windows.Forms.Button();
            this.txtboxTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBCoach = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnaddnewlid = new System.Windows.Forms.Button();
            this.ListBoxLid = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBTeams = new System.Windows.Forms.ComboBox();
            this.BtnAssign = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CBAddTeam2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnnewteam);
            this.groupBox1.Controls.Add(this.txtboxTeamName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Team";
            // 
            // btnnnewteam
            // 
            this.btnnnewteam.Location = new System.Drawing.Point(43, 193);
            this.btnnnewteam.Name = "btnnnewteam";
            this.btnnnewteam.Size = new System.Drawing.Size(115, 30);
            this.btnnnewteam.TabIndex = 2;
            this.btnnnewteam.Text = "Add";
            this.btnnnewteam.UseVisualStyleBackColor = true;
            this.btnnnewteam.Click += new System.EventHandler(this.btnnnewteam_Click);
            // 
            // txtboxTeamName
            // 
            this.txtboxTeamName.Location = new System.Drawing.Point(31, 102);
            this.txtboxTeamName.Multiline = true;
            this.txtboxTeamName.Name = "txtboxTeamName";
            this.txtboxTeamName.Size = new System.Drawing.Size(162, 30);
            this.txtboxTeamName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert the name of the team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose one of the coaches";
            // 
            // CBCoach
            // 
            this.CBCoach.AllowDrop = true;
            this.CBCoach.FormattingEnabled = true;
            this.CBCoach.Location = new System.Drawing.Point(31, 126);
            this.CBCoach.Name = "CBCoach";
            this.CBCoach.Size = new System.Drawing.Size(162, 24);
            this.CBCoach.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBAddTeam2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnaddnewlid);
            this.groupBox2.Controls.Add(this.ListBoxLid);
            this.groupBox2.Location = new System.Drawing.Point(302, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Lid To The Team";
            // 
            // btnaddnewlid
            // 
            this.btnaddnewlid.Location = new System.Drawing.Point(54, 193);
            this.btnaddnewlid.Name = "btnaddnewlid";
            this.btnaddnewlid.Size = new System.Drawing.Size(115, 30);
            this.btnaddnewlid.TabIndex = 3;
            this.btnaddnewlid.Text = "Add";
            this.btnaddnewlid.UseVisualStyleBackColor = true;
            this.btnaddnewlid.Click += new System.EventHandler(this.btnnewlid_Click);
            // 
            // ListBoxLid
            // 
            this.ListBoxLid.FormattingEnabled = true;
            this.ListBoxLid.ItemHeight = 16;
            this.ListBoxLid.Location = new System.Drawing.Point(17, 25);
            this.ListBoxLid.Name = "ListBoxLid";
            this.ListBoxLid.Size = new System.Drawing.Size(179, 84);
            this.ListBoxLid.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBTeams);
            this.groupBox3.Controls.Add(this.CBCoach);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.BtnAssign);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(570, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 238);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assign Coach to the team";
            // 
            // CBTeams
            // 
            this.CBTeams.AllowDrop = true;
            this.CBTeams.FormattingEnabled = true;
            this.CBTeams.Location = new System.Drawing.Point(31, 53);
            this.CBTeams.Name = "CBTeams";
            this.CBTeams.Size = new System.Drawing.Size(162, 24);
            this.CBTeams.TabIndex = 4;
            // 
            // BtnAssign
            // 
            this.BtnAssign.Location = new System.Drawing.Point(63, 193);
            this.BtnAssign.Name = "BtnAssign";
            this.BtnAssign.Size = new System.Drawing.Size(115, 30);
            this.BtnAssign.TabIndex = 2;
            this.BtnAssign.Text = "Assign";
            this.BtnAssign.UseVisualStyleBackColor = true;
            this.BtnAssign.Click += new System.EventHandler(this.BtnAssign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose the team";
            // 
            // CBAddTeam2
            // 
            this.CBAddTeam2.AllowDrop = true;
            this.CBAddTeam2.FormattingEnabled = true;
            this.CBAddTeam2.Location = new System.Drawing.Point(17, 151);
            this.CBAddTeam2.Name = "CBAddTeam2";
            this.CBAddTeam2.Size = new System.Drawing.Size(162, 24);
            this.CBAddTeam2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose the team";
            // 
            // ManageTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "ManageTeam";
            this.Text = "S";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnnnewteam;
        private System.Windows.Forms.TextBox txtboxTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddnewlid;
        private System.Windows.Forms.ListBox ListBoxLid;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox CBCoach;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox CBTeams;
        private System.Windows.Forms.Button BtnAssign;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox CBAddTeam2;
        private System.Windows.Forms.Label label4;
    }
}