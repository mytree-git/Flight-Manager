using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class ManageFlights : Form
    {
        public ManageFlights()
        {
            InitializeComponent();
        }

        private void handleException(Exception ex)
        {
            string msg = ex.Message.ToString();
            string caption = "Error";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ManageFlights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlinesManager.Airlines' table. You can move, or remove it, as needed.
            //this.airlinesTableAdapter.Fill(this.airlinesManager.Airlines);
            // TODO: This line of code loads data into the 'airlinesManager.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.airlinesManager.Flights);
            this.airlinesTableAdapter.Fill(this.airlinesManager.Airlines);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtDCity.Text == "") || (txtACity.Text == "") || (dtDDate.Text == "") || (dtADate.Text == "") || (cmbAirlineID.Text == ""))
                {
                    MessageBox.Show("No TextBox can be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    AirlinesManager ds = new AirlinesManager();
                    AirlinesManagerTableAdapters.FlightsTableAdapter fTable = new AirlinesManagerTableAdapters.FlightsTableAdapter();
                    AirlinesManager.FlightsRow fRow = ds.Flights.NewFlightsRow();

                    fRow.DepartureCity = txtDCity.Text;
                    fRow.ArrivalCity = txtACity.Text;
                    fRow.DepartureDate = Convert.ToString(dtDDate.Value.Date);
                    fRow.ArrivalDate = Convert.ToString(dtADate.Value.Date);
                    fRow.Airlines = Convert.ToString(cmbAirlineID.SelectedValue);
                    ds.Flights.Rows.Add(fRow);
                    fTable.Update(ds.Flights);

                    fTable.Fill(ds.Flights);
                    dgvFlights.DataSource = ds.Flights;

                }
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void dgvFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
