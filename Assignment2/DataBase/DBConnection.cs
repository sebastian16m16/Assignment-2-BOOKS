using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment2.DataBase
{
    class DBConnection
    {
        static string connectionString = "Data Source=DESKTOP-EJFE3EN\\SQLEXPRESS;Initial Catalog=Book;Integrated Security=True";

        SqlConnection connection;
                                                                        
        public SqlConnection getConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            //if(connection.State == System.Data.ConnectionState.Open)
            //{
            //    MessageBox.Show("Connection Established!");
            //}
            return connection;
        }

        public string getConnectionString()
        {
            return connectionString;
        }

        public void closeConnection()
        {
            connection.Close();
            MessageBox.Show("Connection Interrupted!");
        }
    }
}
