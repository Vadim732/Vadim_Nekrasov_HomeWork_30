namespace Exercise;
public class NameComparer : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
    {
        return string.Compare(x.Name, y.Name);
    }
}