using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        if (Bob.EndsWith(statement, "?"))
        {
            if (Bob.Number(statement))
            {
                return ("Sure.");
            }
            if (Bob.isAllUp(statement) && Bob.IsLetter(statement))
            {
                return ("Calm down, I know what I'm doing!");
            }
            else

                return ("Sure.");
        }
        if (statement.Length == 0)
        {
            return ("Fine. Be that way!");
        }


        if ((Bob.EndsWith(statement, "!") && Bob.isAllUp(statement)) || Bob.isAllUp(statement) && !Bob.Number(statement))
        {
            return ("Whoa, chill out!");
        }

        else
            return ("Whatever.");
    }

    static bool EndsWith(string statement, string s)
    {
        string sEndsWith = "";
        int sA = statement.Length;
        int sB = s.Length;
        if (sA < sB)
        {
            return false;
        }
        for (int i = sA - 1; i >= sA - sB; i--)
        {
            sEndsWith += statement[i];
        }

        return sEndsWith == s;
    }
    static bool Number(string statement)
    {
        int sA = statement.Length;
        for (int i = 0; i < sA; i++)
        {
            if (char.IsNumber(statement[i]))
            {
                return true;
            }
        }
        return false;
    }

    static bool isAllUp(string statement)
    {
        for (int i = 0; i < statement.Length; i++)
        {
            if (char.IsLower(statement[i]))
            {
                return false;
            }
        }
        return true;
    }
    static bool IsLetter(string statement)
    {
        for (int i = 0; i < statement.Length - 1; i++)
        {
            if (char.IsLetter(statement[i]))
            {
                return true;
            }
             
        }
           return false;
    }
}