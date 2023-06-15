using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        // GET: Admin/Category
        public ActionResult Index(int? SayfaNo)
        {
            int id = SayfaNo ?? 1; 
            var result = categoryManager.GetAll().OrderByDescending(x => x.ID).ToPagedList<Category>(id, 5);
            return View(result);
        }


        /*

        [HttpGet]
        public ActionResult Yeni()
        {
            return View("KategoriForm", new Category());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Kaydet(Category kategori)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriForm");
            }

            MessageViewModel mesajViewModel = new MessageViewModel();

            if (kategori.Id == 0)
            {
               var kategoriAd = c.Categories.ToList();
                foreach (var item in kategoriAd)
                {
                    if (kategori.KategoriAdi == item.KategoriAdi)
                    {
                        mesajViewModel.Status = false;
                        mesajViewModel.LinkText = "Kategori Listesi";
                        mesajViewModel.Url = "/Admin/Kategori";
                        mesajViewModel.Mesaj = "Bu kategori zaten mevcut...";
                        TempData["mesaj"] = mesajViewModel;

                        return View("KategoriForm");
                    }
                }
                c.Categories.Add(kategori);
                mesajViewModel.Mesaj = kategori.KategoriAdi + " başarıyle eklendi...";
            }
            else
            {
                var guncellenecekKategori = c.Categories.Find(kategori.Id);
                if (guncellenecekKategori == null)
                {
                    return HttpNotFound();
                }
                var eskiKategoriAd = guncellenecekKategori.KategoriAdi;

                if (kategori.KategoriAdi == eskiKategoriAd)
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

                    guncellenecekKategori.KategoriAdi = kategori.KategoriAdi;
                    mesajViewModel.Mesaj = eskiKategoriAd + " => " + kategori.KategoriAdi + " olarak başarıyla güncellendi...";

                }
            }
            c.SaveChanges();
            mesajViewModel.Status = true;
            TempData["mesaj"] = mesajViewModel;
            return RedirectToAction("Index", "Kategori");
        }

        public ActionResult Guncelle(int id)
        {
            var model = c.Categories.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("KategoriForm", model);
        }

        public ActionResult Sil(int id)
        {
            var silinecekKategori = c.Categories.Find(id);
            if (silinecekKategori == null)
                return HttpNotFound();
            c.Categories.Remove(silinecekKategori);
            c.SaveChanges();
            return RedirectToAction("Index", "Kategori");

        }


        */

    }
}