using Deductions.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Deduction.Core;

namespace Deductions.UI.Web.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CalculateEmployeeDeductions(EmployeeEditViewModel employeeViewModel)
        {
            Employee employee = new Employee(employeeViewModel.FirstName, employeeViewModel.LastName);
            if (employeeViewModel.Dependents != null)
            {
                employeeViewModel.Dependents.ForEach(d => employee.AddDependent(new Dependent(d.DependentType, d.FirstName, d.LastName)));
            }

            decimal cost = DeductionCalculator.CalculateDeductionCost(employee);
            decimal finalCost = DeductionCalculator.Compute(employee.GetSalary(), cost);

            return Json(new
            {
                Salary = employee.GetSalary().ToString("C"),
                Deduction = $"{cost.ToString("C")}",
                Total = $"{finalCost.ToString("C")}"
            });
        }

        public ActionResult Create()
        {
            return View(new EmployeeEditViewModel { EmployeeId = Guid.NewGuid().ToString(), Dependents = new List<DependentViewModel>() });
        }

        public ActionResult DependentPartial(string employeeId)
        {
            return PartialView("Dependent", new DependentViewModel { EmployeeId = employeeId });
        }
    }
}
