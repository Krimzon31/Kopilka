using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopilka
{
    public partial class Savings_History : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
            "User id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres", "310504", "savings_history");

        private NpgsqlConnection connection;
        private string sql;
        private NpgsqlCommand command;
        private DataTable dataTable;
        private int total_sav;

        public Savings_History()
        {
            InitializeComponent();
        }
        
        private void Savings_History_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(connstring);
            Select();
            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "Внесённые накопления";
            dataGridView.Columns[2].HeaderText = "Дата внесения накоплений";

            connection.Open();
            sql = @"select * from ac_sum()";
            command = new NpgsqlCommand(sql, connection);
            total_sav = (int)command.ExecuteScalar();
            total_savings.Text = total_sav.ToString();
            total_savings.ReadOnly = true;

        }

        private void Select()
        {
            try
            {
                connection.Open();
                sql = @"select * from ac_select()";
                command = new NpgsqlCommand(sql, connection);
                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
                connection.Close();
                dataGridView.DataSource = null;
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           Main_Window main_Window  = new Main_Window();
           main_Window.Show();
           this.Close();
        }
    }
}
