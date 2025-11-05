using System.Collections.Generic;
public interface IEmployeeRepository
{
    IEnumerable<Employee> GetEmployees();
    void AddEmployee(Employee employee);
}
