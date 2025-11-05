using AutoMapper;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

public partial class EmployeeViewModel : ObservableObject
{
    private readonly IEmployeeRepository _repo;
    private readonly IMapper _mapper;

    [ObservableProperty]
    private ObservableCollection<EmployeeTableModel> employees = new();

    [ObservableProperty]
    private bool hideEmail;

    [ObservableProperty]
    private bool loading;

    public EmployeeViewModel(IEmployeeRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public void Load()
    {
        loading = true;
        var dtos = _repo.GetEmployees().Select(e => _mapper.Map<EmployeeDto>(e)).ToList();
        Employees = new ObservableCollection<EmployeeTableModel>(
            dtos.Select(dto => _mapper.Map<EmployeeTableModel>(dto))
        );
        loading = false;
    }
}
