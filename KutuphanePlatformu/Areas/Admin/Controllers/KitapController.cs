using KutuphanePlatformu.Models.EntityFramework;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphanePlatformu.Areas.Admin.Controllers
{
    public class KitapController : Controller
    {
        // GET: Admin/Kitap
        Context db = new Context();
        public ActionResult Index(int? sayfaNo)
        {
            int _sayfaNo = sayfaNo ?? 1;
            var listele = db.Kitaplar.OrderByDescending(x=>x.KategoriId).ToPagedList<Kitaplar>(_sayfaNo,10);
            return View(listele);
        }
    }
}