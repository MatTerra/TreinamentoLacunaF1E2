using Employees;
using Projeto;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using Repositorios;
using Projeto.Repositorios;

namespace UI
{
    class CreateEmployeePage : Page
    {

        private const ConsoleKey FixedSalaryOption = ConsoleKey.D1;
        private const ConsoleKey HourlyRateOption = ConsoleKey.D2;
        public static string PageName = "createEmployee";
        public override bool Run(GlobalData data, out string nextPage)
        {
            nextPage = PageName;
            try
            {
                Console.WriteLine("\nCriação de Novo Empregado\n\n\tInsira o nome:");
                var name = Console.ReadLine();
                if (name == null)
                {
                    return false;
                }
                Console.WriteLine("\nQual o tipo de remuneração?\n\n\t1 - Salário Fixo\n\t2 - Por Hora");
                var tipoRemuneracao = Console.ReadKey().Key;

                return tipoRemuneracao switch
                {
                    FixedSalaryOption => CreateFixedRateEmployee(repositorio: data.EmployeeRepository, name: name, nextPage: out nextPage),
                    HourlyRateOption => CreateHourlyRateEmployee(name, data.EmployeeRepository, out nextPage),
                    _ => false
                };
            }
            catch
            {
                return false;
            }
        }

        private bool CreateFixedRateEmployee(string name, IRepositorio<Employee> repositorio, out string nextPage)
        {
            Console.WriteLine("\nInsira o Salário:");
            var salary = int.Parse(Console.ReadLine());
            repositorio.Add(new FixedSalaryEmployee(name, salary));
            nextPage = MainPage.PageName;
            return true;
        }

        private bool CreateHourlyRateEmployee(string name, IRepositorio<Employee> repositorio, out string nextPage)
        {
            Console.WriteLine("\nInsira o valor da hora:");
            var hourlyRate = int.Parse(Console.ReadLine());
            var employee = new HourlyRateEmployee(name, hourlyRate);
            Console.WriteLine("\nInsira as horas trabalhadas:");
            var hoursWorked = int.Parse(Console.ReadLine());
            employee.HoursWorked = hoursWorked;
            repositorio.Add(employee);
            nextPage = MainPage.PageName;
            return true;
        }
    }
}
