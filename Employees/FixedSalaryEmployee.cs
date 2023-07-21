using System;

namespace Employees
{
    public class FixedSalaryEmployee : Employee
	{
        private const float VacationAdditional = 1.3F;
        private const float SuspensionReduction = 0.9F;
        private int Salary;
		public FixedSalaryEmployee(string Name, EmployeeStatus Status, int Salary): base(Name, Status)
        {
            this.Salary = Salary;
		}

        public FixedSalaryEmployee(string Name, int Salary): base(Name)
        {
            this.Salary = Salary;
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
