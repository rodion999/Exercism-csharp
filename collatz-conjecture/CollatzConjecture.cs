using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int loops = 0;
        
        if(number < 1)
            throw new System.ArgumentException("Number must bigger than zero");

        while (number > 1)
        {
            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = number * 3 + 1;
            }
            loops++;
        }
        
        return loops;
    }
}