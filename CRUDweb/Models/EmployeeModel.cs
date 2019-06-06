using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CRUDweb.Models
{
    public class EmployeeModel
    {
            
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid Employee ID")]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
