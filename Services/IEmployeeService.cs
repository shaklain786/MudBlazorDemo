using System.Collections.Generic;
public interface IEmployeeService
{
    IEnumerable<EmployeeDto> GetDtos();
    void SaveDto(EmployeeDto dto);
}
