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
    public class YazarController : Controller
    {
        // GET: Admin/Yazar
        Context db = new Context();
        
        public ActionResult Index(int? sayfaNo)
        {
            int _sayfaNo = sayfaNo ?? 1;
            var listele = db.Yazarlar.OrderByDescending(x=>x.YazarId).ToPagedList<Yazarlar>(_sayfaNo,10);
            return View(listele);
        }

        [HttpGet]
        public ActionResult Yeni()
        {
            return View("YazarForm",new Yazarlar());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Yazarlar yazar)
        {
            if (!ModelState.IsValid)
            {
                return View("YazarForm");
            }
            MesajViewModel model = new MesajViewModel();
            if (yazar.YazarId == 0)
            {
                db.Yazarlar.Add(yazar);
                model.Mesaj = yazar.Ad + " başarıyle eklendi...";
            }
            else
            {
                var guncellenecekYazar = db.Yazarlar.Find(yazar.YazarId);
                if (guncellenecekYazar == null)
                {
                    return HttpNotFound();
                }
                guncellenecekYazar.Ad = yazar.Ad;
                guncellenecekYazar.Soyad = yazar.Soyad;
                guncellenecekYazar.Detay = yazar.Detay;
                model.Mesaj = yazar.Ad + " başarıyla güncellendi...";
                model.Mesaj = yazar.Soyad + " başarıyla güncellendi...";
                model.Mesaj = yazar.Detay + " başarıyla güncellendi...";

            }
            db.SaveChanges();
            model.Status = true;
            return View("_Mesaj", model);
        }

        public ActionResult Guncelle(int id)
        {
            var model = db.Yazarlar.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("YazarForm", model);
        }

        public ActionResult Sil(int id)
        {
            var silinecekYazar = db.Yazarlar.Find(id);
            if (silinecekYazar == null)
                return HttpNotFound();
            db.Yazarlar.Remove(silinecekYazar);
            db.SaveChanges();
            return RedirectToAction("Index", "Yazar");

        }
    }
}