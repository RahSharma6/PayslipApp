using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer.AbstractFactory;

namespace BusinessLayer.AbstractProduct
{
    public class TemporaryEmployee:IEmployee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string TypeOfEmployee { get; set; }

        public void details()
        {
            throw new NotImplementedException();
        }
    }
}