namespace VoetbalAdministratie
{
    partial class ScheduleMatch
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
            this.CBTeamone = new System.Windows.Forms.ComboBox();
            this.CBTeamtwo = new System.Windows.Forms.ComboBox();
            this.dateTimePickerMatch = new System.Windows.Forms.DateTimePicker();
            this.BtnSchedule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CBTeamone
            // 
            this.CBTeamone.FormattingEnabled = true;
            this.CBTeamone.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CBTeamone.Location = new System.Drawing.Point(69, 66);
            this.CBTeamone.Name = "CBTeamone";
            this.CBTeamone.Size = new System.Drawing.Size(210, 24);
            this.CBTeamone.TabIndex = 0;
            this.CBTeamone.SelectedIndexChanged += new System.EventHandler(this.BtnSchedule_Click);
            // 
            // CBTeamtwo
            // 
            this.CBTeamtwo.FormattingEnabled = true;
            this.CBTeamtwo.Location = new System.Drawing.Point(69, 126);
            this.CBTeamtwo.Name = "CBTeamtwo";
            this.CBTeamtwo.Size = new System.Drawing.Size(210, 24);
            this.CBTeamtwo.TabIndex = 1;
            // 
            // dateTimePickerMatch
            // 
            this.dateTimePickerMatch.Location = new System.Drawing.Point(69, 240);
            this.dateTimePickerMatch.Name = "dateTimePickerMatch";
            this.dateTimePickerMatch.Size = new System.Drawing.Size(210, 22);
            this.dateTimePickerMatch.TabIndex = 2;
            // 
            // BtnSchedule
            // 
            this.BtnSchedule.Location = new System.Drawing.Point(98, 277);
            this.BtnSchedule.Name = "BtnSchedule";
            this.BtnSchedule.Size = new System.Drawing.Size(124, 30);
            this.BtnSchedule.TabIndex = 3;
            this.BtnSchedule.Text = "Schedule";
            this.BtnSchedule.UseVisualStyleBackColor = true;
            this.BtnSchedule.Click += new System.EventHandler(this.BtnSchedule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose the first team:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose the second team:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose a date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose the field:";
            // 
            // CBField
            // 
            this.CBField.FormattingEnabled = true;
            this.CBField.Location = new System.Drawing.Point(69, 180);
            this.CBField.Name = "CBField";
            this.CBField.Size = new System.Drawing.Size(210, 24);
            this.CBField.TabIndex = 7;
            // 
            // ScheduleMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 323);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSchedule);
            this.Controls.Add(this.dateTimePickerMatch);
            this.Controls.Add(this.CBTeamtwo);
            this.Controls.Add(this.CBTeamone);
            this.Name = "ScheduleMatch";
            this.Text = "ScheduleMAtch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTeamone;
        private System.Windows.Forms.ComboBox CBTeamtwo;
        private System.Windows.Forms.DateTimePicker dateTimePickerMatch;
        private System.Windows.Forms.Button BtnSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBField;
    }
}