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
        Context db = new Context();

        public ActionResult Index(int? SayfaNo)
        {

            int _sayfaNo = SayfaNo ?? 1;
            var listele = db.Kategoriler.OrderByDescending(m => m.KategoriId).ToPagedList<Kategoriler>(_sayfaNo, 10);
            return View(listele);
        }

        [HttpGet]
        public ActionResult Yeni()
        {
            return View("KategoriForm", new Kategoriler());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Kategoriler kategori)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriForm");
            }

            MesajViewModel mesajViewModel = new MesajViewModel();

            if (kategori.KategoriId == 0)
            {
               var kategoriAd = db.Kategoriler.ToList();
                foreach (var item in kategoriAd)
                {
                    if (kategori.Ad == item.Ad)
                    {
                        mesajViewModel.Status = false;
                        mesajViewModel.LinkText = "Kategori Listesi";
                        mesajViewModel.Url = "/Admin/Kategori";
                        mesajViewModel.Mesaj = "Bu kategori zaten mevcut...";
                        TempData["mesaj"] = mesajViewModel;

                        return View("KategoriForm");
                    }
                }
                db.Kategoriler.Add(kategori);
                mesajViewModel.Mesaj = kategori.Ad + " başarıyle eklendi...";
            }
            else
            {
                var guncellenecekKategori = db.Kategoriler.Find(kategori.KategoriId);
                if (guncellenecekKategori == null)
                {
                    return HttpNotFound();
                }
                var eskiKategoriAd = guncellenecekKategori.Ad;

                if (kategori.Ad == eskiKategoriAd)
                {
                    mesajViewModel.Status = false;
                    mesajViewModel.LinkText = "Kategori Listesi";
                    mesajViewModel.Url = "/Admin/Kategori";
                    mesajViewModel.Mesaj = "Herhangi bir değişiklik yapılmadı...";
                    TempData["mesaj"] = mesajViewModel;
                    return View("KategoriForm");

                }
                else
                {

                    guncellenecekKategori.Ad = kategori.Ad;
                    mesajViewModel.Mesaj = eskiKategoriAd + " => " + kategori.Ad + " olarak başarıyla güncellendi...";

                }
            }
            db.SaveChanges();
            mesajViewModel.Status = true;
            TempData["mesaj"] = mesajViewModel;
            return RedirectToAction("Index", "Kategori");
        }

        public ActionResult Guncelle(int id)
        {
            var model = db.Kategoriler.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("KategoriForm", model);
        }

        public ActionResult Sil(int id)
        {
            var silinecekKategori = db.Kategoriler.Find(id);
            if (silinecekKategori == null)
                return HttpNotFound();
            db.Kategoriler.Remove(silinecekKategori);
            db.SaveChanges();
            return RedirectToAction("Index", "Kategori");

        }

    }
}