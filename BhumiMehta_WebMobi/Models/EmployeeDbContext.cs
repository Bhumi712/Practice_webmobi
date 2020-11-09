using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BhumiMehta_WebMobi.Models;
using System.Data.Entity;

namespace BhumiMehta_WebMobi.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {
            
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }



    }
}