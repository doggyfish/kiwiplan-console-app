using Kiwiplan.BusinessLogic;
using Kiwiplan.BusinessLogic.Interfaces;

namespace Kiwiplan
{
    class Program
    {
        static void Main(string[] args)
        {
            IBrEmployee brEmployee = new BrEmployee();
            DisplayManagementTree(brEmployee);
        }

        public static void DisplayManagementTree(IBrEmployee brEmployee)
        {
           var allEmployees = brEmployee.GetAll();
           //set root management level to one, to match the number of intentation needs to be repeated.
           brEmployee.DisplayHierarchyTree(allEmployees, 0, 1);
        }
    }
}