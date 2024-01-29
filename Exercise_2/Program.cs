namespace Exercise_2
{
    class Program
    {
        static void Main()
        {
            EmployeeCollection employeeCollection = new EmployeeCollection();
            employeeCollection.AddEmployee(new Employee("Jhon", "Johnson", 1992, 2300.15));
            employeeCollection.AddEmployee(new Employee("Jason", "Jackson", 1998, 1970.8));
            employeeCollection.AddEmployee(new Employee("Julia", "Jacobs", 1995, 2100));

            foreach (Employee employee in employeeCollection)
            {
                Console.WriteLine($"{employee.Name} {employee.Surname}, birth year: {employee.BirthYear}, surname: {employee.Salary}$");
            }
        }
    }
}
