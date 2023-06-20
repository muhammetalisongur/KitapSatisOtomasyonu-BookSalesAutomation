using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.Ajax.Utilities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Profile;

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
                if (Path.GetFileName(Request.Files[0].FileName).Length > 0)
                {
                    var extension = Path.GetExtension(Request.Files[0].FileName);
                    var newFileName = author.AuthorName + "-" + author.AuthorSurname + extension;
                    var path = "~/Areas/Admin/Images/Author/" + newFileName;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    author.AuthorImage = "/Areas/Admin/Images/Author/" + newFileName;

                    manager.Add(author);
                    messageViewModel.Message = author.AuthorFullName + " yazarı başarıyle eklendi...";
                }
                else
                {
                    messageViewModel.Status = false;
                    messageViewModel.Message = "Yazar resmi boş geçilemez!";
                    TempData["message"] = messageViewModel;
                    return View("AuthorForm", new Author());
                }
            }
            else
            {
                var updateAuthor = manager.GetById(author.ID);
                if (updateAuthor == null)
                {
                    return HttpNotFound();
                }

                var oldAuthorFullName = updateAuthor.AuthorFullName;
                var oldBiography = updateAuthor.AuthorBiography;
                var oldCountryCity = updateAuthor.AuthorCountryCity;

                string oldImage = updateAuthor.AuthorImage;


                var fileName = Path.GetFileName(Request.Files[0].FileName);
                var path = "~/Areas/Admin/Images/Author/" + fileName;
                ViewBag.AuthorImage = path;
                if (Path.GetFileName(Request.Files[0].FileName) != "")
                {
                    string fullPath = Request.MapPath("~" + oldImage);
                    if (System.IO.File.Exists(fullPath))
                    {
                        System.IO.File.Delete(fullPath);
                    }

                    Request.Files[0].SaveAs(Server.MapPath(path));
                    author.AuthorImage = "/Areas/Admin/Images/Author/" + fileName;

                }

                if (author.AuthorFullName == oldAuthorFullName && author.AuthorBiography == oldBiography && author.AuthorCountryCity == oldCountryCity && path == "~/Areas/Admin/Images/Author/")
                {
                    messageViewModel.Status = false;
                    messageViewModel.LinkText = "Yazar Listesi";
                    messageViewModel.Url = "/Admin/Yazar";
                    messageViewModel.Message = "Herhangi bir değişiklik yapılmadı...";
                    TempData["message"] = messageViewModel;
                    return View("AuthorForm", new Author());

                }
                else
                {
                    if (path == "~/Areas/Admin/Images/Author/")
                        author.AuthorImage = oldImage;
                    manager.Update(author);
                    messageViewModel.Status = true;
                    messageViewModel.Message = "Bilgiler başarıyla güncellendi...";
                    TempData["message"] = messageViewModel;

                }
            }

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
            messageViewModel.Message = deleteAuthor.AuthorFullName + " isimli yazar silindi...";
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Author");

        }

    }
}