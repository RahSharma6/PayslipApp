using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer.AbstractFactory;

namespace BusinessLayer.AbstractProduct
{
    public class TemporaryEmployee:IEmployee
    {
        public int AnualSalary
        
            { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public DateTime? PaymentStartDate
        { get; set; }

        public int SuperRate
        { get; set; }

        public string TypeOfEmployee { get; set; }

        public void details()
        {
            throw new NotImplementedException();
        }
    }
}