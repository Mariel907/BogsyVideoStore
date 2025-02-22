using Project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    public class AddCstumer
    {
        public void InsertCustomer(CustomerProp customer)
        {
            string query = "InsertCustomer";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName",customer.FirstName),
                new SqlParameter("@LastName", customer.LastName),
            };
            
            DataLoader dataLoader = new DataLoader();
            dataLoader.LoadData(query, null, true, parameters);
        }
    }
}
