using EmployeePayslips.DI_DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.ConcreteFactory;
using BusinessLayer.AbstractFactory;



namespace EmployeePayslips.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GeneratePayslip()
        {

            EmployeeFactory EmployeeFactory = new ConcreteEmployeeFactory();
            IEmployee permanentEmployee = EmployeeFactory.Factory("PermanentEmployee");
            permanentEmployee.details();

            IEmployee TemporaryEmployee = EmployeeFactory.Factory("TemporaryEmployee");
            TemporaryEmployee.details();

            
        }
   
      

    }
}