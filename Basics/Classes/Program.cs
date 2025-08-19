using Classes.Math;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Doe";
            john.Introduce();

            Calculatr calculator = new Calculatr();
            var result = calculator.Add(5, 3);
            Console.WriteLine($"5 + 3 = {result}");

            // in C# we have arrays (class array), which have fixed size, and type
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3; //we start iteration from 0
            Console.WriteLine("Numbers in the array:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            char[] letters = new char[3] { 'a', 'b', 'c' }; // we can also specify the values of array at initialization by currly braces
            Console.WriteLine("Letters in the array:" + letters);

            char[] chars = new char[2];
            Console.WriteLine("The first character:" + chars[0]); // This will print the default value of char, which is '\0' (null character)
            // default value of int is 0, for string is null, for bool is false, for char is '\0'

            // combaining variables of an array using string join
            string joinedLetters = string.Join(":", letters);
            Console.WriteLine("Joined letters: " + joinedLetters);

            // verbatim string is a string that ignores escape sequences

            string verbatimString = @"This is a verbatim string. It can contain new lines
              and special characters like \n without escaping them.";
            Console.WriteLine(verbatimString);
        }
    }
}
 