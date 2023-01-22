using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventBokning
{
    public partial class Form1 : Form
    {

        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            string server = "localhost";
            string db = "mydb";
            string user = "root";
            string pw = "beepboop";

            string connString = $"SERVER={server};DATABASE={db};UID={user};PASSWORD={pw};";

            conn = new MySqlConnection(connString);
        }

        private void btnInsertNewUser_Click(object sender, EventArgs e)
        {
            InsertNewCustomerToDb();
        }

        private void InsertNewCustomerToDb()
        {
            string name = tbxName.Text;
            string email = tbxEmail.Text;
            int age = Convert.ToInt32(tbxAge.Text);

            string query = $"CALL addCustomer('{name}', '{email}', {age});";

            MySqlCommand sqlCmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            MessageBox.Show("Insert successful");
        }
        private void selectCustomersFromDb()
        {
            string querry = "SELECT * FROM view_customers";
            MySqlCommand sqlCmd = new MySqlCommand(querry, conn);
            lblOutputTest.Text = "";
            try
            {
                conn.Open();
                // Skapa en datareader objekt som läsar våran datan. När connection stängs så försvinner datan.
                MySqlDataReader reader = sqlCmd.ExecuteReader();

                // datagrid
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                gridOutput.DataSource = dataTable;

                // Förnya datan/kopplingen av readern.
                reader = sqlCmd.ExecuteReader();

                //While loop för att skriva ut hämtad data
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    string email = reader["email"].ToString();
                    int age = Convert.ToInt32(reader["age"]);

                    lblOutputTest.Text += $"{name} har emailen {email} och är {age} år gammal.\n";
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void GetEventData(int id)
        {
            // Todo - If reader contains multiple rows of data, it searches for a primary key value(?) and if it can't find it, it overwrites previous data as it can't separare without a unique value.
            // At the moment this prints out events.event_id(PK) in order to display multiple results.
            // A solution would be to manually create the columns of the datatable instead of automatic loading, but it's a low priority fix.
            string SQLquery = $"CALL getEventsOfCustomer({id});"; 
            MySqlCommand sqlCmd = new MySqlCommand(SQLquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader2 = sqlCmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader2);
                gridEventOutput.DataSource = dt;

                conn.Close();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void getSelectedRow()
        {
            // Validering för att kontrollera att en rad har blivit hämtad
            if (gridOutput.SelectedRows.Count != 1) return;

            // Populate second datagrid of booked events of currently selected customer via id
            int id = Convert.ToInt32(gridOutput.SelectedRows[0].Cells[0].Value);
            GetEventData(id);
        }

        private void btnSelectCustomers_Click(object sender, EventArgs e)
        {
            selectCustomersFromDb();
        }

        private void gridOutput_SelectionChanged(object sender, EventArgs e)
        {
            getSelectedRow();
        }

        private void btnPerformerWindow_Click(object sender, EventArgs e)
        {
            Form2 PerformerWindow = new Form2();
            this.Hide();
            PerformerWindow.Show();
        }
    }
}
