﻿using DataAccess.Entities;
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


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = 
                    new SqlCommand(
                        $"select [dbo].USF_GetTotalCompalintCost(2)", 
                        connection);


                //command.


                var Id = command.ExecuteScalar();

                Console.WriteLine(Id);

                //while (reader.Read())
                //{
                //    System.Console.WriteLine($"{(int)reader[0]}");
                //}
            }

                Console.ReadLine();
        }
    }
}
