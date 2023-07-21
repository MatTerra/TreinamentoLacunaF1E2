using Employees;
using Projeto.Repositorios;

namespace Projeto
{
    class GlobalData
    {
        public IRepositorio<Employee> EmployeeRepository;

        public GlobalData(IRepositorio<Employee> employeeRepository)
        {
            EmployeeRepository = employeeRepository;   
        }
    }
}
