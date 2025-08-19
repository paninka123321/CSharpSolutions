using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPrograms
{
    public class EnterTheNumber
    {
        public static void TakeNumber()
        {
            var input = Console.ReadLine();
            int number = int.Parse(input);

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("You've chosen the valid number");
            }
            else
            {
                Console.WriteLine("This number is invalid");
            }
        }
    }
}
