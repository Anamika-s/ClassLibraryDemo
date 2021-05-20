using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class StringFunctions
    {
        public bool Palindrom(string inputString)
        {
            bool isPalindrom = true;
            for(int i=0, j=inputString.Length-1; i< inputString.Length/2;i++,j--)
            {
                if(inputString[i] != inputString[j])
                {
                    isPalindrom = false;
                    break;
                }
            }
            return isPalindrom;
        }
    }
}
