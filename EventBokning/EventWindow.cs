using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlTypes;

namespace EventBokning
{
    public partial class EventWindow : Form
    {

        MySqlConnection conn;
        public EventWindow()
        {
            InitializeComponent();
            string server = "localhost";
            string db = "mydb";
            string user = "root";
            string pw = "beepboop";

            string connString = $"SERVER={server};DATABASE={db};UID={user};PASSWORD={pw};";
            conn = new MySqlConnection(connString);
        }

        private void btnCreateNewEvent_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            int price = Convert.ToInt32(tbxPrice.Text);
            int age_requirement = Convert.ToInt32(tbxAgeRequirement.Text);

            string query = $"CALL addEvent('{name}', '{price}', {age_requirement});";

            MySqlCommand sqlCmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();

                //Update table so we can see the new event
                selectEventsFromDb();
                MessageBox.Show("Insert successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Selects events from db
        private void selectEventsFromDb(string searchstring = "")
        {
            string querry = "";
            if (searchstring != "")
            {
                querry = $"CALL searchEventsByName('{searchstring}');";
            }
            else
            {
                querry = "SELECT * FROM view_events";
            }
            MySqlCommand sqlCmd = new MySqlCommand(querry, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = sqlCmd.ExecuteReader();

                // datagrid
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                gridEvents.DataSource = dataTable;

                // Förnya datan/kopplingen av readern.
                reader = sqlCmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void GetPerformerData(int id)
        {
            // Todo - If reader contains multiple rows of data, it searches for a primary key value(?) and if it can't find it, it overwrites previous data as it can't separare without a unique value.
            // At the moment this prints out events.event_id(PK) in order to display multiple results.
            // A solution would be to manually create the columns of the datatable instead of automatic loading, but it's a low priority fix.
            string SQLquery = $"CALL getPerformersOfEvent({id});";
            MySqlCommand sqlCmd = new MySqlCommand(SQLquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = sqlCmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                gridPerformers.DataSource = dt;

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // Get all customers that has a booking to selected event
        private void GetCustomerData(int id)
        {
            string SQLquery = $"CALL getCustomersOfEvent({id});";
            MySqlCommand sqlCmd = new MySqlCommand(SQLquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = sqlCmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                gridCustomers.DataSource = dt;

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // Get all customers that does not have a ticket to event, in case we want to book them.
        private void GetUnrelatedCustomerData(int id)
        {
            string SQLquery = $"CALL getCustomersNotRelatedToEvent({id});";
            MySqlCommand sqlCommand = new MySqlCommand(SQLquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader2 = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader2);
                gridUnrelatedCustomers.DataSource = dt;

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void gridEvents_SelectionChanged(object sender, EventArgs e)
        {
            getSelectedRow();
        }
        // Updates many windows and textboxes based on currently selected revent
        private void getSelectedRow()
        {
            // Validering för att kontrollera att en rad har blivit hämtad
            if (gridEvents.SelectedRows.Count != 1) return;

            // Populate second datagrid of booked events of currently selected customer via id
            int id = Convert.ToInt32(gridEvents.SelectedRows[0].Cells[0].Value);
            GetPerformerData(id);
            GetCustomerData(id);
            GetUnrelatedCustomerData(id);

            // Update our textboxes from the cells in selected row. 
            tbxName.Text = gridEvents.SelectedRows[0].Cells[1].Value.ToString();
            tbxPrice.Text = gridEvents.SelectedRows[0].Cells[2].Value.ToString();
            tbxAgeRequirement.Text = gridEvents.SelectedRows[0].Cells[3].Value.ToString();

            // Enable buttons that relies on having a row selected
            btnUpdateEvent.Enabled = true;
            btnDeleteEvent.Enabled = true;
        }

        // Get all events
        private void btnGetEvents_Click(object sender, EventArgs e)
        {
            selectEventsFromDb();
        }

        // Get all events by searching for event name
        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            string searchstring = tbxName.Text;
            selectEventsFromDb(searchstring);

        }

        // Update currently selected event
        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            if (gridEvents.SelectedRows.Count != 1) return;

            // Get id and the new values
            int id = Convert.ToInt32(gridEvents.SelectedRows[0].Cells[0].Value);
            string name = tbxName.Text;
            int price = Convert.ToInt32(tbxPrice.Text);
            int age_requirement = Convert.ToInt32(tbxAgeRequirement.Text);

            string querry = $"CALL updateEvent({id}, '{name}', '{price}', {age_requirement});";

            MySqlCommand sqlCmd = new MySqlCommand(querry, conn);
            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();
                // Uppdatera datan och meddela användaren att vi lyckades uppdatera eventet
                selectEventsFromDb();
                MessageBox.Show("Användaren har uppdateras.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            // Make sure one row is selected
            if (gridEvents.SelectedRows.Count != 1) return;

            int id = Convert.ToInt32(gridEvents.SelectedRows[0].Cells[0].Value);

            string sqlQuerry = $"CALL deleteEvent({id});";

            MySqlCommand sqlCmd = new MySqlCommand(sqlQuerry, conn);
            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();
                //uppdatera datan
                selectEventsFromDb();
                MessageBox.Show("Eventet har tagits bort.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Enables button to remove booking between customer and event
        private void gridCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (gridCustomers.SelectedRows.Count != 1) return;

            btnRemoveCustomerEventBooking.Enabled = true;
        }

        // Remove booking between customer & event
        private void btnRemoveCustomerEventBooking_Click(object sender, EventArgs e)
        {
            if (gridCustomers.SelectedRows.Count != 1) return;

            int event_id = Convert.ToInt32(gridEvents.SelectedRows[0].Cells[0].Value);
            int customer_id = Convert.ToInt32(gridCustomers.SelectedRows[0].Cells[0].Value);

            string sqlQuerry = $"CALL deleteCustomerEventBooking('{event_id}', '{customer_id}');";

            MySqlCommand sqlCmd = new MySqlCommand(sqlQuerry, conn);
            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();
                //Uppdatera både datatablen som visar kunder som har bokning till event, samt kunder som inte har bokning till event.
                GetCustomerData(event_id);
                GetUnrelatedCustomerData(event_id);
                MessageBox.Show("Bokningen till eventen är nu borttaget för kunden.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Enables button to book ticket between customer and event
        private void gridUnrelatedCustomers_SelectionChanged(object sender, EventArgs e)
        {
            {
                if (gridUnrelatedCustomers.SelectedRows.Count != 1) return;
                btnBookCustomerToEvent.Enabled = true;
            }
        }
        // Book ticket between event and customer
        private void btnBookCustomerToEvent_Click(object sender, EventArgs e)
        {
            if (gridUnrelatedCustomers.SelectedRows.Count != 1) return;

            int event_id = Convert.ToInt32(gridEvents.SelectedRows[0].Cells[0].Value);
            int customer_id = Convert.ToInt32(gridUnrelatedCustomers.SelectedRows[0].Cells[0].Value);

            string sqlQuerry = $"CALL addCustomerEventBooking('{event_id}', '{customer_id}');";

            MySqlCommand sqlCmd = new MySqlCommand(sqlQuerry, conn);
            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();
                // Uppdatera både datatablen som visar kunder som har bokning till event, samt kunder som inte har bokning till event.
                GetCustomerData(event_id);
                GetUnrelatedCustomerData(event_id);
                MessageBox.Show("Bokningen till eventen är nu tillagd för kunden.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Go back to Customers Window
        private void btnCustomerWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerWindow customerWindow = new CustomerWindow();
            customerWindow.Show();
        }

        // Go to Performers Window
        private void btnPerformerWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            PerformerWindow performerWindow = new PerformerWindow();
            performerWindow.Show();


        }
    }
}
