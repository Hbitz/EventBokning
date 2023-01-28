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
    public partial class CustomerWindow : Form
    {

        MySqlConnection conn;

        public CustomerWindow()
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

        private bool validateInput()
        {
            string name = tbxName.Text;
            string email = tbxEmail.Text;
            int age;
            if (name == "")
            {
                MessageBox.Show("Kunden måste ha ett namn.");
                return false;
            };

            if (email == "")
            {
                MessageBox.Show("Kunden måste ha en email.");
                return false;
            }

            try
            {
                age = Convert.ToInt32(tbxAge.Text);
            }
            catch (Exception _)
            {
                MessageBox.Show("Ålder måste vara en siffra. Försök igen.");
                return false;
            }

            // Returnera true om vi inte får några errors
            return true;

        }


        private void InsertNewCustomerToDb()
        {
            // Validera all input i textboxes innan vi använder datan
            if (validateInput() == false) return;

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

                //Update table so we can see the new customer
                selectCustomersFromDb();
                MessageBox.Show("Insert successful");
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
            }
        }
        private void selectCustomersFromDb(string searchstring = "")
        {
            string querry = "";
            if (searchstring != "")
            {
                querry = $"CALL searchCustomerByName('{searchstring}');";
            }
            else
            {
                querry = "SELECT * FROM view_customers";
            }
            MySqlCommand sqlCmd = new MySqlCommand(querry, conn);
            try
            {
                conn.Open();
                // Skapa en datareader objekt som läsar våran datan. När connection stängs så försvinner datan.
                MySqlDataReader reader = sqlCmd.ExecuteReader();

                // datagrid
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                gridOutput.DataSource = dataTable;

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
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
                conn.Close();
            }
        }

        // When our selection in datatable/grid of customers is changed, call getSelectedRow to see if we have selected a single row or not
        private void gridOutput_SelectionChanged(object sender, EventArgs e)
        {
            getSelectedRow();

        }
        private void getSelectedRow()
        {
            // Validering för att kontrollera att en rad har blivit hämtad
            if (gridOutput.SelectedRows.Count != 1) return;

            // Populate second datagrid of booked events of currently selected customer via id
            int id = Convert.ToInt32(gridOutput.SelectedRows[0].Cells[0].Value);
            GetEventData(id);

            // Update our textboxes from the cells in selected row. 
            tbxName.Text = gridOutput.SelectedRows[0].Cells[1].Value.ToString();
            tbxEmail.Text = gridOutput.SelectedRows[0].Cells[2].Value.ToString();
            tbxAge.Text = gridOutput.SelectedRows[0].Cells[3].Value.ToString();

            // Enable buttons that relies on having a row selected
            btnUpdateCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
        }

        // Get all customers from db
        private void btnSelectCustomers_Click(object sender, EventArgs e)
        {
            selectCustomersFromDb();
        }


        // Select for all customers in database by name with a search string
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchstring = tbxName.Text;
            selectCustomersFromDb(searchstring);
        }

        // Updates a customer
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (gridOutput.SelectedRows.Count != 1) return;

            // Validera all input i textboxes innan vi använder datan
            if (validateInput() == false) return;

            // Get id and the new values
            int id = Convert.ToInt32(gridOutput.SelectedRows[0].Cells[0].Value);
            string name = tbxName.Text;
            string email = tbxEmail.Text;
            int age = Convert.ToInt32(tbxAge.Text);

            string querry = $"CALL updateCustomer({id}, '{name}', '{email}', {age});";

            MySqlCommand sqlCmd = new MySqlCommand(querry, conn);

            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();

                // Uppdatera datan och meddela användaren att vi lyckades uppdatera
                selectCustomersFromDb();
                MessageBox.Show("Användaren har uppdateras.");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (gridOutput.SelectedRows.Count != 1) return;

            int id = Convert.ToInt32(gridOutput.SelectedRows[0].Cells[0].Value);

            string sqlQuerry = $"CALL deleteCustomer({id});";

            MySqlCommand sqlCmd = new MySqlCommand(sqlQuerry, conn);

            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();

                //uppdatera datan
                selectCustomersFromDb();
                MessageBox.Show("Användaren har tagits bort.");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        // Close this window and go to Event window
        private void btnEventWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventWindow eventWindow = new EventWindow();
            eventWindow.Show();
        }

        private void btnPerformerWindow_Click(object sender, EventArgs e)
        {
            PerformerWindow performerWindow = new PerformerWindow();
            this.Hide();
            performerWindow.Show();
        }
    }
}
