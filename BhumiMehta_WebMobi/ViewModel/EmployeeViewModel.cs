using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BhumiMehta_WebMobi.Models;

namespace BhumiMehta_WebMobi.ViewModel
{
    public class EmployeeViewModel
    {
        
            public IEnumerable<Department> Department { get; set; }
            public Employee Employee { get; set; }
        
    }
}