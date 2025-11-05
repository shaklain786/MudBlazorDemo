using AutoMapper;
using System.Collections.Generic;
using System.Linq;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repo;
    private readonly IMapper _mapper;

    public EmployeeService(IEmployeeRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public IEnumerable<EmployeeDto> GetDtos()
    {
        // Entity -> DTO
        return _repo.GetEmployees().Select(e => _mapper.Map<EmployeeDto>(e));
    }

    public void SaveDto(EmployeeDto dto)
    {
        // DTO -> Entity (via ReverseMap)
        var employee = _mapper.Map<Employee>(dto);
        _repo.AddEmployee(employee);
    }
}
