using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoetbalAdministratie
{
    public class FinancialManager
    {
        private string connectionstring = "server=localhost;database=smartfootballclub;user=root;password=Safa1998.";


        public bool HasPaid(Lid lid)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string Query = "SELECT COUNT(*) FROM Contribution WHERE LidID=@LidID AND isPaid=TRUE";
                using (MySqlCommand cmd = new MySqlCommand(Query, conn))
                {
                    cmd.Parameters.AddWithValue("@LidID",lid.LidID);
                    return Convert.ToInt32(cmd.ExecuteScalar())>0;
                }
            }
        }

        public bool ProcessPayment(Lid lid, double amount)
        {
            using (var conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string checkingquery = "SELECT COUNT(*) FROM Contribution WHERE LidId=@lidId AND isPaid=1";

                using (var checkcmd = new MySqlCommand(checkingquery, conn))
                {
                    checkcmd.Parameters.AddWithValue("@LidId", lid.LidID);
                    int paymentstatus = Convert.ToInt32(checkcmd.ExecuteScalar());
                    if (paymentstatus > 0)
                    {
                        return false;
                    }


                }
                string processquery = "INSERT INTO Contribution (Rate,Paymentdate,LidId,isPaid) VALUES(@Rate,@Paymentdate,@LidId,TRUE)";
                using (var cmd = new MySqlCommand(processquery, conn))
                {
                    cmd.Parameters.AddWithValue("@Rate", amount);
                    cmd.Parameters.AddWithValue("@Paymentdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@LidId", lid.LidID);
                    return cmd.ExecuteNonQuery() > 0;

                }
            }
        }

       
        public bool CheckPaymentStatus(Lid lid)
        {
            PaymentStatus paymentstatus = new PaymentStatus();
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "SELECT isPaid FROM Paymentstatus WHERE lidID=@LidId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LidID", lid.LidID);
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            paymentstatus.IsPaid = reader.GetBoolean("isPaid");
                        }
                    }
                }
            }
            return false;       
        }
    }
}
