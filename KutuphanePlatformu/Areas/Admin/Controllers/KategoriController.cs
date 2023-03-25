using KutuphanePlatformu.Models.EntityFramework;
using KutuphanePlatformu.ViewModels;
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
            var listele = db.Kategori.OrderByDescending(m => m.Id).ToPagedList<Kategori>(_sayfaNo, 10);
            return View(listele);
        }

        [HttpGet]
        public ActionResult Yeni()
        {
            return View("KategoriForm",new Kategori());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Kategori kategori)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriForm");
            }
            MesajViewModel model = new MesajViewModel();
            if (kategori.Id == 0)
            {
                db.Kategori.Add(kategori);
                model.Mesaj = kategori.Ad + " başarıyle eklendi...";
            }
            else
            {
                var guncellenecekKategori = db.Kategori.Find(kategori.Id);
                if (guncellenecekKategori == null)
                {
                    return HttpNotFound();
                }
                guncellenecekKategori.Ad = kategori.Ad;
                model.Mesaj = kategori.Ad + " başarıyla güncellendi...";

            }
            db.SaveChanges();
            model.Status = true;
            model.LinkText = "Kategori Listesi";
            model.Url = "/Admin/Kategori";
            return View("_Mesaj", model);
        }

        public ActionResult Guncelle(int id)
        {
            var model = db.Kategori.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("KategoriForm", model);
        }

        public ActionResult Sil(int id)
        {
            var silinecekKategori = db.Kategori.Find(id);
            if (silinecekKategori == null)
                return HttpNotFound();
            db.Kategori.Remove(silinecekKategori);
            db.SaveChanges();
            return RedirectToAction("Index", "Kategori");

        }

    }
}