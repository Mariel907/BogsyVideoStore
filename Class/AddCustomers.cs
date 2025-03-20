using Project.Model;
using System.Data.SqlClient;

namespace Project.Class
{
    public class AddCustomers
    {
        public void InsertCustomer(CustomerProp customer)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@FirstName", customer.FirstName),
                new SqlParameter("@LastName", customer.LastName)
            };
            DataLoader dataLoader = new DataLoader();
            dataLoader.ExecuteData("InsertCustomer", parameter);
        }
    }
}
