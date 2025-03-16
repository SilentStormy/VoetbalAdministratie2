using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalAdministratie
{
    public class MembershipManager
    {
        private string connectionstring = "server=localhost;database=smartfootballclub;user=root;password=Safa1998.";
              
        public void Register(Lid lid)
        {
           using(MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "INSERT INTO Lid (Firstname,Lastname,DateOfBirth, Email, Password,Role) VALUES (@Firstname, @Lastname, @DateOfBirth, @Email, @Password,@Role)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Firstname", lid.Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", lid.Lastname);
                    cmd.Parameters.AddWithValue("@DateOfBirth", lid.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Email", lid.Email);
                    cmd.Parameters.AddWithValue("@Password", lid.Password);
                    cmd.Parameters.AddWithValue("@Role",lid.Role);
                    cmd.ExecuteNonQuery();
                }    
            }
        }

        public bool Login(Lid lid)
        {
            using(MySqlConnection con = new MySqlConnection(connectionstring))
            {
                con.Open();
                string query = "SELECT ID, Firstname, Lastname, Email FROM Lid WHERE Email=@Email AND Password=@Password";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email",lid.Email);
                    cmd.Parameters.AddWithValue("@Password",lid.Password);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Lid loggedinUser = new Lid
                            {
                                LidID= reader.GetInt32("ID"),
                                Firstname = reader.GetString("Firstname"),
                                Lastname = reader.GetString("Lastname"),
                                Email = reader.GetString("Email"),
                            };

                            Lid.AddLoggedInUser(loggedinUser);
                            return true;
                        }
                      
                    }
                }
            }
            return false;

        }
    }
}
