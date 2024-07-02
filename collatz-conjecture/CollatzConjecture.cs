using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException();
        
        int count = 0;
        while (number != 1 && number > 1)
        {
            if (number % 2 == 0)
            {
                number /= 2;
                count++;
            }
            else
            {
                number = number * 3 + 1;
                count++;
            }

            if (number == 1)
                break;
        }
        return count;
    }
}