using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    [Authorize]
    [RouteArea("Admin")]
    public class HomeController : Controller
    {
        BookStoreContext context = new BookStoreContext();
        EmployeeManager _employeeManager = new EmployeeManager(new EfEmployeeDal());
        PublisherManager _publisherManager = new PublisherManager(new EfPublisherDal());
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        BookManager _bookManager = new BookManager(new EfBookDal());
        BookTranslatorManager _bookTranslatorManager = new BookTranslatorManager(new EfBookTranslatorDal());
        AuthorManager _authorManager = new AuthorManager(new EfAuthorDal());

        // GET: Admin/Home

        [Route("Anasayfa")]
        [Route("Anasayfa/Index")]
        public ActionResult Index()
        {
            ViewBag.EmployeeCount = _employeeManager.GetAll().Count();
            ViewBag.CategoryCount = _categoryManager.GetAll().Count();
            ViewBag.PublisherCount = _publisherManager.GetAll().Count();
            ViewBag.BookCount = _bookManager.GetAll().Count();
            ViewBag.BookTranslatorCount = _bookTranslatorManager.GetAll().Count();
            ViewBag.AuthorCount = _authorManager.GetAll().Count();


            return View();
        }

        public PartialViewResult _SocialMedia()
        {
            var result = context.Database.SqlQuery<EmployeeViewModel>(@"SELECT  Employees.*, Departments.DepartmentName
                                                                        FROM Employees JOIN
                                                                        Departments ON Employees.DepartmentID = Departments.ID").ToList();
            return PartialView("_SocialMedia", result);
        }


        public PartialViewResult TodoPartial()
        {
            return PartialView();
        }


        public PartialViewResult WeatherPartial()
        {
            return PartialView();
        }




    }
}