using KutuphanePlatformu.Models.EntityFramework;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace KutuphanePlatformu.Areas.Admin.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Admin/Kategori
        KutuphanePlatformDbEntities db = new KutuphanePlatformDbEntities();
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;
            var listele= db.Kategori.OrderByDescending(m => m.Id).ToPagedList<Kategori>(_sayfaNo, 10);
            return View(listele);
        }
    }
}