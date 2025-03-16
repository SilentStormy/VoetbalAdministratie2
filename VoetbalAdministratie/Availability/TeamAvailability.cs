using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class TeamAvailability
    {
        private const string connectionstring = "server=localhost;database=smartfootballclub;user=root;password=Safa1998.";

        public bool isTeamAvailable(Team team,DateTime matchdate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                string Query = "SELECT COUNT(*) FROM Team WHERE TeamId=@TeamId AND Matchdate=@Matchdate";
                using (MySqlCommand command = new MySqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@TeamId", team.TeamID);
                    command.Parameters.AddWithValue("@Matchdate", matchdate);

                    int count=Convert.ToInt32(command.ExecuteScalar());
                    return count == 0;
                }
            }
           
        }
    }
}
