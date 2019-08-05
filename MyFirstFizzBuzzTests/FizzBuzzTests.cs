using FizzBuzzLibrary;
using NUnit.Framework;
using Shouldly;

namespace MyFirstFizzBuzzTests
{
    public class FizzBuzzTests
    {

        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void Should_return_string_when_number_divisible_by_input(int input, string output)
        {

            var result = new FizzBuzzUk();
            var r = result.Print(input);
            r.ShouldBe(output);
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(14)]
        public void Should_return_input_when_input_is_not_divisible(int input)
        {
            var result = new FizzBuzzUk();
            var r = result.Print(input);

            r.ShouldBe(input.ToString());
        }


        [Test]
        [TestCase("uk")]
        public void Should_return_fizzbuzzUk_type(string region)
        {
            var fizz = FizzBuzzFactory.GetFactoryClassVersion(region);

            fizz.ShouldBeAssignableTo<FizzBuzzUk>();

        }

        [Test]
        [TestCase("eur")]
        public void Should_return_fizzbuzzEur_type(string region)
        {
            var fizz = FizzBuzzFactory.GetFactoryClassVersion(region);

            fizz.ShouldBeAssignableTo<FizzBuzzEur>();

        }

        [Test]
        [TestCase("uk")]
        public void Should_not_return_fizzbuzzEur_type(string region)
        {
            var fizz = FizzBuzzFactory.GetFactoryClassVersion(region);

            fizz.ShouldNotBeAssignableTo<FizzBuzzEur>();
        }

        [Test]
        [TestCase(3, "Fizz", "uk")]
        [TestCase(3, "FizzEur", "eur")]
        [TestCase(6, "Fizz", "uk")]
        [TestCase(6, "FizzEur", "eur")]
        [TestCase(5, "Buzz", "uk")]
        [TestCase(5, "BuzzEur", "eur")]
        public void Should_return_string_when_number_is_divisible_by_three_(int i, string output, string region)
        {
            var r = FizzBuzzFactory.GetFactoryClassVersion(region);
            var result = r.Print(i);
            result.ShouldBe(output);
        }

        [Test]
        [TestCase(3, "Fizz", "uk")]
        [TestCase(3, "FizzEur", "eur")]
        [TestCase(6, "Fizz", "uk")]
        [TestCase(6, "FizzEur", "eur")]
        [TestCase(5, "Buzz", "uk")]
        [TestCase(5, "BuzzEur", "eur")]
        public void Should_return_string_when_number_is_divisible_by_three_using_constructor(int i, string output, string region)
        {
            var r = FizzBuzzFactory.GetInjectionVersion(region);
            var result = r.Print(i);
            result.ShouldBe(output);
        }



    }
}
