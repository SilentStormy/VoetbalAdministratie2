using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoetbalAdministratie
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            lbname.Text=Lid.loggedinUser.GetName();
        }

        private void btnteammanage_Click(object sender, EventArgs e)
        {
            ManageTeam manageTeam=new ManageTeam();
            manageTeam.ShowDialog();
            this.Close();
        }

        private void btnschedulematch_Click(object sender, EventArgs e)
        {
            ScheduleMatch scheduleMatch=new ScheduleMatch();
            scheduleMatch.ShowDialog(); 
            this.Close();
        }

        private void btnContribution_Click(object sender, EventArgs e)
        {
            ContributionPayment payment=new ContributionPayment();
            payment.ShowDialog();
            this.Close();
        }
    }
}
