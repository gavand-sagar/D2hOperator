using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class CustomerOperations
    {
        private string _connectionString;

        public CustomerOperations(string connectionString)
        {
            _connectionString = connectionString;
        }
        public USP_GET_CUSTOMER_WITH_PACKAGE GetCustomerWithPakage(int Id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();


                SqlCommand command =
                    new SqlCommand(
                        $"EXECUTE [dbo].USP_GET_CUSTOMER_WITH_PACKAGE {Id}",
                        connection);

                var reader = command.ExecuteReader();

                USP_GET_CUSTOMER_WITH_PACKAGE packageDetails = new USP_GET_CUSTOMER_WITH_PACKAGE();

                while (reader.Read())
                {
                    packageDetails.CustomerName = reader.GetString(0);
                    packageDetails.PackageName = reader.GetString(1);
                    break;
                }

                return packageDetails;
            }

        }
    }
}
