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
    public partial class ManageTeam : Form
    {
        public ManageTeam()
        {
            InitializeComponent();
            TeamManager teamManager = new TeamManager();
            List<Lid> AllPlayers = teamManager.GetLidsByRole("Player");

            foreach (Lid player in AllPlayers)
            { 
                ListBoxLid.Items.Add(player);
            }
            ListBoxLid.DisplayMember = "Firstname";

            List<Lid> AllCoaches = teamManager.GetLidsByRole("Coach");
            foreach(Lid lid in AllCoaches)
            {
                CBCoach.Items.Add(lid); 
            }
            CBCoach.DisplayMember = "Firstname";

            List<Team> Allteams=teamManager.GetAllTeams();
            foreach (Team team in Allteams)
            { 
                CBAddTeam2.Items.Add(team);
            }
            CBAddTeam2.DisplayMember = "TeamName";
        }

        private void btnnnewteam_Click(object sender, EventArgs e)
        {
          
            Team team = new Team(txtboxTeamName.Text);
            TeamManager teamManager = new TeamManager();
              bool IsAdded = teamManager.AddNewTeam(team);
          
                if (IsAdded)
                {
                    MessageBox.Show("New Team has been added");
                }
                else
                {
                    MessageBox.Show("Please try Again!");
                }
            
         
            
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {
           
            Lid selectedcoach = CBCoach.SelectedItem as Lid;
            if (CBCoach.SelectedItem == null)
            {
                MessageBox.Show("Please select a coach.");
                return;
            }

            Coach coach = new Coach
            {
                LidID= selectedcoach.LidID,
                Firstname = selectedcoach.Firstname,
                Lastname = selectedcoach.Lastname,
                Email = selectedcoach.Email,
            };
            Team team=CBTeams.SelectedItem as Team;

            if (team != null)
            {
                TeamManager teamManager = new TeamManager();
                teamManager.AssignCoachToTeam(coach, team);
                MessageBox.Show($"The coach:{coach.Firstname} is now assigned to the team {team.TeamName}");

            }
            else
            {
                MessageBox.Show("No team available!");

            }
        }


        private void btnnewlid_Click(object sender, EventArgs e)
        {
            Player newplayer = ListBoxLid.SelectedItem as Player;

            Team team = CBAddTeam2.SelectedItem as Team;

            if (team == null || newplayer == null)
            {
                MessageBox.Show("Please make sure that the one of the lids and teams are chosen!");

            }
            TeamManager teamManager = new TeamManager();
            bool newlidIsAdded = teamManager.AddNewLid(newplayer, team);
            if (newlidIsAdded)
            {
                MessageBox.Show("New lid has been added to the team!");
            }
            else
            {
                MessageBox.Show("Please try again!");
            }


        }
    }
}
