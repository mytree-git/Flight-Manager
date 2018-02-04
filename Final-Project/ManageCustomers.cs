using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class ManageCustomers : Form
    {
        
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void handleException(Exception ex)
        {
            string msg = ex.Message.ToString();
            string caption = "Error";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'airlinesManager.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.airlinesManager.Customer);

        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtName.Text == "") || (txtAddress.Text == "") || (txtPhone.Text == "") || (txtEmail.Text == ""))
                {
                    MessageBox.Show("No TextBox can be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    AirlinesManager ds = new AirlinesManager();
                    AirlinesManagerTableAdapters.CustomerTableAdapter cTable = new AirlinesManagerTableAdapters.CustomerTableAdapter();
                    AirlinesManager.CustomerRow cRow = ds.Customer.NewCustomerRow();
                    cRow.Name = txtName.Text;
                    cRow.Address = txtAddress.Text;
                    cRow.Phone = txtPhone.Text;
                    cRow.Email = txtEmail.Text;
                    bool phone = CheckNumber(txtPhone.Text);
                    if(phone == false)
                    {
                        MessageBox.Show("Please enter valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    int status = ValidateEmailId(txtEmail.Text);
                    if (status == 0)
                    {
                        MessageBox.Show("Please enter valid email-id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (status == 1 && phone == true)
                    {
                        ds.Customer.Rows.Add(cRow);
                        cTable.Update(ds.Customer);



                        cTable.Fill(ds.Customer);
                        cmbCustomer.DataSource = ds.Customer;

                        dgvCustomers.DataSource = ds.Customer;
                    }
                }
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                AirlinesManager ds = new AirlinesManager();
                AirlinesManagerTableAdapters.CustomerTableAdapter cTable = new AirlinesManagerTableAdapters.CustomerTableAdapter();
                cTable.Fill(ds.Customer);
                bool phone = CheckNumber(txtPhone.Text);
                if (phone == false)
                {
                   MessageBox.Show("Please enter valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int status = ValidateEmailId(txtEmail.Text);
                if (status == 0)
                {
                    MessageBox.Show("Please enter valid email-id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(status == 1 && phone == true)
                {
                    int selectedID = Convert.ToInt32(cmbCustomer.SelectedValue);
                    DataRow[] dr = ds.Customer.Select("CustomerID=" + selectedID);

                    dr[0]["Name"] = txtName.Text;
                    dr[0]["Address"] = txtAddress.Text;
                    dr[0]["Phone"] = txtPhone.Text;
                    dr[0]["Email"] = txtEmail.Text;


                    cTable.Update(ds.Customer);

                    MessageBox.Show("Information Updated", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cTable.Fill(ds.Customer);
                    cmbCustomer.DataSource = ds.Customer;
                    dgvCustomers.DataSource = ds.Customer;
                }
               
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AirlinesManager ds = new AirlinesManager();
            AirlinesManagerTableAdapters.CustomerTableAdapter cTable = new AirlinesManagerTableAdapters.CustomerTableAdapter();
            cTable.Fill(ds.Customer);
            int selectedID = Convert.ToInt32(cmbCustomer.SelectedValue);
            DataRow[] dr = ds.Customer.Select("CustomerID=" + selectedID);
            dr[0].Delete();
            cTable.Update(ds.Customer);
            MessageBox.Show("Information Deleted", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cTable.Fill(ds.Customer);
            cmbCustomer.DataSource = ds.Customer;
            dgvCustomers.DataSource = ds.Customer;

            
        }

        public int ValidateEmailId(string emailId)
        {
            /*Regular Expressions for email id*/
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (emailId.Length > 0)
            {
                if (!rEMail.IsMatch(emailId))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            return 2;
        }

        public static bool CheckNumber(string strPhoneNumber)
        {
           string MatchPhoneNumberPattern = @"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}";
           if (strPhoneNumber != null)
           {
               return Regex.IsMatch(strPhoneNumber, MatchPhoneNumberPattern);
           }
           else
           {
               return false;
           }
       }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
