using System;
using System.Text.RegularExpressions;

namespace AppMan
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "a5b7c3";
            int resultInt = Convert.ToInt32(Regex.Replace(input, "[^0-9]", ""));

            Console.WriteLine(resultInt);
        }
    }
}
