using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
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


        [Route("Personel")]
        [Route("Personel/Index")]
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;
            var result = manager.GetAll().ToPagedList<Employee>(_sayfaNo, 5);
            return View(result);
        }
    }
}