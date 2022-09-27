using DataAccess.Entities;
using DataAccess.Operations;
using System;
using System.Collections.Generic;
namespace D2hOperator
{
    
    internal class Program
    {
        private static string connectionString = @"Data Source=desktop-5vqtp5k;Initial Catalog=d2hoperator;Integrated Security=True";

        private static CityOperations _cityOperations = new CityOperations(connectionString);
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter starting letter");

            //string input = Console.ReadLine();

            //List<City> cityList = _cityOperations.GetCities(input);

            //foreach (City c in cityList)
            //{
            //    Console.WriteLine(c.id);
            //    Console.WriteLine(c.name);
            //}

            Console.ReadLine();
        }
    }
}
