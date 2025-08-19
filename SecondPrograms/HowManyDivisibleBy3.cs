using System;
namespace SecondPrograms;

class HowManyDivisibleBy3
{
    public int CountDivisbleBy3(int start, int end)
    {
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 3 == 0)
            {
                count++;
            }
        }
        return count;
    }

    public int FasterMethod(int start, int end)
    {
        // starting counting from 0:
        var lastNumber = end - start;
        return lastNumber / 3 +1; //cause 0 is also divisible by 3
    }
}