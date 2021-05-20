using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class NumericFunctions
    {

        public int AddNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int temp in numbers)
            {
                sum += temp;
            }
            return sum;


        }

        public int SubtractNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int temp in numbers)
            {
                sum =- temp;
            }
            return sum;


        }

        public Int64 MultiplyNumbers(params int[] numbers)
        {
            Int64 sum = 0;
            foreach (int temp in numbers)
            {
                sum *= temp;
            }
            return sum;


        }

        public int DivideNumbers(int denomiantor , int numerator)
        {
             
            return numerator/denomiantor;


        }

        public int MaximumNumbers(params int[] numbers)
        {
            int max= 0;
            foreach (int temp in numbers)
            {
                if (temp > max)
                    max = temp;
            }
            return max;


        }
        public int MinimumNumbers(params int[] numbers)
        {
            int min = 0;
            foreach (int temp in numbers)
            {
                if (temp < min)
                    min = temp;
            }
            return min;


        }

        public string EvenNumbersWithInRange(int startRange, int endRange)
        {
            string evenNumbers = string.Empty;
            for(int i=startRange; i<=endRange;i++)
            {
                if (i % 2 == 0)
                    evenNumbers += " " + i.ToString();
            }
            
            return evenNumbers;
        }

        public string OddNumbersWithInRange(int startRange, int endRange)
        {
            StringBuilder oddNumbers = new StringBuilder();
            for (int i = startRange; i <= endRange; i++)
            {
                if (i % 2 != 0)
                    oddNumbers.Append(" " + i);
            }

            return oddNumbers.ToString();
        }
    }
}