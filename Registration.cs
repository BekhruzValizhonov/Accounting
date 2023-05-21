using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            bool isChekedUser = false;
            if (userPs.Text.Trim() == "" && userName.Text.Trim() == "") return;

            if (!(userPs.Text.Length >= 3 && userName.Text.Length >= 3)) return;


            DBConnect dBConnect = new DBConnect();
            dBConnect.Connection();

            isChekedUser = CheckedUser(userName.Text, dBConnect.conn);
            if (isChekedUser)
            {
                MessageBox.Show("Такой пользовател существует");
                dBConnect.conn.Close();
                return;
            }

            string commandText = $"INSERT INTO person (name, password) VALUES (@name, @password)";
            NpgsqlCommand cmd = new NpgsqlCommand(commandText, dBConnect.conn);
            cmd.Parameters.AddWithValue("@name", userName.Text);
            cmd.Parameters.AddWithValue("@password", userPs.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Аккаунт создан");
            dBConnect.conn.Close();
            new mainScreen(userName.Text).Show();
        }

        private bool CheckedUser(string userName, NpgsqlConnection connection)
        {
            string name = "";
            string commandText = $"SELECT * FROM person WHERE name = @name";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("name", userName);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        name = reader["name"] as string;
                    }
                if (name == userName)
                {
                    return true;
                }
                return false;
            }
        }

        private void loginShow_Click(object sender, EventArgs e)
        {
            new Login().Show();
        }
    }
}