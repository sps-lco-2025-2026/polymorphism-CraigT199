namespace InheritanceTask.Lib;

public class Student : Person
{
    private string _schoolYear;

    public Student(string fname, string sname, string dob, string year) : base(fname, sname, dob)
    {
        if (year == null)
        {
            _schoolYear = year;
        }
        else
        {
            _schoolYear = calculateSchoolYear(Age);
        }
    }

    public Student(string fname, string sname, string dob) : this(fname, sname,dob,"") {}

    internal string calculateSchoolYear(int age)
    {
        if (age >= 4 && age <= 17)
            return $"Year {age-4}";
        return "Invalid";
    }
}
