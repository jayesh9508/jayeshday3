using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Day3.Models;
namespace Day3.ViewModels
{
    public class EmpViewModel
    {
        Employee Emp = new Employee();
        public int EmployeeId
        {
            get { return Emp.EmployeeId; }
            set { Emp.EmployeeId = value; }
        }
        public string FirstName
        {
            get { return Emp.FirstName; }
            set { Emp.FirstName = value; }
        }
        public string LastName
        {
            get { return Emp.LastName; }
            set { Emp.LastName = value; }
        }
        Department Dept = new Department();
        public int DepartmentId
        {
            get { return Dept.DepartmentId; }
            set { Dept.DepartmentId = value; }
        }
        public string DepartmentName
        {
            get { return Dept.DepartmentName; }
            set { Dept.DepartmentName = value; }
        }

    }
}