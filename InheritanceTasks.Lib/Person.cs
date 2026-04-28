namespace InheritanceTask.Lib;

public class Person
{
    private string _fname;
    private string _sname;
    private string _email = "";
    private DateTime _dob;
    public int Age => CalculateAge(_dob);

    public bool Valid => isValidDob(Age);
    public bool Adult => Age >= 18;
    public string ChineseSign => getChineseSign(_dob);
    public bool Birthday => isBirthday(_dob);
    public string ScreenName => getScreenName(_fname,_sname,_dob);

    public Person(string fname, string sname, string email, string dob)
    {
        _fname = fname;
        _sname = sname;
        _email = email;
        _dob = DateTime.Parse(dob);
    }

    public Person(string fname, string sname, string dob)
    {
        _fname = fname;
        _sname = sname;
        _dob =  DateTime.Parse(dob);
    }

    internal int CalculateAge(DateTime dob)
    {

        int age = DateTime.Now.Year - dob.Year;
        if (dob > DateTime.Now.AddYears(-age)) age--;
        return age;
    }

    internal bool isValidDob(int age)
    {        
        return age < 0;
    }

    internal string getChineseSign(DateTime dob)
    {
        int year = dob.Year;
        string[] signs = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat" };
        return signs[year % 12];
    }

    internal bool isBirthday(DateTime dob)
    {
        return dob.Month == DateTime.Now.Month && dob.Day == DateTime.Now.Day;
    }

    internal virtual string getScreenName(string fname, string sname, DateTime dob)
    {
        return sname + fname[0] + dob.Year.ToString();
    }
}
