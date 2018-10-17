using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer.AbstractFactory;

namespace BusinessLayer.AbstractProduct
{
    public class PermanentEmployee:IEmployee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string TypeOfEmployee { get; set; }
        public int AnualSalary { get; set; }
        public int SuperRate { get; set; }
        public DateTime? PaymentStartDate { get; set; }

        public void details()
        {
            
        }

        public dynamic PayslipDetails(string Fname, string Lname, Nullable<int> AnnualSalary, Nullable<double> SuperRate, string PayStartDate)
        {
            dynamic result = EmployeeDataLayer.Singleton.Instance.CreatePayslip(Fname, Lname, AnnualSalary, SuperRate, PayStartDate);

            return result;


        }
    }
}