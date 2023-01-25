using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        public static string title = "C # ESSENTIAL TRAINING";
        public static int whichPart;
        public static String testString = "Raja Rajeshwar Madhu   ";
        public static String  number = "1,234";
        static void Main(string[] args)
        {
            whichPart = 450;
            var message = string.Format("Welcome to {0} Part {1}!",
            title, whichPart);
            var stringReplaced = number.Replace(",", "");
            int integerNumber = int.Parse(stringReplaced);
            Console.WriteLine(integerNumber);
            testString.Trim();
            Console.WriteLine(testString);
            Console.WriteLine(testString.ToUpper());
            Console.WriteLine("Lower Characters "+ testString.ToLower());
            Console.WriteLine(message);
        }
    }
}
