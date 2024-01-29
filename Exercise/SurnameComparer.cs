namespace Exercise;
public class SurnameComparer : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
    {
        return string.Compare(x.Surname, y.Surname);
    }
}