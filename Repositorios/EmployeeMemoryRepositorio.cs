using Employees;
using Projeto.Repositorios;

namespace Repositorios
{
    class EmployeeMemoryRepositorio : IRepositorio<Employee>
    {
        private List<Employee> employees = new();
        public void Add(Employee entry)
        {
            employees.Add(entry);
        }

        public List<Employee> GetAll()
        {
            return employees;
        }
    }
}
