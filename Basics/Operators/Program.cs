namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // arythmetic operators
            var a = 10;
            var b = 3;

            Console.WriteLine($"Addition: {a + b}"); // 13
            Console.WriteLine($"Subtraction: {a - b}"); // 7
            Console.WriteLine($"Multiplication: {a * b}"); // 30
            Console.WriteLine($"Division: {a / b}"); // 3
            Console.WriteLine($"Modulus: {a % b}"); // 1
            Console.WriteLine((float)a/ (float)b); // 3.3333333
            // Mathematic operations ruls (sequende of operations) are preserved
            var c = 2;
            Console.WriteLine($"Complex Operation: {a + b * c}"); // 16
            Console.WriteLine($"Complex Operation with Parentheses: {(a + b) * c}"); // 26

            // comparison operators
            Console.WriteLine($"Is a equal to b? {a == b}"); // False
            Console.WriteLine($"Is a not equal to b? {a != b}"); // True
            Console.WriteLine($"Is a greater than b? {a > b}"); // True
            Console.WriteLine($"Is a less than b? {a < b}"); // False
            Console.WriteLine($"Is a greater than or equal to b? {a >= b}"); // True
            Console.WriteLine($"Is a less than or equal to b? {a <= b}"); // False

            Console.WriteLine(b > c && b > a); // and operator (true & false = false)
            Console.WriteLine(b > c || b > a); // or operator (true | false = true)

        }
    }
}
