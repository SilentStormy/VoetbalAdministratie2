using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class MatchOrganizer
    {
        private string connectionstring = "server=localhost;database=smartfootballclub;user=root;password=Safa1998.";

        public bool ScheduleMatch(Match match)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "INSERT INTO matchs(MatchDate,MatchTime,TeamOneID,TeamTwoID,FieldID)" + "VALUES (@Matchdate,@MatchTime,@TeamOneID,@TeamTwoID,@FieldID)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Matchdate", match.Matchdate);
                    cmd.Parameters.AddWithValue("@MatchTime", match.Matchdate);
                    cmd.Parameters.AddWithValue("@TeamOneID", match.TeamOne.TeamID);
                    cmd.Parameters.AddWithValue("@TeamTwoID", match.TeamTwo.TeamID);
                    cmd.Parameters.AddWithValue("@FieldID", match.Field.FieldID);

                    int RowAffected = cmd.ExecuteNonQuery();
                    return RowAffected > 0;

                }
            }
        }

        public List<Field> GetField()
        {
            List<Field> Fields = new List<Field>();

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "SELECT ID, FieldName FROM field";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Field field = new Field
                            {
                                FieldID = reader.GetInt32("ID"),
                                Fieldname = reader.GetString("FieldName"),

                            };
                            Fields.Add(field);

                        }

                    }
                    return Fields;

                }
            }
        }
    }
}
        
