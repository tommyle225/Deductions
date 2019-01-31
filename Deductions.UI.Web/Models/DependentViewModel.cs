using Deduction.Core;
using System.ComponentModel.DataAnnotations;

namespace Deductions.UI.Web.Models
{
    public class DependentViewModel
    {
        public string EmployeeId { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name ="Select Dependent Type")]
        public DependentType DependentType { get; set; }
    }


}