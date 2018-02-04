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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlinesManager.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.airlinesManager.Customer);
            // TODO: This line of code loads data into the 'airlinesManager.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.airlinesManager.Flights);
            // TODO: This line of code loads data into the 'airlinesManager.Airlines' table. You can move, or remove it, as needed.
            this.airlinesTableAdapter.Fill(this.airlinesManager.Airlines);

        }

        

        private void manageAirlinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAirlines ma = new ManageAirlines();
            ma.Show();
        }

        private void manageFlightsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageFlights mf = new ManageFlights();
            mf.Show();
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers mc = new ManageCustomers();
            mc.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.airlinesManager.Customer);
            this.flightsTableAdapter.Fill(this.airlinesManager.Flights);
            this.airlinesTableAdapter.Fill(this.airlinesManager.Airlines);
        }
    }
}
