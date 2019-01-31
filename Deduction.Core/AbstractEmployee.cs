using System;
using System.Collections.Generic;

namespace Deduction.Core
{
    public class LocalEmployeesData
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();
    }

    public interface IDiscount
    {
        decimal GetDiscount();
    }
}
