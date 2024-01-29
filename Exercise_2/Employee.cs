namespace Exercise_2;
public class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int BirthYear { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string surname, int birthYear, double salary)
    {
        Name = name;
        Surname = surname;
        BirthYear = birthYear;
        Salary = salary;
    }
}