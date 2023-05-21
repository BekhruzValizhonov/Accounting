using Npgsql;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace Examples
{
    internal class DBConnect
    {
        public string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=root;Database=Accounting;";
        public string tableName = "person";
        public NpgsqlConnection conn;

        public void Connection()
        {
            conn = new NpgsqlConnection(connectionString);
            conn.Open();
        }
    }
}
