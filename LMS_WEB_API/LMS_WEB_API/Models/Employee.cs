using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_WEB_API.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your mobile number")]
        [Display(Name = "Mobile number")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Please enter your email id")]
        [Display(Name = "Email Id")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Please the date joined")]
        [Display(Name = "Date Joined")]
        [DataType(DataType.Date)]
        public string DateJoined { get; set; }
        [Required(ErrorMessage = "Please the your department")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Please enter your designation")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Please enter your Manager name")]
        [Display(Name = "Manager Name")]
        public string ManagerName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Salary { get; set; }
        
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
