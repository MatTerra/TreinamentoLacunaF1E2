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
		public HourlyRateEmployee(string Name, EmployeeStatus Status, int HourlyRate) : base(Name, Status)
        {
            this.HourlyRate = HourlyRate;
		}
        public HourlyRateEmployee(string Name, int HourlyRate) : base(Name)
        {
            this.HourlyRate = HourlyRate;
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
