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
    public partial class ScheduleMatch : Form
    {
        public ScheduleMatch()
        {
            InitializeComponent();
            TeamManager teamManager=new TeamManager();
            List<Team> allteams=teamManager.GetAllTeams();

            foreach (Team team in allteams)
            {
                CBTeamone.Items.Add(team);
                CBTeamtwo.Items.Add(team);

            }
            CBTeamone.DisplayMember = "TeamName";
            CBTeamone.ValueMember = "TeamID";
            
            CBTeamtwo.DisplayMember = "TeamName";
            CBTeamtwo.ValueMember = "TeamID";

            MatchOrganizer matchOrganizer = new MatchOrganizer();
            List<Field> allfields = matchOrganizer.GetField();
            foreach (Field field in allfields)
            {
                CBField.Items.Add(field);
            }
            CBField.DisplayMember = "Fieldname";

        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            MatchOrganizer matchorganizer=new MatchOrganizer();
            if (CBTeamone.SelectedItem == null || CBTeamtwo.SelectedItem== null|| CBField.SelectedItem ==null)
            {
                MessageBox.Show("Please choose two teams and a field");
                return;
            }

            Team teamone =CBTeamone.SelectedItem as Team;
            Team teamtwo=CBTeamtwo.SelectedItem as Team;
            Field field = CBField.SelectedItem as Field;


           

            if (teamone.TeamID == teamtwo.TeamID)
            {
                MessageBox.Show("A Team cannot play against itself!Please choose another team!");
                return;
            }
            DateTime MatchDate = dateTimePickerMatch.Value;

            FieldAvailability fieldAvailable = new FieldAvailability();
            
            if (!fieldAvailable.isFieldAvailable(field, MatchDate))
            {
                MessageBox.Show("This chosen field is not available! Please choose another one");
                return;
            }

            TeamAvailability teamAvailability = new TeamAvailability();
            if (!teamAvailability.isTeamAvailable(teamone, MatchDate) || !teamAvailability.isTeamAvailable(teamtwo, MatchDate))
            {
                MessageBox.Show("One of the teams has already a match planned, please choose another day!");
                return;
            }

            Match newMatch=new Match(MatchDate, teamone,teamtwo,field);
            bool isscheduled=matchorganizer.ScheduleMatch(newMatch);
            if (isscheduled)
            {
                MessageBox.Show("The match is scheduled!");
            }
            else
            {
                MessageBox.Show("Please Try Again!");
            }

        }
    }
}
