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

namespace EventBokning
{
    public partial class PerformerWindow : Form
    {
        MySqlConnection conn;
        public PerformerWindow()
        {
            InitializeComponent();
            {
                string server = "localhost";
                string db = "mydb";
                string user = "root";
                string pw = "beepboop";
                string connString = $"SERVER={server};DATABASE={db};UID={user};PASSWORD={pw};";
                conn = new MySqlConnection(connString);
            }
        }

        // Validerar all data i våra textboxes. Returnerar false + MessageBox om något är fel, true om allt är rätt.
        private bool validateInput()
        {
            string name = tbxName.Text;
            string email = tbxEmail.Text;
            if (name == "")
            {
                MessageBox.Show("Artisten måste ha ett namn.");
                return false;
            };
            if (email == "")
            {
                MessageBox.Show("Artisten måste ha en email.");
                return false;
            };
            
            // Returnera true om vi inte får några errors
            return true;
        }

        private void btnInsertNewPerformer_Click(object sender, EventArgs e)
        {
            // Validerar input av textboxes.
            if (validateInput() == false) return;

            string name = tbxName.Text;
            string email = tbxEmail.Text;
            string query = $"CALL addPerformer('{name}', '{email}');";
            MySqlCommand sqlCmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();
                //Update table so we can see the new customer
                selectPerformersFromDb();
                MessageBox.Show("Insert successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void selectPerformersFromDb(string searchstring = "")
        {
            string querry = "";
            if (searchstring != "")
            {
                querry = $"CALL searchPerformerByName('{searchstring}');";
            }
            else
            {
                querry = "SELECT * FROM view_performers";
            }
            MySqlCommand sqlCmd = new MySqlCommand(querry, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = sqlCmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                gridPerformers.DataSource = dataTable;

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void GetEventData(int id)
        {
            string SQLquery = $"CALL getEventsOfPerformer({id});";
            MySqlCommand sqlCmd = new MySqlCommand(SQLquery, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                gridEvents.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void gridPerformers_SelectionChanged(object sender, EventArgs e)
        {
            // Validering för att kontrollera att en rad har blivit hämtad
            if (gridPerformers.SelectedRows.Count != 1) return;

            // Populate second datagrid of booked events of currently selected customer via id
            int id = Convert.ToInt32(gridPerformers.SelectedRows[0].Cells[0].Value);
            GetEventData(id);

            // Update our textboxes from the cells in selected row. 
            tbxName.Text = gridPerformers.SelectedRows[0].Cells[1].Value.ToString();
            tbxEmail.Text = gridPerformers.SelectedRows[0].Cells[2].Value.ToString();

            // Enable buttons that relies on having a row selected
            btnUpdatePerformer.Enabled = true;
            btnDeletePerformer.Enabled = true;
        }

        private void btnSelectPerformers_Click(object sender, EventArgs e)
        {
            selectPerformersFromDb();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchstring = tbxName.Text;
            selectPerformersFromDb(searchstring);
        }

        private void btnUpdatePerformer_Click(object sender, EventArgs e)
        {
            if (gridPerformers.SelectedRows.Count != 1) return;

            //validerar input 
            if (validateInput() == false) return;

            // Get id and the new values
            int id = Convert.ToInt32(gridPerformers.SelectedRows[0].Cells[0].Value);
            string name = tbxName.Text;
            string email = tbxEmail.Text;

            string querry = $"CALL updatePerformer({id}, '{name}', '{email}');";

            MySqlCommand sqlCmd = new MySqlCommand(querry, conn);
            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();
                // Uppdatera datan och meddela användaren att vi lyckades uppdatera
                selectPerformersFromDb();
                MessageBox.Show("Användaren har uppdateras.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnDeletePerformer_Click(object sender, EventArgs e)
        {
            if (gridPerformers.SelectedRows.Count != 1) return;
            int id = Convert.ToInt32(gridPerformers.SelectedRows[0].Cells[0].Value);
            string sqlQuerry = $"CALL deletePerformer({id});";
            MySqlCommand sqlCmd = new MySqlCommand(sqlQuerry, conn);

            try
            {
                conn.Open();
                sqlCmd.ExecuteReader();
                conn.Close();
                //uppdatera datan
                selectPerformersFromDb();
                MessageBox.Show("Artisten har tagits bort.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEventWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventWindow eventWindow = new EventWindow();
            eventWindow.Show();
        }

        private void btnCustomerWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerWindow customerWindow = new CustomerWindow();
            customerWindow.Show();
        }
    }
}
