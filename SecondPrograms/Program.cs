using System.Security.Cryptography.X509Certificates;

namespace SecondPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's count the amount of numbers that are divisible by 3 in the range [x,y]");
            Console.WriteLine("Enter the value of x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of y:");
            int y = int.Parse(Console.ReadLine());

            HowManyDivisibleBy3 howManyDivisibleBy3 = new HowManyDivisibleBy3();
            var count = howManyDivisibleBy3.CountDivisbleBy3(x, y);
            Console.WriteLine($"There are {count} numbers divisible by 3 in the range [{x}, {y}].");

            Console.WriteLine("The same without for loop ('Faster Method')");

            var fasterCount = howManyDivisibleBy3.FasterMethod(x, y);
            Console.WriteLine($"The output of the Faster Method: {fasterCount}");

        }
    }
}
