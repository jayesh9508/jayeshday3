using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3.ViewModels;
namespace Day3.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            EmpViewModel obj = new EmpViewModel()
            { EmployeeId = 1, FirstName = "Jayesh", LastName = "Shrivastava", DepartmentId = 1, DepartmentName = "FS" };
            return View(obj);

        }
    }
}