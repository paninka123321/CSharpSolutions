using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number; // byte is to 255
            number = 1;
            number += 1;
            int count = 10;
            float price = 19.99f;
            Console.WriteLine(number + count + price); // Output: 2

            char a = 'A'; 
            char b = 'B';
            Console.WriteLine("{0} {1}", a, b); 

            //check min and max values of int type
            Console.WriteLine("Min int: {0}, Max int: {1}", int.MinValue, int.MaxValue);

            //constatnts - Pascal case
            const int DaysInWeek = 7; // we cannot change this value in our program (readonly)
            Console.WriteLine("Days in a week: {0}", DaysInWeek);

            //casting
            float f0 = 10.0f;
            int i0 = (int)f0; // explicit casting, fractional part is lost
            Console.WriteLine("Converted float to int: {0}", i0);

            float f1 = 1.5f;
            int i1 = (int)f1; // explicit casting, fractional part is lost
            Console.WriteLine("Converted float to int: {0}", i1);

            string str = "123";
            int i2 = Convert.ToInt32(str); // converting string to int
            int j2 = int.Parse(str); // another way to convert string to int

            Console.WriteLine("Converted string to int: {0} {1}", i2, j2);

            // to not crash if the string is not a valid number

            string invalidStr = "abc";

            try
            {
                int i3 = Convert.ToInt32(invalidStr); // this will throw an exception
                Console.WriteLine("Converted invalid string to int: {0}", i3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format for conversion.");
            }

            try
            {
                var numberString = "1234";
                byte byteNumber = byte.Parse(numberString); // parsing string to byte
                Console.WriteLine("Parsed string to byte: {0}", byteNumber);

            }
            catch (Exception)
            {

                Console.WriteLine("Error parsing string to byte. The value of your str is to large for converting to byte.");
            }



        }
    }
}
