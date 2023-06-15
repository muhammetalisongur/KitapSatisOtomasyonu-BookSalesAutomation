using BookStore.Areas.Admin.ViewModel;
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
    [RouteArea("Admin")]
    public class AuthorController : Controller
    {
        // GET: Admin/Author
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        MessageViewModel messageViewModel = new MessageViewModel();

        [Route("Yazar")]
        [Route("Yazar/Index")]
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;
            var result = categoryManager.GetAll().OrderByDescending(x => x.ID).ToPagedList<Category>(_sayfaNo, 5);
            return View(result);
        }

        [Route("Kategori/YeniKategori")]
        [HttpGet]
        public ActionResult NewCategory()
        {
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
                var name = categoryManager.GetAll();
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
                categoryManager.Add(category);
                messageViewModel.Message = category.CategoryName + " kategorisi başarıyle eklendi...";
            }
            else
            {
                var updateCategory = categoryManager.GetById(category.ID);
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
                    categoryManager.Update(category);
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
            var model = categoryManager.GetById(id);
            if (model == null)
                return HttpNotFound();
            return View("CategoryForm", model);
        }

        [Route("Kategori/Sil/{id}")]
        public ActionResult Delete(int id)
        {
            var deleteCategory = categoryManager.GetById(id);
            if (deleteCategory == null)
                return HttpNotFound();
            categoryManager.Delete(deleteCategory);
            messageViewModel.Status = true;
            messageViewModel.Message = deleteCategory.CategoryName + " isimli kategori silindi...";
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Category");

        }
    }
}