using FizzBuzzLibrary;
using System;

namespace ConsoleUi
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter number ? ");
            var response = Console.ReadLine();

            if (!int.TryParse(response, out var result))
                throw new InvalidCastException("Value cannot be a string");

            Console.WriteLine("Enter country?(UK/EUR)?");
            response = Console.ReadLine();


            var fizzBuzz = FizzBuzzFactory.GetFactoryClassVersion(response);

            for (var i = 1; i <= result; i++)
            {
                Console.WriteLine(fizzBuzz.Print(i));
            }

            Console.ReadKey();
        }

    }
}
