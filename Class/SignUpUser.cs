using Project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    public class SignUpUser
    {
        public void InsertCustomer()
        {
            CustomerProp customer = new CustomerProp();
            string query = "InsertCustomer";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@firstname",customer.FirstName),
                new SqlParameter("@lastname", customer.LastName),
            };
            
            DataLoader dataLoader = new DataLoader();
            dataLoader.LoadData(query, null, true, parameters);
        }
    }
}
