using Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace Project.Class
{
    public class CustomerClass
    {
        public void SaveEdit(CustomerProp cutomer)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@FirstName", cutomer.FirstName),
                new SqlParameter("@LastName", cutomer.LastName),
                new SqlParameter("@CustomerID", cutomer.CustomerID),
            };
            DataLoader ds = new DataLoader();
            ds.ExecuteData("UpdateCustomer", parameter);
        }
    }
}
