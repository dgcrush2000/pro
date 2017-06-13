using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pro.Models
{
    public class Employees
    {
        [Key] 

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
    }
}