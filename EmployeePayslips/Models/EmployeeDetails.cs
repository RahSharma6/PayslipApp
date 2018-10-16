using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePayslips.Models
{
    public abstract class EmployeeDetails
    {
        public string Fname { get; set; }
        public string Lname { get; set; }

        public virtual string FullName() {
            return Fname + " " + Lname;
        }
    }
}