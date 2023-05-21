using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool isChekedUser = false;

            if (userPs.Text.Trim() == "" && userName.Text.Trim() == "") return;


            DBConnect dBConnect = new DBConnect();
            dBConnect.Connection();

            isChekedUser = CheckedUser(userName.Text, userPs.Text, dBConnect.conn);

            if (!isChekedUser)
            {
                MessageBox.Show("Ошибка введите заново");
                dBConnect.conn.Close();
                return;
            }

            MessageBox.Show("Добро пожаловать");


            dBConnect.conn.Close();

            new mainScreen(userName.Text).Show();

        }
        private bool CheckedUser(string userName, string userPassword, NpgsqlConnection connection)
        {
            string name = "";
            string password = "";

            string commandText = $"SELECT * FROM person WHERE (name, password) = (@name, @password)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("name", userName);
                cmd.Parameters.AddWithValue("password", userPassword);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        name = reader["name"] as string;
                        password = reader["password"] as string;
                    }
                if (name == userName && password == userPassword)
                {
                    return true;
                }
                return false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void registerShow_Click(object sender, EventArgs e)
        {
            new Registration().Show();
        }
    }
}
