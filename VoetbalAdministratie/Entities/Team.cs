using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class Team
    {
        private int teamID;
        private string teamName;
        private int matchPoints;
        private readonly List<Lid> lids = new List<Lid>();
        private Coach coach;
       public int TeamID
        {
            get { return teamID; }
            set { teamID = value; }
        }
        public string TeamName
        {
            get { return teamName; }
            set {
                if (!string.IsNullOrWhiteSpace(teamName))
                    teamName = value;
                else throw new ArgumentException("Teamname cannot be empty!");
        } }

        public int MatchPoints
        {
            get { return matchPoints; }
             set {
                if (value < 0)
                throw new ArgumentException("Matchpoints cannot be negative");
                matchPoints = value; }
        }

        public Coach Coach
        {
            get { return coach; }
            set { coach = value; } }

        public Team(string name)
        {
            teamName = name;
        }
        public Team() { }
        public string GetName()
        {
            return teamName;
        }
    }
}

