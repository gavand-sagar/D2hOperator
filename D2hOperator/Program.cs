using DataAccess.Entities;
using DataAccess.Operations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace D2hOperator
{

    internal class Program
    {
        private static string connectionString = @"Data Source=desktop-5vqtp5k;Initial Catalog=d2hoperator;Integrated Security=True";

        private static CityOperations _cityOperations = new CityOperations(connectionString);
        private static CustomerOperations _customerOperations = new CustomerOperations(connectionString);
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter starting letter");

            //string input = Console.ReadLine();
            var result = _customerOperations.GetCustomerWithPakage(1);


            Console.ReadLine();
        }
    }
}
