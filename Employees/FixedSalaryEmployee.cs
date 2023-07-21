using System;

namespace Employees
{
    public class FixedSalaryEmployee : Employee
	{
        private const float VacationAdditional = 1.3F;
        private const float SuspensionReduction = 0.9F;
        private int Salary;
		public FixedSalaryEmployee(string name, EmployeeStatus status, int salary): base(name, status)
        {
            this.Salary = salary;
		}

        public FixedSalaryEmployee(string name, int salary): base(name)
        {
            this.Salary = salary;
        }

        public override int CalculateSalary()
        {
            if (!Status.HasFlag(EmployeeStatus.Active))
            {
                return 0;
            } else if (Status.HasFlag(EmployeeStatus.InVacation))
            {
                return (int)(Salary * VacationAdditional);
            }
            else if (Status.HasFlag(EmployeeStatus.Suspended))
            {
                return (int)(Salary * SuspensionReduction);
            }
            return Salary;            
        }
    }
}
