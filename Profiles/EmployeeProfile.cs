using AutoMapper;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<Employee, EmployeeDto>().ReverseMap();
        CreateMap<EmployeeDto, EmployeeTableModel>().ReverseMap();
    }
}
