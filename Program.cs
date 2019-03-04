using Npgsql;
using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySqlConnector.Core;

namespace DbTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Npgsql();
            //SqlClient();
            //MySqlConnector();
        }

        static void Npgsql()
        {
            Console.WriteLine("Running Npgsql test");

            const string connstring = "Host=localhost;Database=npgsql_tests;Username=npgsql_tests;Password=npgsql_tests";
            using (var conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
            }
        }

        static void SqlClient()
        {
            Console.WriteLine("Running SqlClient test");

            const string connstring = "Data Source=(LocalDB)\\MSSQLLocalDB";
            using (var conn = new SqlConnection(connstring))
            {
                conn.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = null;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void MySqlConnector()
        {
            Console.WriteLine("Running MySqlConnector test");

            const string connstring = "Server=localhost;User ID=roji;Password=scsicd;Database=Local Instance MySQL80";
            using (var conn = new MySqlConnection(connstring))
            {
                conn.Open();
            }
        }
    }
}
