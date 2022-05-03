namespace FizzBuzzKata
{
    public class FizzBuzzPrinter
    {
        public static string Print(int number)
        {
            if (number == 3)
                return "fizz";

            return number.ToString();
        }
    }
}
