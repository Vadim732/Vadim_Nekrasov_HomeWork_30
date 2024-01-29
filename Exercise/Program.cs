namespace Exercise
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(name: "Jhon", surname: "Johnson", birthYear: 1992, salary: 2300),
                new Employee(name: "Jason", surname: "Jackson", birthYear: 1998, salary: 1970),
                new Employee(name: "Julia", surname: "Jacobs", birthYear: 1995, salary: 2100)
            };
            Console.WriteLine("Employees (before sorting):");
            employees.ForEach(e => Console.WriteLine($"{e.Name} {e.Surname}, birth year: {e.BirthYear}, surname: {e.Salary}$"));

            employees.Sort(new NameComparer());
            Console.WriteLine("\nSorted Name:");
            employees.ForEach(e => Console.WriteLine(e.Name));

            employees.Sort(new SurnameComparer());
            Console.WriteLine("\nSorted Surname:");
            employees.ForEach(e => Console.WriteLine(e.Surname));

            employees.Sort(new BirthYearComparer());
            Console.WriteLine("\nSorted BirthYear:");
            employees.ForEach(e => Console.WriteLine(e.BirthYear));

            employees.Sort(new SalaryComparer());
            Console.WriteLine("\nSorted Salary:");
            employees.ForEach(e => Console.WriteLine(e.Salary));
        }
    }
}