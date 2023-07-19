using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class HomeController : Controller
    {
        // GET: Admin/Home

        [Route("Anasayfa")]
        [Route("Anasayfa/Index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}