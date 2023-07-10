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
            var query = (from x in manager.GetAll()
                         join c in context.Departments on x.ID equals c.ID
                         select new EmployeeViewModel
                         {            
                             ID = x.ID,
                             Name = x.Name,
                             Surname = x.Surname,
                             FullName = x.Name + " " + x.Surname,
                             Email = x.Email,
                             Password = x.Password,
                             Status = x.Status,
                             AuthorImage = x.AuthorImage,
                             Departman = c.DepartmentName,                      

                         }).ToList();



            //var result = manager.GetAll().ToList();
            return View(query);
        }
    }
}