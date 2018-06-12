using System;
using System.Collections.Generic;

public class Allergies
{
    int map = 0xFF, results;
    string[] allergy_map = new string[] {"eggs", "peanuts", "shellfish", "strawberries",
        "tomatoes", "chocolate", "pollen", "cats"};
    List<string> allergy_list;

    public Allergies(int mask)
    {
        results = mask & map;
        allergy_list = new List<string>();

        for (int i = 0; i < 8; i++)
        {
            if ((results & 0x01) != 0)
            {
                allergy_list.Add(allergy_map[i]);
            }

            results = results >> 1;
        }
    }

    public bool IsAllergicTo(string allergy)
    {
        return allergy_list.Contains(allergy);
    }

    public IList<string> List()
    {
        return allergy_list;
    }
}