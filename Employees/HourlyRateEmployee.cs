using System;

namespace Employees
{
    public class HourlyRateEmployee : Employee
	{
        private int HourlyRate;
        private int _hoursWorked;
        public int HoursWorked {
            get
            {
                return _hoursWorked;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Horas devem ser maiores que 0.");
                }
                _hoursWorked = value; 
            }
        }
		public HourlyRateEmployee(string name, EmployeeStatus status, int hourlyRate) : base(name, status)
        {
            this.HourlyRate = hourlyRate;
		}
        public HourlyRateEmployee(string name, int hourlyRate) : base(name)
        {
            this.HourlyRate = hourlyRate;
        }

        public override int CalculateSalary()
        {
            if (!Status.HasFlag(EmployeeStatus.Active))
            {
                return 0;
            }

            return HourlyRate * _hoursWorked;
        }
    }
}
