using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using test17_8_16.Models;
using test17_8_16.Models.ViewModels;
namespace test17_8_16.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "hello World is old now";
        }
        public ActionResult MyView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;
          
            EmployeeViewModel vmEmp =new EmployeeViewModel();
            vmEmp.EmployeeName =emp.FirstName+" "+emp.LastName;
            vmEmp.Salary=emp.Salary.ToString("C");
            if(emp.Salary>15000)
            {
                vmEmp.SalaryColor="yellow";
            }
            else
            {
                vmEmp.SalaryColor="green";
            }
     
            return View("MyView",vmEmp);
        }
        public ActionResult GetView()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();

            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            employeeListViewModel.UserName = "Admin";
            return View("MyView", employeeListViewModel);
        }
 

    }

}