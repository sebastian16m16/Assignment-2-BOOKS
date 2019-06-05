using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Assignment2.DataBase;

namespace Assignment2.Model
{
    class Login
    {

        public int login_id;
        public string username;
        public string password;
        public bool admin;


        DBConnection dBConnection = new DBConnection();

        public Login() { }

        public Login(String username, String password, bool admin)
        {
            this.username = username;
            this.password = password;
            this.admin = admin;
        }

        public bool loginExists()
        {
            String stmt = "Select * from login where username = @username";

            using(SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
            {
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    return true;
            }

            return false;
        }

        public bool createLogin()
        {

            if (!loginExists())
            {
                String stmt = "Insert into Login (username, password, admin) values (@username, @password, @admin)";

                using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@admin", admin);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Login created!");
                    return true;
                }
            }
            return false;
        }

        public void updateLoginObject()
        {
            if (login_id != 0)
            {
                String stmt = "Select * from login where login_id = @login_id";

                using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
                {
                    command.Parameters.AddWithValue("@login_id", login_id);
                    command.ExecuteNonQuery();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this.login_id = reader.GetInt32(0);
                            this.username = reader.GetString(1);
                            this.password = reader.GetString(2);
                            this.admin = reader.GetBoolean(3);
                        }
                    }
                }
            }

            if (username != null)
            {
                String stmt = "Select * from login where username = @username";

                using (SqlCommand command = new SqlCommand(stmt, dBConnection.getConnection()))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.ExecuteNonQuery();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            this.login_id = reader.GetInt32(0);
                            this.username = reader.GetString(1);
                            this.password = reader.GetString(2);
                            this.admin = reader.GetBoolean(3);
                        }
                    }
                }
            }
        }
    }
}
