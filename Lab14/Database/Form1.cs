using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        MySqlConnection mySqlConnection;
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;
        BindingSource bindingSource;

        int id1, id2, interval = 5;

        public Form1()
        {
            InitializeComponent();

            mySqlConnection = new MySqlConnection(
               "SERVER=localhost;" +
               "DATABASE=fitdb;" +
               "UID=root;" +
               "PASSWORD=;");
            mySqlConnection.Open();


            id1 = 1;
            id2 = interval;
            
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            
        }

        private void ShowTable(string query)
        {
            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM TelephoneBook WHERE PersonID BETWEEN {id1} AND {id2} ORDER BY {comboBox1.Text} {comboBox2.Text};";
            ShowTable(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mySqlDataAdapter.Update(dataTable);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            id1 -= interval;
            id2 -= interval;
            if(id1 <= 0)
            {
                id1 = 1;
                id2 = interval;
            }
            string query = $"SELECT * FROM TelephoneBook WHERE PersonID BETWEEN {id1} AND {id2} ORDER BY {comboBox1.Text} {comboBox2.Text};";
            ShowTable(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            id1 += interval;
            id2 += interval;
            string query = $"SELECT * FROM TelephoneBook WHERE PersonID BETWEEN {id1} AND {id2} ORDER BY {comboBox1.Text} {comboBox2.Text};";
            ShowTable(query);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM TelephoneBook WHERE PersonID BETWEEN {id1} AND {id2} ORDER BY {comboBox1.Text} {comboBox2.Text};";
            ShowTable(query);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM TelephoneBook WHERE PersonID BETWEEN {id1} AND {id2} ORDER BY {comboBox1.Text} {comboBox2.Text} ;";
            ShowTable(query);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM TelephoneBook WHERE (FirstName LIKE '{textBox1.Text}%' OR LastName LIKE '{textBox1.Text}%') ORDER BY {comboBox1.Text} {comboBox2.Text} ;";
            ShowTable(query);
        }
    }
}
