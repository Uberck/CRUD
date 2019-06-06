using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CRUDweb.DataAccess
{
    public class EmployeeModel
    {
            
        [Range(100000, 999999, ErrorMessage = "Please enter a valid Employee ID.")]

        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]

        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}
