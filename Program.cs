using Kiwiplan.BusinessLogic;
using Kiwiplan.BusinessLogic.Interfaces;
using Kiwiplan.Infrastructure;
using Kiwiplan.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Kiwiplan
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup DI
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IBrEmployee, BrEmployee>()
            .AddSingleton<ILogger, ConsoleLogger>()
            .BuildServiceProvider();

            IBrEmployee brEmployee  = serviceProvider.GetService<IBrEmployee>();
            DisplayManagementTree(brEmployee);
        }

        private static void DisplayManagementTree(IBrEmployee brEmployee)
        {
           var allEmployees = brEmployee.GetAll();
           //set root management level to one, to match the number of intentation needs to be repeated.
           brEmployee.DisplayHierarchyTree(allEmployees, 0, 1);
        }
    }
}