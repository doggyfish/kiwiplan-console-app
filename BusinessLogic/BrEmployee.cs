using Kiwiplan.BusinessLogic.Interfaces;
using Kiwiplan.Infrastructure.Interfaces;
using Kiwiplan.Models;

namespace Kiwiplan.BusinessLogic;

public sealed class BrEmployee : BrBase, IBrEmployee
{
    private readonly ILogger _logger;
    public BrEmployee(ILogger logger)
    {
        _logger = logger;
    }
    public List<Employee> GetAll()
    {
        var employees = new List<Employee>();
        employees.Add(new Employee { EmployeeId = 1, Name = "Tom", ManagerId = 0 });
        employees.Add(new Employee { EmployeeId = 2, Name = "Mickey", ManagerId = 1 });
        employees.Add(new Employee { EmployeeId = 3, Name = "Jerry", ManagerId = 1 });
        employees.Add(new Employee { EmployeeId = 4, Name = "John", ManagerId = 2 });
        employees.Add(new Employee { EmployeeId = 5, Name = "Sarah", ManagerId = 1 });

        return employees;
    }

    #region Support Fn | DisplayHierarchyTree
    #endregion

    public void DisplayHierarchyTree(List<Employee> employees, int managerId, int managementLevel)
    {
        List<Employee> employeeGroup = employees.Where(x => x.ManagerId  == managerId).OrderBy(s => s.Name).ToList();
        foreach (Employee employee in employeeGroup)
        {
            string logs = String.Format("{0}{1}", "->".Repeat(managementLevel), employee.Name);
            _logger.Log(logs);
            DisplayHierarchyTree(employees, employee.EmployeeId, managementLevel+1);
        }
    }
}