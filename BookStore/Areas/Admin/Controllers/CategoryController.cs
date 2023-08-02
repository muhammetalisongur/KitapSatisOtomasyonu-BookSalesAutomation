using BookStore.Areas.Admin.ViewModel;
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
using System.Web.Security;

namespace BookStore.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [Authorize]
    public class CategoryController : Controller
    {
        CategoryManager manager = new CategoryManager(new EfCategoryDal());
        MessageViewModel messageViewModel = new MessageViewModel();

        // GET: Admin/Category
        [Route("Kategori")]
        [Route("Kategori/Index")]
        public ActionResult Index(int? SayfaNo)
        {
            //Satış Temsilcisi değilse girsin
            if (User.IsInRole("Satış Temsilcisi"))
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "Login");
            }


            if (User.IsInRole("Satış Temsilcisi"))
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "login");
            }


            int _sayfaNo = SayfaNo ?? 1;
            var result = manager.GetAll().OrderByDescending(x => x.ID).ToPagedList<Category>(_sayfaNo, 5);
            return View(result);
        }

        [Route("Kategori/YeniKategori")]
        [HttpGet]
        public ActionResult NewCategory()
        {
            //Satış Temsilcisi değilse girsin
            if (User.IsInRole("Satış Temsilcisi"))
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "Login");
            }

            return View("CategoryForm", new Category());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryForm");
            }


            if (category.ID == 0)
            {
                var name = manager.GetAll();
                foreach (var item in name)
                {
                    if (category.CategoryName == item.CategoryName)
                    {
                        messageViewModel.Status = false;
                        messageViewModel.LinkText = "Kategori Listesi";
                        messageViewModel.Url = "/Admin/Kategori";
                        messageViewModel.Message = "Bu kategori zaten mevcut...";
                        TempData["message"] = messageViewModel;

                        return View("CategoryForm");
                    }
                }
                manager.Add(category);
                messageViewModel.Message = category.CategoryName + " kategorisi başarıyle eklendi...";
            }
            else
            {
                var updateCategory = manager.GetById(category.ID);
                if (updateCategory == null)
                {
                    return HttpNotFound();
                }
                var oldCategoryName = updateCategory.CategoryName;

                if (category.CategoryName == oldCategoryName)
                {
                    messageViewModel.Status = false;
                    messageViewModel.LinkText = "Kategori Listesi";
                    messageViewModel.Url = "/Admin/Kategori";
                    messageViewModel.Message = "Herhangi bir değişiklik yapılmadı...";
                    TempData["message"] = messageViewModel;
                    return View("CategoryForm");

                }
                else
                {

                    updateCategory.CategoryName = category.CategoryName;
                    manager.Update(category);
                    messageViewModel.Message = oldCategoryName + " => " + category.CategoryName + " olarak başarıyla güncellendi...";

                }
            }

            messageViewModel.Status = true;
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Category");
        }

        [Route("Kategori/Guncelle/{id}")]
        public ActionResult Update(int id)
        {
            //Satış Temsilcisi değilse girsin
            if (User.IsInRole("Satış Temsilcisi"))
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "Login");
            }

            var model = manager.GetById(id);
            if (model == null)
                return HttpNotFound();
            return View("CategoryForm", model);
        }

        [Route("Kategori/Sil/{id}")]
        public ActionResult Delete(int id)
        {
            //Satış Temsilcisi değilse girsin
            if (User.IsInRole("Satış Temsilcisi"))
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "Login");
            }

            var deleteCategory = manager.GetById(id);
            if (deleteCategory == null)
                return HttpNotFound();
            manager.Delete(deleteCategory);
            messageViewModel.Status = true;
            messageViewModel.Message = deleteCategory.CategoryName + " isimli kategori silindi...";
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Category");

        }



    }
}