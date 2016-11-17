using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IPersoon
{
    string ToString();
}

public class Persoon : IPersoon
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }

    public Persoon(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    public override string ToString()
    {
        return "De naam van deze persoon is " + this.Name + "\n";
    }
}

public class Student : Persoon
{
    public String Major { get; set; }

    public Student(string name, int yearOfBirth, string major) : base(name, yearOfBirth)
    {
        this.Major = major;
    }

    public override string ToString()
    {
        return base.ToString() + "Deze student studeert " + this.Major;
    }
}

public class Instructor : Persoon
{
    public double Salary { get; set; }

    public Instructor(string name, int yearOfBirth, double salary) : base(name, yearOfBirth)
    {
        this.Salary = salary;
    }

    public override string ToString()
    {
        return base.ToString() + "Deze docent heeft een salaris van " + this.Salary;
    }
}
