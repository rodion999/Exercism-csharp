using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int Sum = 0;
        var SumList = new List<int>();
        for (int j = 0; j < multiples.Count(); j++)
        {
            for (int i = 0; i < max; i++)
            {
                if (i % multiples.ElementAt(j) == 0)
                {
                    {
                        SumList.Add(i);
                    }

                }
            }
        }
        Sum = SumList.Distinct().Sum();
        return Sum;
    }
}