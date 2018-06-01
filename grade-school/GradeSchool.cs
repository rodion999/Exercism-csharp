using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
    Dictionary<int, List<string>> dBaseStudents = new Dictionary<int, List<string>>();
    public void Add(string student, int grade)
    {
        if (!dBaseStudents.ContainsKey(grade))
            dBaseStudents.Add(grade, new List<string>());
        dBaseStudents[grade].Add(student);
  
    }
    public IEnumerable<string> Roster()
    {
        var result = new List<string>();
        foreach (var student in dBaseStudents.OrderBy(s => s.Key))
        {
            student.Value.Sort();
            result.AddRange(student.Value);
        }
        return result.ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (!dBaseStudents.ContainsKey(grade))
            return new List<string>();
        dBaseStudents[grade].Sort();
        return dBaseStudents[grade].ToArray();
    }
}