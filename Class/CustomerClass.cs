using Project.Forms.ExtensionForms;
using Project.Forms;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Web.UI.WebControls;

namespace Project.Class
{
    public class CustomerClass
    {
        private Dashboard dashboard;
        public CustomerClass(Dashboard dashboard)
        {
            this.dashboard = dashboard;
        }
        public void FetchCustomerData(CustomerProp cutomer, DataGridView dataGridView)
        {
            
            try
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                cutomer.CustomerID = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);
                cutomer.FirstName = selectedRow.Cells["FirstName"].Value.ToString();
                cutomer.LastName = selectedRow.Cells["LastName"].Value.ToString();
                cutomer.ContactNmbr = selectedRow.Cells["PhoneNumber"].Value.ToString();
                cutomer.Address = selectedRow.Cells["Address"].Value.ToString();
                cutomer.Age = selectedRow.Cells["Age"].Value.ToString();
                cutomer.Email = selectedRow.Cells["Email"].Value.ToString();

                EditCustomer Edit = new EditCustomer(dashboard, cutomer);
                FormManager form = new FormManager();
                form.OpenForm(Edit, dashboard.Panel);
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.ToString());
            }
        }

        public bool SaveEdit(CustomerProp cutomer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertVideo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", cutomer.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", cutomer.LastName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", cutomer.ContactNmbr);
                        cmd.Parameters.AddWithValue("@Address", cutomer.Address);
                        cmd.Parameters.AddWithValue("@Age", cutomer.Age);
                        cmd.Parameters.AddWithValue("@Email", cutomer.Email);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {

            }
            return false;
        }
    }
}
