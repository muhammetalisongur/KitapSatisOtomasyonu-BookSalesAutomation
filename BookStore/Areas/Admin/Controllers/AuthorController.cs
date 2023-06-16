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
        AuthorManager manager = new AuthorManager(new EfAuthorDal());
        MessageViewModel messageViewModel = new MessageViewModel();

        [Route("Yazar")]
        [Route("Yazar/Index")]
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;
            var result = manager.GetAll().OrderByDescending(x => x.ID).ToPagedList<Author>(_sayfaNo, 5);
            return View(result);
        }

        [Route("Yazar/YeniYazar")]
        [HttpGet]
        public ActionResult New()
        {
            return View("AuthorForm", new Author());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View("AuthorForm");
            }


            if (author.ID == 0)
            {
                var name = manager.GetAll();
                foreach (var item in name)
                {
                    if (author.AuthorFullName == item.AuthorFullName)
                    {
                        messageViewModel.Status = false;
                        messageViewModel.LinkText = "Yazar Listesi";
                        messageViewModel.Url = "/Admin/Yazar";
                        messageViewModel.Message = "Bu yazar zaten mevcut...";
                        TempData["message"] = messageViewModel;

                        return View("AuthorForm");
                    }
                }
                manager.Add(author);
                messageViewModel.Message = author.AuthorFullName + " yazarı başarıyle eklendi...";
            }
            else
            {
                var updateAuthor = manager.GetById(author.ID);
                if (updateAuthor == null)
                {
                    return HttpNotFound();
                }
                var oldAuthorFullName = updateAuthor.AuthorFullName;

                if (author.AuthorFullName == oldAuthorFullName)
                {
                    messageViewModel.Status = false;
                    messageViewModel.LinkText = "Yazar Listesi";
                    messageViewModel.Url = "/Admin/Yazar";
                    messageViewModel.Message = "Herhangi bir değişiklik yapılmadı...";
                    TempData["message"] = messageViewModel;
                    return View("AuthorForm");

                }
                else
                {

                    updateAuthor.AuthorName = author.AuthorName;
                    updateAuthor.AuthorSurname = author.AuthorSurname;
                    manager.Update(author);
                    messageViewModel.Message = oldAuthorFullName + " => " + author.AuthorFullName + " olarak başarıyla güncellendi...";

                }
            }

            messageViewModel.Status = true;
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Author");
        }

        [Route("Yazar/Guncelle/{id}")]
        public ActionResult Update(int id)
        {
            var model = manager.GetById(id);
            if (model == null)
                return HttpNotFound();
            return View("AuthorForm", model);
        }

        [Route("Yazar/Sil/{id}")]
        public ActionResult Delete(int id)
        {
            var deleteAuthor = manager.GetById(id);
            if (deleteAuthor == null)
                return HttpNotFound();
            manager.Delete(deleteAuthor);
            messageViewModel.Status = true;
            messageViewModel.Message = deleteAuthor.AuthorFullName + " isimli kategori silindi...";
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Author");

        }
    }
}