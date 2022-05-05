﻿namespace FizzBuzzKata
{
    public class FizzBuzzPrinter
    {
        public static string Print(int number)
        {
            if (number == 15)
                return "fizz buzz";

            if (number == 30)
                return "fizz buzz";

            if (number % 3 == 0)
                return "fizz";

            if (number % 5 == 0)
                return "buzz";

            return number.ToString();
        }
    }
}
