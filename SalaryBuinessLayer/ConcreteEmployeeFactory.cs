using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer.AbstractFactory;
using BusinessLayer.AbstractProduct;

namespace BusinessLayer.ConcreteFactory
{
    public class ConcreteEmployeeFactory
    {
        public  IEmployee Factory(string employeeType)
        {
            switch (employeeType)
            {
                case "PermanentEmployee":
                    return new PermanentEmployee();
                case "TemporaryEmployee":
                    return new TemporaryEmployee();
                default:
                    throw new ApplicationException(string.Format("This type of employee can not be created"));
            }
        }
    }
}