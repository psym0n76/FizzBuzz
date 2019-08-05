namespace FizzBuzzLibrary
{
    public static class FizzBuzzFactory
    {
        public static IFizzBuzz GetFactoryClassVersion(string response)
        {
            switch (response.ToLower())
            {
                case "uk":
                    return new FizzBuzzUk();
                case "eur":
                    return new FizzBuzzEur();
                case "usd":
                    return new FizzBuzzUk();
                default:
                    return null;
            }
        }

        public static IFizzBuzz GetInjectionVersion(string response)
        {
            switch (response.ToLower())
            {
                case "uk":
                    return new FizzBuzz("Buzz", "Fizz", "BuzzFizz");
                case "eur":
                    return new FizzBuzz("BuzzEur", "FizzEur", "BuzzEur");
                case "usd":
                    return new FizzBuzz("BuzzUsd", "FizzUsd", "BuzzFizzUsd");
                default:
                    return null;
            }
        }

    }
}