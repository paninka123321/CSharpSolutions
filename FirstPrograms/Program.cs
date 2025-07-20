using System;

namespace FirstPrograms
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program1. Enter the number. \n Please enter the positive number of your choice.");
            EnterTheNumber.TakeNumber();

            Console.WriteLine("Program2. Maximum Number");
            MaximumNumber.FindMaximum();

            Console.WriteLine("Program3. Type of Picture");
            TypeOfPicture picture = new TypeOfPicture();
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            picture.x = width; 
            picture.y = height; 
            picture.IsLandscape();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
