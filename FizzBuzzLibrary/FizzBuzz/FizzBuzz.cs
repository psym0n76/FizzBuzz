namespace FizzBuzzLibrary
{
    public class FizzBuzz : IFizzBuzz
    {
        private readonly string _fizzBuzz;
        private readonly string _fizz;
        private readonly string _buzz;

        public FizzBuzz(string buzz, string fizz, string fizzBuzz)
        {
            _buzz = buzz;
            _fizz = fizz;
            _fizzBuzz = fizzBuzz;
        }

        public string Print(int n)
        {
            if (n % 15 == 0)
                return _fizzBuzz;
            if (n % 3 == 0)
                return _fizz;
            if (n % 5 == 0)
                return _buzz;

            return n.ToString();
        }
    }
}