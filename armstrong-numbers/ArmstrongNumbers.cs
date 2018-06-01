using System;
using System.Collections.Generic;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        int ResultofExponentiation = 0;
        int numb = 0;
        //List<int> resultat = new List<int>();
        string LineOfNumbers = number.ToString();
        foreach (char c in LineOfNumbers)
        {
            int numeral = Convert.ToInt32(c.ToString());
            double value = Math.Pow(numeral, LineOfNumbers.Length);
            ResultofExponentiation = Convert.ToInt32(value);
            //resultat.Add(ResultofExponentiation);
            //numb = resultat.Sum();
            numb += ResultofExponentiation;
        }
        if (numb == number)
        {
            return true;
        }
        else
            return false;
    }
}