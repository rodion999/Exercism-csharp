using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string s = "";
        for (int i = input.Length - 1; i >= 0;)
        {
            s = s + input[i];
            i--;
        }
        return s;
    }
}
