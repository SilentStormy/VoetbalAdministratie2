namespace VoetbalAdministratie
{
    partial class Dashboard
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
            this.lbname = new System.Windows.Forms.Label();
            this.btnteammanage = new System.Windows.Forms.Button();
            this.btnschedulematch = new System.Windows.Forms.Button();
            this.btnContribution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(301, 28);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(0, 16);
            this.lbname.TabIndex = 0;
            // 
            // btnteammanage
            // 
            this.btnteammanage.Location = new System.Drawing.Point(47, 28);
            this.btnteammanage.Name = "btnteammanage";
            this.btnteammanage.Size = new System.Drawing.Size(134, 32);
            this.btnteammanage.TabIndex = 1;
            this.btnteammanage.Text = "Team Management";
            this.btnteammanage.UseVisualStyleBackColor = true;
            this.btnteammanage.Click += new System.EventHandler(this.btnteammanage_Click);
            // 
            // btnschedulematch
            // 
            this.btnschedulematch.Location = new System.Drawing.Point(47, 78);
            this.btnschedulematch.Name = "btnschedulematch";
            this.btnschedulematch.Size = new System.Drawing.Size(134, 32);
            this.btnschedulematch.TabIndex = 2;
            this.btnschedulematch.Text = "Schedule Match";
            this.btnschedulematch.UseVisualStyleBackColor = true;
            this.btnschedulematch.Click += new System.EventHandler(this.btnschedulematch_Click);
            // 
            // btnContribution
            // 
            this.btnContribution.Location = new System.Drawing.Point(47, 126);
            this.btnContribution.Name = "btnContribution";
            this.btnContribution.Size = new System.Drawing.Size(134, 32);
            this.btnContribution.TabIndex = 3;
            this.btnContribution.Text = "Pay Contribution";
            this.btnContribution.UseVisualStyleBackColor = true;
            this.btnContribution.Click += new System.EventHandler(this.btnContribution_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 185);
            this.Controls.Add(this.btnContribution);
            this.Controls.Add(this.btnschedulematch);
            this.Controls.Add(this.btnteammanage);
            this.Controls.Add(this.lbname);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button btnteammanage;
        private System.Windows.Forms.Button btnschedulematch;
        private System.Windows.Forms.Button btnContribution;
    }
}