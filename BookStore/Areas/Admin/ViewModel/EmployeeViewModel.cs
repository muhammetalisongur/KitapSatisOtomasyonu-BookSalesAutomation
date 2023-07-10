using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Areas.Admin.ViewModel
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string EmployeeImage { get; set; }
        public string DepartmentName { get; set; }
    }
}