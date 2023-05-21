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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Examples
{
    public partial class IncomeDialog : Form
    {
        private string TextInput;
        private BindingSource Bs;
        private int CustomerId;


        public IncomeDialog(string textInput, int customerId, BindingSource bs)
        {
            InitializeComponent();
            TextInput = textInput;
            CustomerId = customerId;
            Bs = bs;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void successBtn_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            DBLogics dBLogics = new DBLogics();
            int pesonId = 0;
            CustomerId += 1;


            dBConnect.Connection();
            pesonId = dBLogics.GetPersonId(TextInput, dBConnect.conn);

            string commandText = $"INSERT INTO income (category, comment, price, date, person_id) VALUES (@category, @comment, @price, @date, @person_id)";
            NpgsqlCommand cmd = new NpgsqlCommand(commandText, dBConnect.conn);


            cmd.Parameters.AddWithValue("@category", categoryIncome.Text);
            cmd.Parameters.AddWithValue("@comment", commentIncome.Text);
            cmd.Parameters.AddWithValue("@price", numericIncome.Text);
            cmd.Parameters.AddWithValue("@date", dateIncome.Text);
            cmd.Parameters.AddWithValue("@person_id", pesonId);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно создан");

            dBConnect.conn.Close();

            Bs.Add(new CustomersIncome() { Id = Convert.ToString(CustomerId), Category = categoryIncome.Text, Comment = commentIncome.Text, Price = numericIncome.Text, Date = dateIncome.Text });

            Close();
        }
    }
}

