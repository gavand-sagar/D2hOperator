using DataAccess.Entities;
using DataAccess.Operations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace D2hOperator
{

    internal class Program
    {
         static void Main(string[] args)
        {


            D2hOperator.Execute();

            Console.ReadLine();
        }
    }
}
