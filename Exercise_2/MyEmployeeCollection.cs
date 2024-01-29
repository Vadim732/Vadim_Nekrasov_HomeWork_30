using System.Collections;
namespace Exercise_2;
class EmployeeCollection : IEnumerable<Employee>
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }
    public IEnumerator<Employee> GetEnumerator()
    {
        return employees.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}