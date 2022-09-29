using DataAccess.Entities;
using DataAccess.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2hOperator
{
    public class D2hOperator
    {
        private static string connectionString = @"Data Source=desktop-5vqtp5k;Initial Catalog=d2hoperator;Integrated Security=True";

        private static ICityOperations _cityOperations = new CityOperations(connectionString);

        private static CustomerOperations _customerOperations = new CustomerOperations(connectionString);

        internal static void Execute()
        {
            ShowLoginChoicePage();
        }


        private static void ShowLoginChoicePage()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Welcome to D2hOps");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1.Customer Login");
            Console.WriteLine("2.Agent Login");
            Console.WriteLine("---------------------------------------");
            string input = Console.ReadLine();
            if (input == "1")
            {
                CustomerLoginChoicePage();
            }
            else if (input == "2")
            {

            }
            else
            {
                Console.WriteLine("Invalid Choice! Press Enter to Retry");
                Console.ReadLine();
                ShowLoginChoicePage();
            }

        }

        private static void CustomerLoginChoicePage()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            string username = Utilities.GetInputFromConsole("Enter Username", 30);
            string password = Utilities.GetInputFromConsole("Enter Password", 30);
            Console.WriteLine("---------------------------------------");
            UserDetails userDetails = _customerOperations.GetUserWithUsernameAndPassword(username, password);

            if(userDetails == null)
            {
                Console.WriteLine("Wrong Creadentials");
                CustomerLoginChoicePage();
            }
            else
            {
                UserInformation.CurrentLoggedInUserDetails = userDetails;
                ShowCustomerDashboard();
            }
        }

        private static void ShowCustomerDashboard()
        {
            Console.Clear();
            Console.WriteLine($"---------------------------------");
            Console.WriteLine($"Welcom {UserInformation.CurrentLoggedInUserDetails.Name}");
            Console.WriteLine($"Your {UserInformation.CurrentLoggedInUserDetails.PackageName} plan is active." );


            Console.WriteLine("Select a Choice");
            Console.WriteLine("1. Get My Information");
            Console.WriteLine("5. Logout");

            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine($"Name\t\t: {UserInformation.CurrentLoggedInUserDetails.Name}");
                Console.WriteLine($"Package\t\t: {UserInformation.CurrentLoggedInUserDetails.PackageName}");
                Console.WriteLine("Press Enter to Go Back!");
                Console.ReadLine();
                ShowCustomerDashboard();
            }
            else if(input == "5")
            {
                ShowLoginChoicePage();
            }

        }
    }
}
