using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzzPrinter
    {
        public static string Print(int topNumber)
        {
            string result = string.Empty;

            for (int i = 1; i <= topNumber; i++)
            {
                result += $"{i}";
                if (i < topNumber)
                {
                    result += " ";
                }
            }


            return result;
        }
    }
}
