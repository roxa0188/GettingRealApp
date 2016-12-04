using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseTest
{
    class Program
    {
        private static string connectionString =
            "Server=ealdb1.eal.local; Database=ejl87_db; User Id=ejl87_usr; Password=Baz1nga87;";
        SqlConnection conn = new SqlConnection
               (@"Data Source = ealdb1.eal.local;
                 Database = EJL87_DB;
                 User ID = ejl87_usr;
                 Password = Baz1nga87"
               );
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Menu();

        }
        private void Menu()
        {

            Console.WriteLine("Commands:\n1) View List\n2) Insert new user\n3) Exit");
            Console.WriteLine("Please input your command:");
            string input = Console.ReadLine();
            Console.Clear();
            int x = Convert.ToInt32(input);
            switch (x)
            {
                case 1: PlayerInfo(); break;
                case 2: InsertUser(); break;
                case 3: break;
            }
        }
        private string GetInput(string v)
        {
            return Console.ReadLine();
        }
        private void PlayerInfo()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmdShowPlayerInfo = new SqlCommand("ShowPlayerInfo", con);
                cmdShowPlayerInfo.CommandType = CommandType.StoredProcedure;


                SqlDataReader reader = cmdShowPlayerInfo.ExecuteReader();
                while (reader.Read())
                {
                    string PlayerFirstName = reader["PlayerFirstName"].ToString();
                    string PlayerLastName = reader["PlayerLastName"].ToString();
                    string PlayerEmail = reader["PlayerEmail"].ToString();
                    string PlayerPhone = reader["PlayerPhone"].ToString();
                    string PlayerUserName = reader["PlayerUserName"].ToString();
                    Console.WriteLine(PlayerFirstName + " " + PlayerLastName + " " + PlayerEmail + " " + PlayerPhone + " " + PlayerUserName);
                }
                Console.ReadKey();
                con.Close();
                Console.Clear();
                Menu();
            }
        }
        private void InsertUser()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("Insert_user", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string input;
                con.Open();
                Console.WriteLine("Please insert Firstname:");
                input = GetInput("PlayerFirstName");
                cmd.Parameters.Add(new SqlParameter("PlayerFirstName", input));
                Console.WriteLine("Please insert Lastname:");
                input = GetInput("PlayerLastName");
                cmd.Parameters.Add(new SqlParameter("PlayerLastName", input));
                Console.WriteLine("Please insert Player Email:");
                input = GetInput("PlayerEmail");
                cmd.Parameters.Add(new SqlParameter("PlayerEmail", input));
                Console.WriteLine("Please insert Player Phone:");
                input = GetInput("PlayerPhone");
                cmd.Parameters.Add(new SqlParameter("PlayerPhone", input));
                Console.WriteLine("Please insert Username:");
                input = GetInput("PlayerUserName");
                cmd.Parameters.Add(new SqlParameter("PlayerUserName", input));
                Console.WriteLine("Please insert Password:");
                input = GetInput("PlayerPassword");
                cmd.Parameters.Add(new SqlParameter("PlayerPassword", input));
                cmd.ExecuteNonQuery();
                Console.WriteLine("User added succesfully");
                Console.ReadKey();
                con.Close();
                Console.Clear();
                Menu();
            }
            Console.WriteLine("Person Added :)");

        }

    }
}

