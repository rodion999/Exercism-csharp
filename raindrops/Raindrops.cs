using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string sNumber = number.ToString();
        string sResult = "";
        if (number % 3 == 0)
            sResult += "Pling";
        if (number % 5 == 0)
            sResult += "Plang";
        if (number % 7 == 0)
            sResult += "Plong";
        if (String.IsNullOrEmpty(sResult))
            return (sNumber);
        else return (sResult);

    }
}