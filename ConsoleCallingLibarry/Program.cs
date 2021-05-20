using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCallingLibarry
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonFunctions.NumericFunctions numericFunctions = new CommonFunctions.NumericFunctions();
            int sum = numericFunctions.AddNumbers(1, 2, 3, 4, 5, 77, 8, 99, 00, 89);
            Console.WriteLine("Sum is " + sum);
            string evenNumbers = numericFunctions.EvenNumbersWithInRange(1, 1000);
            Console.WriteLine("Even numbers are " + evenNumbers);
            CommonFunctions.StringFunctions stringFunctions = new CommonFunctions.StringFunctions();
            bool isPalindrom = stringFunctions.Palindrom("Deepak");
            Console.WriteLine("Its " + isPalindrom + "Palindrom");
              isPalindrom = stringFunctions.Palindrom("madam");
            Console.WriteLine("Its " + isPalindrom + "Palindrom");

        }

    }
}
