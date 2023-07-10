using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class EmployeeController : Controller
    {
        // GET: Admin/Employee
        EmployeeManager manager = new EmployeeManager(new EfEmployeeDal());
        MessageViewModel messageViewModel = new MessageViewModel();
        BookStoreContext context = new BookStoreContext();



        [Route("Personel")]
        [Route("Personel/Index")]
        public ActionResult Index()
        {

            var result = context.Database.SqlQuery<EmployeeViewModel>(@"SELECT  Employees.*, Departments.DepartmentName
                                                                        FROM Employees JOIN
                                                                        Departments ON Employees.DepartmentID = Departments.ID").ToList();

            return View(result);
        }
    }
}