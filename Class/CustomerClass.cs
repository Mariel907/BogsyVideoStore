using Project.Forms;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

                cutomer.CustomerID = selectedRow.Cells["CustomerID"].Value.ToString();
                cutomer.FirstName = selectedRow.Cells["FirstName"].Value.ToString();
                cutomer.LastName = selectedRow.Cells["LastName"].Value.ToString();

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
            using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("InsertVideo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", cutomer.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", cutomer.LastName);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
    }
}
