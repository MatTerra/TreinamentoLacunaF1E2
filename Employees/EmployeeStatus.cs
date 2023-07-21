using System;

namespace Employees
{
    [Flags]
    public enum EmployeeStatus
    {
        Inactive = 0,
        Active = 1,
        InVacation = 2,
        Suspended = 4
    }
}
