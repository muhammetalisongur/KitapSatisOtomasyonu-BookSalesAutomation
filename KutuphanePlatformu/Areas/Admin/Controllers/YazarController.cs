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
        KutuphanePlatformDbEntities db = new KutuphanePlatformDbEntities();
        
        public ActionResult Index(int? sayfaNo)
        {
            int _sayfaNo = sayfaNo ?? 1;
            var listele = db.Yazar.OrderByDescending(x=>x.Id).ToPagedList<Yazar>(_sayfaNo,10);
            return View(listele);
        }

        [HttpGet]
        public ActionResult Yeni()
        {
            return View("YazarForm",new Yazar());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Yazar yazar)
        {
            if (!ModelState.IsValid)
            {
                return View("YazarForm");
            }
            MesajViewModel model = new MesajViewModel();
            if (yazar.Id == 0)
            {
                db.Yazar.Add(yazar);
                model.Mesaj = yazar.Ad + " başarıyle eklendi...";
            }
            else
            {
                var guncellenecekYazar = db.Yazar.Find(yazar.Id);
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
            model.LinkText = "Yazar Listesi";
            model.Url = "/Admin/Yazar";
            return View("_Mesaj", model);
        }

        public ActionResult Guncelle(int id)
        {
            var model = db.Kategori.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("YazarForm", model);
        }

        public ActionResult Sil(int id)
        {
            var silinecekKategori = db.Kategori.Find(id);
            if (silinecekKategori == null)
                return HttpNotFound();
            db.Kategori.Remove(silinecekKategori);
            db.SaveChanges();
            return RedirectToAction("Index", "Yazar");

        }
    }
}