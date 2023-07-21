using Employees;
using Projeto;

namespace UI
{
    class ShowEmployeeCostPage : Page
    {

        public static string PageName = "showEmployeeCost";
        public override bool Run(GlobalData data, out string nextPage)
        {
            nextPage = MainPage.PageName;
            Console.WriteLine("\nInsira o nome do funcionário:");
            var name = Console.ReadLine();
            var employee = data.EmployeeRepository.Get(name);
            Console.WriteLine("\nO funcionário {0} vai custar {1:N0}", arg0: employee.Name, arg1: employee.CalculateSalary());
            return true;
        }
    }
}
