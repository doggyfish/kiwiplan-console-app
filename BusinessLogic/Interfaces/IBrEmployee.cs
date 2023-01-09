using Kiwiplan.Models;

namespace Kiwiplan.BusinessLogic.Interfaces;

public interface IBrEmployee
{
    List<Employee> GetAll();
    void DisplayHierarchyTree(List<Employee> employees, int managerId, int managementLevel);

}