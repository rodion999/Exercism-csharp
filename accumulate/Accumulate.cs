using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        List<U> resultnew = new List<U>();
        foreach (var value in collection)
        {
            //yield return func(value);
            var t = func(value);
            resultnew.Add(t);
        }


        return resultnew;
    }
}
// Exercism Accumulate