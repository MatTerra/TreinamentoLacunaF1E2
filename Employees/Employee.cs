using System;

namespace Employees
{
	public abstract class Employee
	{
        public EmployeeStatus Status;
        public string Name { get; }
		public Employee(string name, EmployeeStatus status=EmployeeStatus.Active)
		{
			this.Status = status;
			this.Name = name;
		}

        public abstract int CalculateSalary();


	}
}