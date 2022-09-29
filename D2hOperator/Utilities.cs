using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2hOperator
{
    public static class Utilities
    {
        public static string GetInputFromConsole(string msg, int length)
        {
            Console.WriteLine(msg);
            string input = Console.ReadLine();
            if (input.Length > length)
            {
                Console.WriteLine($"Length Cannot be Greater Than {length}\nTry Again");
                return GetInputFromConsole(msg, length);
            }
            else
            {
                return input;

            }
        }
    }
}
