using Employees;
using Projeto;

namespace UI
{
    class ShowPaycheckCostPage : Page
    {

        public static string PageName = "showPaycheckCost";
        public override bool Run(GlobalData data, out string nextPage)
        {
            nextPage = MainPage.PageName;
            var totalValue = 0;
            foreach(var employee in data.EmployeeRepository.GetAll())
            {
                totalValue += employee.CalculateSalary();
            }
            Console.WriteLine("\nOs pagamentos vão custar {0:N0}", arg0: totalValue);
            return true;
        }
    }
}
