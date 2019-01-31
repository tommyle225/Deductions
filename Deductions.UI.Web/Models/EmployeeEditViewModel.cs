using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Deductions.UI.Web.Models
{
    public class EmployeeEditViewModel
    {
        [Display(Name = "Employee #")]
        public string EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Dependents")]
        public List<DependentViewModel> Dependents { get; set; }
    }


}