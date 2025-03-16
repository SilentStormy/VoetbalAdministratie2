using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class FieldAvailability
    {
        private const string connectionstring = "server=localhost;database=smartfootballclub;user=root;password=Safa1998.";

        public bool isFieldAvailable(Field field, DateTime matchdate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();
                string Query = "SELECT COUNT(*) FROM Matchs WHERE FieldID=@FieldID AND MatchDate=@MatchDate";
                using (MySqlCommand cmd = new MySqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@FieldID", field.FieldID);
                    cmd.Parameters.AddWithValue("@MatchDate", matchdate.Date);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0;
                }

            }
        }
    }
}

