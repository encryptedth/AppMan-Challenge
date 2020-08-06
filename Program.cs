using System;
using System.Text.RegularExpressions;

namespace AppMan
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "a5b7c3";
            Console.WriteLine(Regex.Replace(input, "[^0-9]", ""));
        }
    }
}
