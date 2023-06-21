using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Areas.Admin.Controllers
{


    /*

    [RouteArea("Admin")]
    public class BookTranslatorController : Controller
    {
        // GET: Admin/BookTranslator
        BookTranslatorManager manager = new BookTranslatorManager(new EfBookTranslatorDal());
        MessageViewModel messageViewModel = new MessageViewModel();


        [Route("Yazar")]
        [Route("Yazar/Index")]
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;
            var result = manager.GetAll().OrderByDescending(x => x.ID).ToPagedList<BookTranslator>(_sayfaNo, 5);
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
                    var newFileName = author.AuthorFullName + "-" + DateTime.Now.ToString("dd-MM-yyyy-H-mm") + extension;
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


                var extension = Path.GetExtension(Request.Files[0].FileName);
                var newFileName = author.AuthorFullName + "-" + "Update" + "-" + DateTime.Now.ToString("dd-MM-yyyy-H-mm") + extension;
                var path = "~/Areas/Admin/Images/Author/" + newFileName;

                if (Path.GetFileName(Request.Files[0].FileName) != "")
                {
                    string fullPath = Request.MapPath("~" + oldImage);
                    if (System.IO.File.Exists(fullPath))
                    {
                        System.IO.File.Delete(fullPath);
                    }

                    Request.Files[0].SaveAs(Server.MapPath(path));
                    author.AuthorImage = "/Areas/Admin/Images/Author/" + newFileName;

                }

                if (author.AuthorFullName == oldAuthorFullName && author.AuthorBiography == oldBiography && author.AuthorCountryCity == oldCountryCity && extension == "")
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
                    if (extension == "")
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
            string oldImage = deleteAuthor.AuthorImage;
            string fullPath = Request.MapPath("~" + oldImage);
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }

            manager.Delete(deleteAuthor);
            messageViewModel.Status = true;
            messageViewModel.Message = deleteAuthor.AuthorFullName + " isimli yazar silindi...";
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Author");

        }
    }


    */
}