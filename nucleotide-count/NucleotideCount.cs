using System;
using System.Collections.Generic;

public class NucleotideCount
{
    public Dictionary<char, int> NucleotideCountDictionary;
    public NucleotideCount(string sequence)
    {
        var dictionary = new Dictionary<char, int>();
        dictionary.Add('A', 0);
        dictionary.Add('C', 0);
        dictionary.Add('G', 0);
        dictionary.Add('T', 0);
        foreach (char n in sequence)
        {
            dictionary[n]++;
        }
        NucleotideCountDictionary = dictionary;
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            return this.NucleotideCountDictionary;
        }
    }
}
public class InvalidNucleotideException : Exception
{
    public InvalidNucleotideException()
    {
        throw new InvalidNucleotideException();
    }
}
