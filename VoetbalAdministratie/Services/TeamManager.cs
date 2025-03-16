using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class TeamManager
    {
        private string connectionstring = "server=localhost;database=smartfootballclub;user=root;password=Safa1998.";

        public bool AddNewTeam(Team team)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "INSERT INTO Team (TeamName) VALUES(@TeamName)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TeamName", team.TeamName);
                    int Rowaffected = cmd.ExecuteNonQuery();
                    return Rowaffected > 0;
                }
            }
        }
        public bool AssignCoachToTeam(Coach coach, Team team)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string Query = "UPDATE Team SET CoachId=@CoachId WHERE ID=@TeamId";
                using (MySqlCommand cmd = new MySqlCommand(Query, conn))
                {
                    cmd.Parameters.AddWithValue("@CoachId", coach.LidID);
                    cmd.Parameters.AddWithValue("@TeamId", team.TeamID);
                    int Rowaffected = cmd.ExecuteNonQuery();

                    if (Rowaffected > 0)
                    {
                        team.Coach = coach;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool AddNewLid(Lid lid, Team team)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {

                conn.Open();
                string query = "UPDATE Lid SET TeamId=@TeamId WHERE ID=@LidId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TeamId", team.TeamID);
                    cmd.Parameters.AddWithValue("@LidId", lid.LidID);

                    int rowaffected = cmd.ExecuteNonQuery();
                    return rowaffected > 0;

                }

            }
        }

        public List<Lid> GetLidsOfTeam()

        {
            List<Lid> AllLids = new List<Lid>();

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string Query = "SELECT ID, Firstname,Lastname,Email FROM Lid";
                using (MySqlCommand cmd = new MySqlCommand(Query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lid lid = new Lid
                            {
                                LidID= reader.GetInt32("ID"),
                                Firstname = reader.GetString("Firstname"),
                                Lastname = reader.GetString("Lastname"),
                                Email = reader.GetString("Email"),


                            };
                            AllLids.Add(lid);
                        }


                    }
                }
            }
            return AllLids;
        }
      
        public List<Lid> GetLidsByRole(string role)
        {
            List<Lid> lidsbyrole= new List<Lid>();
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open ();
                string Query = "SELECT ID,Firstname,Lastname,Email,Role FROM Lid WHERE Role=@Role";

                using(MySqlCommand cmd = new MySqlCommand(Query, conn))
                {
                    cmd.Parameters.AddWithValue("@Role", role);
                    using (MySqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while(reader.Read()) 
                        {
                            int id = reader.GetInt32("ID");
                            string firstname= reader.GetString("Firstname");
                            string lastname = reader.GetString("Lastname");
                            string email = reader.GetString("Email");
                            string rolefromdb = reader.GetString("Role");
                            Lid lid;
                            switch (rolefromdb)
                            {
                                case "Player":
                                    lid = new Player();
                                    break; 
                                case "Coach":
                                    lid = new Coach();
                                    break; 
                                
                                case "Director":
                                    lid = new Director();
                                    break;

                                default:
                                    lid =new Lid();
                                    break;

                            }
                            lid.LidID =id;
                            lid.Firstname=firstname;
                            lid.Lastname=lastname;
                            lid.Email=email;
                            lid.Role=rolefromdb;
                            
                            lidsbyrole.Add(lid);
                        
                        }

                    }
                        
                }
            }
            return lidsbyrole;
        }

        public List<Team> GetAllTeams()
        {
            List<Team> allteams = new List<Team>();

            using (MySqlConnection conn = new MySqlConnection(connectionstring)) 
            { 
                conn.Open();
                string query = "SELECT TeamId,TeamName,MatchPoints FROM team";
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader ()) 
                    {

                        while (reader.Read())
                        {
                            Team team= new Team
                            {
                                TeamID = reader.GetInt32("TeamId"),
                                TeamName = reader.GetString("TeamName"),
                                MatchPoints = reader.GetInt32("MatchPoints"),
                            
                            };
                            allteams.Add(team);
                        }
                    }
                }
            }
            return allteams;


         }
    }
}
