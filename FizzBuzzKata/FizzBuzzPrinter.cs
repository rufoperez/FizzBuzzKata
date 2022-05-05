namespace FizzBuzzKata
{
    public class FizzBuzzPrinter
    {
        public static string Print(int number)
        {
            if (number == 3)
                return "fizz";

            if (number == 6)
                return "fizz";

            if (number == 5)
                return "buzz";

            return number.ToString();
        }
    }
}
