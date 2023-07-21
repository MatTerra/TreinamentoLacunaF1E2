using System;

namespace Employees
{
	public abstract class Employee
	{
        public EmployeeStatus Status;
        public string Name { get; }
		public Employee(string Name, EmployeeStatus Status=EmployeeStatus.Active)
		{
			this.Status = Status;
			this.Name = Name;
		}

        public abstract int CalculateSalary();


	}
}