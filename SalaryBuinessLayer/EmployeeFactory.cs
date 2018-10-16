using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer.AbstractFactory;

namespace BusinessLayer.ConcreteFactory
{
   public abstract class EmployeeFactory
    {
        public abstract IEmployee Factory(string employeeType);

        public static implicit operator EmployeeFactory(ConcreteEmployeeFactory v)
        {
            throw new NotImplementedException();
        }
    }
}