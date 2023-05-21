using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class DBLogics
    {

        public int GetPersonId(string userName, NpgsqlConnection connection)
        {
            int personId = 0;
            string commandText = $"SELECT * FROM person WHERE (name) = (@name)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("name", userName);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        personId = (int)reader["id"];

                    }
                return personId;
            }
        }
    }
}
