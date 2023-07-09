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


        [Route("Personel")]
        [Route("Personel/Index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}