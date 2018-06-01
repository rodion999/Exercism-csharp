using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
    class BaseStudents
    {
        public int iNumberClass = 0;
        public string sNameStudent = "";
        public string SNameStudent { get => sNameStudent; set => sNameStudent = value; }
    }
    List<BaseStudents> lAllStudents = new List<BaseStudents>();
    
    public void Add(string student, int grade)
    {
        if (!lGrade.Contains(grade))
            new List<string>();
        lGrade.Add(grade);
        lRoster.Add(student);

    }
    public IEnumerable<string> Roster()
    {
        lGrade.Sort();
        foreach (var v in lGrade)
        {
            lRoster.Sort();
        }

        return lRoster.ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (!lGrade.Contains(grade))
            return new List<string>();
        lGrade.Sort();
        foreach (var v in lGrade)
        {
            lRoster.Sort();
        }
        return lRoster.ToArray();
    }
}