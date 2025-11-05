using System.Collections.Generic;
using System.Linq;

public class EmployeeRepository : IEmployeeRepository
{
    private static readonly List<Employee> employees = new()
    {
        new Employee{ Id=1, Name="Amit", Department="HR", Email="amit@hr.com" },
        new Employee{ Id=2, Name="Raj", Department="IT", Email="raj@it.com" }
    };

    public IEnumerable<Employee> GetEmployees() => employees;

    public void AddEmployee(Employee employee)
    {
        employee.Id = employees.Max(e => e.Id) + 1;
        employees.Add(employee);
    }
}
