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
    public partial class ManageAirlines : Form
    {
        public ManageAirlines()
        {
            InitializeComponent();
        }


        private void handleException(Exception ex)
        {
            string msg = ex.Message.ToString();
            string caption = "Error";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ManageAirlines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlinesManager.Airlines' table. You can move, or remove it, as needed.
            this.airlinesTableAdapter.Fill(this.airlinesManager.Airlines);
            Dictionary<string, string> meals = new Dictionary<string, string>();
            meals["Vegeterian"] = "Vegeterian";
            meals["Non Vegeterian"] = "Non Vegeterian";
            cmbMeals.DataSource = new BindingSource(meals, null);
            cmbMeals.DisplayMember = "Key";
            cmbMeals.ValueMember = "Value";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtName.Text == "") || (txtType.Text == "") || (txtSeats.Text == "") || (cmbMeals.Text == ""))
                {
                    MessageBox.Show("No TextBox can be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    AirlinesManager ds = new AirlinesManager();
                    AirlinesManagerTableAdapters.AirlinesTableAdapter aTable = new AirlinesManagerTableAdapters.AirlinesTableAdapter();
                    AirlinesManager.AirlinesRow aRow = ds.Airlines.NewAirlinesRow();
                    aRow.Name = txtName.Text;
                    aRow.AirlineType = txtType.Text;
                    aRow.SeatsAvailable = int.Parse(txtSeats.Text);
                    aRow.Meal = cmbMeals.SelectedValue.ToString();
                    ds.Airlines.Rows.Add(aRow);
                    aTable.Update(ds.Airlines);


                    aTable.Fill(ds.Airlines);
                    cmbID.DataSource = ds.Airlines;
                    dgvAirlines.DataSource = ds.Airlines;
                   
                }
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                AirlinesManager ds = new AirlinesManager();
                AirlinesManagerTableAdapters.AirlinesTableAdapter aTable = new AirlinesManagerTableAdapters.AirlinesTableAdapter();
                aTable.Fill(ds.Airlines);

                int selectedID = Convert.ToInt32(cmbID.SelectedValue);
                DataRow[] dr = ds.Airlines.Select("AirlineID=" + selectedID);

                dr[0]["Name"] = txtName.Text;
                dr[0]["AirlineType"] = txtType.Text;
                dr[0]["SeatsAvailable"] = int.Parse(txtSeats.Text);
                dr[0]["Meal"] = cmbMeals.SelectedValue;

                aTable.Update(ds.Airlines);

                MessageBox.Show("Information Updated", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aTable.Fill(ds.Airlines);
                cmbID.DataSource = ds.Airlines;
                dgvAirlines.DataSource = ds.Airlines;
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            AirlinesManager ds = new AirlinesManager();
            AirlinesManagerTableAdapters.AirlinesTableAdapter aTable = new AirlinesManagerTableAdapters.AirlinesTableAdapter();
            aTable.Fill(ds.Airlines);
            int selectedID = Convert.ToInt32(cmbID.SelectedValue);
            DataRow[] dr = ds.Airlines.Select("AirlineID=" + selectedID);
            dr[0].Delete();
            aTable.Update(ds.Airlines);
            MessageBox.Show("Information Deleted", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            aTable.Fill(ds.Airlines);
            cmbID.DataSource = ds.Airlines;
            dgvAirlines.DataSource = ds.Airlines;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
