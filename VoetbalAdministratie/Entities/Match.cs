using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class Match
    {
        private int Matchid;
        private DateTime matchdate;
        private Team teamone;
        private Team teamtwo;
        private Field field;
        public int MatchID
        {
            get { return Matchid; }
            private set { Matchid = value; }
        }

        public DateTime Matchdate
        {
            get { return matchdate; }
            set {
                if (value < DateTime.Now)
                    throw new ArgumentException("MatchDate cannot be in the past!");
                   matchdate = value; }
        }
        public Team TeamOne
        {
            get { return teamone; }
            set {
                if (value == null)
                    throw new ArgumentException("Team two cannot be null");
                if (teamone != null && teamone.TeamID == value.TeamID)
                    throw new ArgumentException("A team cannot play against itself");
                teamone = value; }
        }

        public Team TeamTwo
        {
            get { return teamtwo; }
            set {
                if (value == null)
                    throw new ArgumentException("Team two cannot be null");
                if (teamtwo != null && teamtwo.TeamID == value.TeamID)
                    throw new ArgumentException("A team cannot play against itself");
                teamtwo = value; }
        }
        public Field Field
        {
            get { return field; }
            set {
                if (value == null)
                    throw new ArgumentException("field cannot be null");
                field = value; }
        }



        public Match(DateTime matchdate,Team teamone,Team teamtwo,Field field)
        {
            Matchdate = matchdate;
            TeamOne = teamone;
            TeamTwo = teamtwo;
            Field = field;
        }
    }
}
