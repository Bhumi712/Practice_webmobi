using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BhumiMehta_WebMobi.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Display(Name = "Employee First Name")]
        public string EmployeeFirstName { get; set; }
        [Display(Name = "Employee Last Name")]
        public string EmployeeLastName { get; set; }
        [Display(Name = "Gender")]
        public string EmployeeGender { get; set; }
        public string EmployeeDOB { get; set; }
        [Display(Name = "Date of Birth")]
        public string Department { get; set; }
        [Display(Name = "Dept Name")]
        public int DepartmentId { get; set; }
        public object EmployeeDepartment { get; internal set; }
    }
}