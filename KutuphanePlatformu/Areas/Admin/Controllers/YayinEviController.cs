using KutuphanePlatformu.Models.EntityFramework;
using KutuphanePlatformu.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphanePlatformu.Areas.Admin.Controllers
{
    public class YayinEviController : Controller
    {
        // GET: Admin/YayinEvi
        KutuphanePlatformDbEntities db = new KutuphanePlatformDbEntities();
        [Route("YayinEvi")]
        public ActionResult Index(int? sayfaNo)
        {
            int _sayfaNo = sayfaNo ?? 1;
            var listele = db.YayinEvi.OrderByDescending(x => x.Id).ToPagedList(_sayfaNo, 10);
            return View(listele);
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View("YayinEviForm", new YayinEvi());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(YayinEvi yayinEvi)
        {
            if (!ModelState.IsValid)
            {
                return View("YayinEviForm");
            }
            MesajViewModel model = new MesajViewModel();
            if (yayinEvi.Id == 0)
            {
                db.YayinEvi.Add(yayinEvi);
                model.Mesaj = yayinEvi.Ad + " başarıyle eklendi...";
            }
            else
            {
                var guncellenecekYayinEvi = db.YayinEvi.Find(yayinEvi.Id);
                if (guncellenecekYayinEvi == null)
                {
                    return HttpNotFound();
                }
                guncellenecekYayinEvi.Ad = yayinEvi.Ad;
                guncellenecekYayinEvi.Kitaplari = yayinEvi.Kitaplari;
                guncellenecekYayinEvi.Detay = yayinEvi.Detay;
                guncellenecekYayinEvi.Resim = yayinEvi.Resim;
                model.Mesaj = yayinEvi.Ad + " başarıyla güncellendi...";    
                model.Mesaj = yayinEvi.Kitaplari + " başarıyla güncellendi...";    
                model.Mesaj = yayinEvi.Detay + " başarıyla güncellendi...";
                model.Mesaj = yayinEvi.Resim + " başarıyla güncellendi...";

            }
            db.SaveChanges();
            model.Status = true;
            return View("_Mesaj", model);
        }

        public ActionResult Guncelle(int id)
        {
            var model = db.YayinEvi.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("YayinEviForm", model);
        }

        public ActionResult Sil(int id)
        {
            var silinecekYayinEvi = db.YayinEvi.Find(id);
            if (silinecekYayinEvi == null)
                return HttpNotFound();
            db.YayinEvi.Remove(silinecekYayinEvi);
            db.SaveChanges();
            return RedirectToAction("Index", "YayinEvi");

        }

    }
}