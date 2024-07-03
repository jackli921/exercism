using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private Dictionary<string, int> _students;

    public GradeSchool()
    {
        _students = new Dictionary<string, int>();

    }

    public bool Add(string student, int grade)
    {
        if (!_students.ContainsKey(student))
        {
            _students.Add(student, grade);
            return true;
        }
        else
        {
            return false;
        }
    }

    public IEnumerable<string> Roster()
    {
        return _students.OrderBy(x => x.Value)
            .ThenBy(x => x.Key)
            .Select(x => x.Key);
    }

    public string[] Grade(int grade)
    {
        return _students.Where(x => x.Value == grade)
                        .Select(x => x.Key)
                        .OrderBy(x => x)
                        .ToArray();
    }
}