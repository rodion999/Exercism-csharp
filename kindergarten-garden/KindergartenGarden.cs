using System;
using System.Collections;
using System.Collections.Generic;


public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    Plant[] pots;
    string[] students = new string[] { "Alice", "Bob", "Charlie", "David", "Eve", "Fred",
                                        "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"};

    public KindergartenGarden(string diagram)
    {
        diagram = diagram.Replace("\n", "");
        pots = new Plant[diagram.Length];

        for (int i = 0; i < diagram.Length; i++)
        {
            if (diagram[i] == 'V')
            {
                pots[i] = Plant.Violets;
            }
            else if (diagram[i] == 'R')
            {
                pots[i] = Plant.Radishes;
            }
            else if (diagram[i] == 'C')
            {
                pots[i] = Plant.Clover;
            }
            else if (diagram[i] == 'G')
            {
                pots[i] = Plant.Grass;
            }
        }
    }

    public IEnumerable<Plant> Plants(string student)
    {
        List<Plant> outval = new List<Plant>();
        int pos, first_half, second_half;

        try
        {
            pos = Array.IndexOf(students, student);
            first_half = 2 * pos;
            second_half = (pots.Length / 2) + first_half;
        }
        catch
        {
            throw new Exception("Give a valid student, dude.");
        }

        for (int i = 0; i < 2; i++)
        {
            outval.Add(pots[first_half]);
            first_half++;
        }
        for (int i = 0; i < 2; i++)
        {
            outval.Add(pots[second_half]);
            second_half++;
        }

        return outval;
    }
}