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
    public partial class mainScreen : Form
    {

        public string TextInput;
        public int CustomerExpensesId = 0;
        public int CustomerIncomeId = 0;

        public mainScreen(string textInput)
        {
            InitializeComponent();
            TextInput = textInput;
        }

        private void incomesBtn_Click(object sender, EventArgs e)
        {
            var bs = customersIncomeBindingSource;
            IncomeDialog incomeDialog = new IncomeDialog(TextInput, CustomerIncomeId, bs);
            incomeDialog.ShowDialog();
        }

        private void expensesBtn_Click(object sender, EventArgs e)
        {
            var bs = customersBindingSource;
            ExpensesDialog expensesDialog = new ExpensesDialog(TextInput, bs, CustomerExpensesId);
            expensesDialog.ShowDialog();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {

            DBConnect dBConnect = new DBConnect();
            DBLogics dBLogics = new DBLogics();
            int pesonId = 0;
            long totalPriceIncome = 0;
            long totalPriceExpenses = 0;

            dBConnect.Connection();
            pesonId = dBLogics.GetPersonId(TextInput, dBConnect.conn);
            string commandTextExpenses = $"SELECT * FROM expenses WHERE (person_id) = (@person_id)";
            string commandTextIncome = $"SELECT * FROM income WHERE (person_id) = (@person_id)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandTextExpenses, dBConnect.conn))
            {
                cmd.Parameters.AddWithValue("person_id", pesonId);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        customersBindingSource.Add(new Customers() { Id = Convert.ToString(reader["id"]), Category = reader["category"] as string, Comment = reader["comment"] as string, Price = reader["price"] as string, Date = reader["date"] as string });
                        totalPriceExpenses += Convert.ToInt64(reader["price"]);
                        CustomerExpensesId = (int)reader["id"];

                    }
            }

            using (NpgsqlCommand cmd = new NpgsqlCommand(commandTextIncome, dBConnect.conn))
            {
                cmd.Parameters.AddWithValue("person_id", pesonId);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        customersIncomeBindingSource.Add(new CustomersIncome() { Id = Convert.ToString(reader["id"]), Category = reader["category"] as string, Comment = reader["comment"] as string, Price = reader["price"] as string, Date = reader["date"] as string });
                        totalPriceIncome += Convert.ToInt64(reader["price"]);
                        CustomerIncomeId = (int)reader["id"];
                    }
            }
            incomeTotal.Text = totalPriceIncome.ToString();
            expensesTotal.Text = totalPriceExpenses.ToString();
            dBConnect.conn.Close();
        }

    
    }
}
