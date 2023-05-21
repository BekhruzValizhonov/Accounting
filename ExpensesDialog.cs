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
    public partial class ExpensesDialog : Form
    {
        private string TextInput;
        private BindingSource Bs;
        private int CustomerId;


        public ExpensesDialog(string textInput, BindingSource bs, int customerId)
        {
            InitializeComponent();
            TextInput = textInput;
            Bs = bs;
            CustomerId = customerId;
        }

        private void successBtn_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            DBLogics dBLogics = new DBLogics();
            int pesonId = 0;
            CustomerId += 1;



            dBConnect.Connection();
            pesonId = dBLogics.GetPersonId(TextInput, dBConnect.conn);

            string commandText = $"INSERT INTO expenses (category, comment, price, date, person_id) VALUES (@category, @comment, @price, @date, @person_id)";
            NpgsqlCommand cmd = new NpgsqlCommand(commandText, dBConnect.conn);


            cmd.Parameters.AddWithValue("@category", categoryExpense.Text);
            cmd.Parameters.AddWithValue("@comment", commentExpense.Text);
            cmd.Parameters.AddWithValue("@price", numericExpense.Text);
            cmd.Parameters.AddWithValue("@date", dateExpense.Text);
            cmd.Parameters.AddWithValue("@person_id", pesonId);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Успешно создан");

            dBConnect.conn.Close();
            Bs.Add(new Customers() { Id = Convert.ToString(CustomerId), Category = categoryExpense.Text, Comment = commentExpense.Text, Price = numericExpense.Text, Date = dateExpense.Text });
            Close();
        }

        private void cancelExpense_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
