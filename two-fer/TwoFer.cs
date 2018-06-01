using System;

public static class TwoFer
{
    public static string Name(string input = null)
    {
        string sName = string.IsNullOrEmpty(input) ? "you" : input; 
        string sAnswer = String.Format("One for {0}, one for me.", sName);
        return sAnswer;

        //string sAnswer = ("One for , one for me.");
        //if (input == null)
        //    return (sAnswer.Insert(8, "you"));
        //else return (sAnswer.Insert(8, input));
    }
}
