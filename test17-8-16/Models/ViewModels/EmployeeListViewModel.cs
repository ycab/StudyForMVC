using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test17_8_16.Models.ViewModels;
namespace test17_8_16.Models.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }
    }
}