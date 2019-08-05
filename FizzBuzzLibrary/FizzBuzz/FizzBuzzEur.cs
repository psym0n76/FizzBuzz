namespace FizzBuzzLibrary
{
    public class FizzBuzzEur : IFizzBuzz
    {
        public string Print(int n)
        {
            if (n % 15 == 0)
                return "FizzBuzzEur";
            if (n % 3 == 0)
                return "FizzEur";
            if (n % 5 == 0)
                return "BuzzEur";

            return n.ToString();
        }
    }
}