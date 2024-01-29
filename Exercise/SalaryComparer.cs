namespace Exercise;
public class SalaryComparer : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
    {
        return x.Salary.CompareTo(y.Salary);
    }
}