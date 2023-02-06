using Npgsql;
using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Kopilka
{
    public partial class Main_Window : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
            "User id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres", "310504", "savings_history");

        private NpgsqlConnection connection;
        private string sql;
        private NpgsqlCommand command;
        private string stringSql ;
        private DateTime Date;

        private int total_income_values = 0;
        private int payment_for_housing_values = 0;
        private int communal_payments_values = 0;
        private int other_expenses_values = 0;
        private int taxes_values = 0;
        private int deferred_part_default_values = 0;
        private int deferred_part_values = 0;
        public Main_Window()
        {
            InitializeComponent();

            connection = new NpgsqlConnection(connstring);

            total_income.Text = "0";
            payment_for_housing.Text = "0";
            communal_payments.Text = "0";
            other_expenses.Text = "0";
            taxes.Text = "0";

        }

        private void Main_Window_Load(object sender, EventArgs e)
        {

        }

        private void savings_history_Click(object sender, EventArgs e)
        {
            Savings_History savings_History = new Savings_History();
            savings_History.Show();
        }

        private void calculation_Click(object sender, EventArgs e)
        {
            total_income_values = int.Parse(total_income.Text);
            payment_for_housing_values = int.Parse(payment_for_housing.Text);
            communal_payments_values = int.Parse(communal_payments.Text);
            other_expenses_values = int.Parse(other_expenses.Text);
            taxes_values = int.Parse(taxes.Text);
            deferred_part_default_values = total_income_values / 10;
            deferred_part_values = total_income_values - (payment_for_housing_values + communal_payments_values + other_expenses_values + taxes_values);
            if (deferred_part_default_values <= deferred_part_values)
            {
                Date = DateTime.Now;
                try
                {
                    connection.Open();
                    sql = "insert into accumulation (set_aside_money, deposit_date) values (@_deferred_part_values, @_date)";
                    command = new NpgsqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@_deferred_part_values", deferred_part_values);
                    command.Parameters.AddWithValue("@_date", Date);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Внесён депозит равный " + deferred_part_values + "");
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            else
            {
                deferred_part_values = deferred_part_default_values - deferred_part_values;

                MessageBox.Show("Сумма которая вы хотите отложить меньше 10-ой части поэтому рекомендую уменьшить прочие расходы на :" + deferred_part_values);
            }
        }

        private void get_file_Click(object sender, EventArgs e)
        {
            total_income_values = int.Parse(total_income.Text);
            payment_for_housing_values = int.Parse(payment_for_housing.Text);
            communal_payments_values = int.Parse(communal_payments.Text);
            other_expenses_values = int.Parse(other_expenses.Text);
            taxes_values = int.Parse(taxes.Text);
            deferred_part_default_values = total_income_values / 10;
            deferred_part_values = total_income_values - (payment_for_housing_values + communal_payments_values + other_expenses_values + taxes_values);
            if (deferred_part_default_values <= deferred_part_values)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter("D:\\Kopilka\\Kopilka.txt");
                    streamWriter.WriteLine("Общий доход: " + total_income_values);
                    streamWriter.WriteLine("Плата за жильё: " + payment_for_housing_values);
                    streamWriter.WriteLine("Комунальные платежи: " + communal_payments_values);
                    streamWriter.WriteLine("Прочие расходы: " + taxes_values);
                    streamWriter.WriteLine("Материал: " + other_expenses_values);
                    streamWriter.WriteLine("Налоги: " + taxes_values);
                    streamWriter.WriteLine("Отложенная часть: " + deferred_part_values);
                    streamWriter.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Exception: " + x.Message);
                }
            }
            else
            {
                deferred_part_values = deferred_part_default_values - deferred_part_values;

                MessageBox.Show("Сумма которая вы хотите отложить меньше 10-ой части поэтому рекомендую уменьшить прочие расходы на :" + deferred_part_values);
            }
        }
    }
}
