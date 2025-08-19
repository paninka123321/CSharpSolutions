using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPrograms
{
	public class MaximumNumber
	{

		public static void FindMaximum()
		{
			Console.WriteLine("Enter the first number:");
			int number1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the second number:");
			int number2 = int.Parse(Console.ReadLine());

			if (number1 > number2)
			{
				Console.WriteLine($"The maximum number is: {number1}");
			}
			else
			{
				Console.WriteLine($"The maximum number is: {number2}");
			}
		}
	}
}
