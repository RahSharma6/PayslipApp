using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayslips.Models
{
    public interface IPayslips
    {

        DateTime? PaymentStartDate { get; set; }

        int SuperRate { get; set; }

        int AnualSalary { get; set; }
        
    }
}
