using System;

namespace FirstPrograms
{
	public class TypeOfPicture
	{
		public int x;
		public int y;

		public void IsLandscape()
		{
			if (x > y)
			{
				Console.WriteLine("This is a landscape picture.");
			}
			else if (x < y)
			{
				Console.WriteLine("This is a portrait picture.");
			}
			else
			{
				Console.WriteLine("This is a square picture.");
            }
        }

	}
}