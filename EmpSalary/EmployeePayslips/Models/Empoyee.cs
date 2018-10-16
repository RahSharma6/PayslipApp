using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeePayslips.Models
{
    public class Empoyee:EmployeeDetails,IPayslips
    {
        [Required(ErrorMessage = "First name is required")]
        public new string Fname { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public new string Lname { get; set; }

        public DateTime? PaymentStartDate
        {get; set; }

        [Required(ErrorMessage = "Super rate is required")]
        [Range(0, 12, ErrorMessage = "SuperRate should be between 0 to 12")]
        public int SuperRate
        { get; set; }

        [Required(ErrorMessage = "Anual Salary is required")]
        public int AnualSalary
        { get; set; }
    }
}