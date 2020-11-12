using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_test
{
    class SqlTools : IDisposable
    {
        static private SqlConnection connection;
        static private SqlCommand command;
        public SqlDataReader reader;
        public static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True";
        internal static SqlDataReader executeReader(string query)
        {
                connection = new SqlConnection(connectionString);
                connection.Open();
                command = new SqlCommand(query, connection);
                return command.ExecuteReader();
        }
        internal static int executeScalar(string query)
        {
            using(connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }
        internal static int getRows(string table)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command = new SqlCommand("SELECT COUNT(*) FROM " + table, connection);
                return (int)command.ExecuteScalar();
            }
        }

        public void Dispose()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
