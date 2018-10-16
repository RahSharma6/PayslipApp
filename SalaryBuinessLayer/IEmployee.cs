using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.AbstractFactory
{
   public interface IEmployee
    {

       string Fname { get; set; }
       string Lname { get; set; }
       string TypeOfEmployee { get; set; }
       int AnualSalary { get; set; }
       int SuperRate { get; set; }
       DateTime? PaymentStartDate { get; set; }
       void details();
    }
}
