using KutuphanePlatformu.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphanePlatformu.Areas.Admin.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Admin/Kategori
        KutuphanePlatformDbEntities db = new KutuphanePlatformDbEntities();
        public ActionResult Index()
        {
           var listele= db.Kategori.ToList();
            return View(listele);
        }
    }
}