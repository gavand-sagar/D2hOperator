using DataAccess.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess.Operations
{
    public class CityOperations : ICityOperations
    {
        private string _connectionString;
        public CityOperations(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<City> GetCities(string input)
        {
            List<City> cities = new List<City>();



            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();
                
                SqlCommand command = new SqlCommand($"select c.[id],c.[name] from city as c where c.[name] ='virar'", connection);


                //command.


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    System.Console.WriteLine($"{(int)reader[0]} \t\t {(string)reader[1]}");
                }

                    ////command.ex

                    //while (reader.Read())
                    //{
                    //    City c = new City();
                    //    c.id = (int)reader[0];
                    //    c.name = (string)reader[1];

                    //    //reader.geok

                    //    cities.Add(c);

                    //}



                    connection.Close();

            }

            return cities;
        }
    }
}
