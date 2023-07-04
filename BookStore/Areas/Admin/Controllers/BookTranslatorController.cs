using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using PagedList;
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
        CountryManager countryManager = new CountryManager(new EfCountryDal());
        CityManager cityManager = new CityManager(new EfCityDal());


        [Route("kitapcevirmen")]
        [Route("Kitapcevirmen/Index")]
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;

            var context = new BookStoreContext();

            var List = context.Database.SqlQuery<AuthorViewModel>(@"SELECT Authors.*, 
                                                                    Countries.CountryName, 
                                                                    Cities.CityName FROM Authors 
                                                                    LEFT OUTER JOIN Countries ON Authors.AuthorCountryID = Countries.ID 
                                                                    LEFT OUTER JOIN Cities ON Authors.AuthorCityID = Cities.ID");

            var model = new List<Author>();

            foreach (var item in List)
            {
                model.Add(new Author
                {
                    ID = item.ID,
                    AuthorName = item.AuthorName,
                    AuthorSurname = item.AuthorSurname,
                    AuthorBiography = item.AuthorBiography,
                    AuthorImage = item.AuthorImage,
                    AuthorCountryID = item.AuthorCountryID,
                    AuthorCityID = item.AuthorCityID,
                    CountryName = item.CountryName,
                    CityName = item.CityName,
                });
            }

            return View(model.ToPagedList(_sayfaNo, 5));
        }


        public List<Country> GetCountries()
        {
            // Country-City
            CountryManager countryManager = new CountryManager(new EfCountryDal());
            List<Country> result = countryManager.GetAll();
            return result;
        }

        public ActionResult GetCity(int id)
        {
            CityManager cityManager = new CityManager(new EfCityDal());
            var result = cityManager.GetAll().Where(x => x.CountryID == id).OrderBy(x => x.CityName).ToList();
            if (result.Count == 0)
            {
                ViewBag.CityList = null;
            }
            else
            {
                ViewBag.CityList = new SelectList(result, "ID", "CityName");
            }
            return PartialView("DisplayCity");
        }

        [Route("kitapcevirmen/Yenikitapcevirmen")]
        [HttpGet]
        public ActionResult New()
        {
            ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
            return View("BookTranslatorForm", new BookTranslator());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(BookTranslator bookTranslator)
        {
            if (!ModelState.IsValid)
            {
                return View("BookTranslatorForm");
            }

            if (bookTranslator.ID == 0)
            {
                var name = manager.GetAll();
                foreach (var item in name)
                {
                    if (bookTranslator.TranslatorFullName == item.TranslatorFullName)
                    {
                        messageViewModel.Status = false;
                        messageViewModel.LinkText = "Kitap Çevirmen Listesi";
                        messageViewModel.Url = "/Admin/kitapçevirmen";
                        messageViewModel.Message = "Bu çevirmen zaten mevcut...";
                        TempData["message"] = messageViewModel;

                        return View("BookTranslatorForm");
                    }

                }

                if (Path.GetFileName(Request.Files[0].FileName).Length > 0)
                {
                    var extension = Path.GetExtension(Request.Files[0].FileName);
                    var newFileName = bookTranslator.TranslatorFullName + "-" + DateTime.Now.ToString("dd-MM-yyyy-H-mm") + extension;
                    var path = "~/Areas/Admin/Images/BookTranslator/" + newFileName;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    bookTranslator.TranslatorImage = "/Areas/Admin/Images/BookTranslator/" + newFileName;

                    manager.Add(bookTranslator);
                    messageViewModel.Message = bookTranslator.TranslatorFullName + " çevirmen başarıyle eklendi...";
                }
                else
                {
                    messageViewModel.Status = false;
                    messageViewModel.Message = "Çevirmen resmi boş geçilemez!";
                    TempData["message"] = messageViewModel;
                    return View("BookTranslatorForm", new BookTranslator());
                }
            }
            else
            {
                var updateBookTranslator = manager.GetById(bookTranslator.ID);

                if (updateBookTranslator == null)
                {
                    return HttpNotFound();
                }

                var oldAuthorFullName = updateBookTranslator.TranslatorFullName;
                var oldBiography = updateBookTranslator.TranslatorBiography;
                var oldCountry = updateBookTranslator.AuthorCountryID;
                var oldCity = updateBookTranslator.AuthorCityID;
                string oldImage = updateBookTranslator.AuthorImage;

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

                if (author.AuthorFullName == oldAuthorFullName && author.AuthorBiography == oldBiography && author.AuthorCountryID == oldCountry && author.AuthorCityID == oldCity && extension == "")
                {
                    messageViewModel.Status = false;
                    messageViewModel.LinkText = "Yazar Listesi";
                    messageViewModel.Url = "/Admin/Yazar";
                    messageViewModel.Message = "Herhangi bir değişiklik yapılmadı...";

                    ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
                    GetCity(author.AuthorCountryID);
                    TempData["message"] = messageViewModel;
                    return View("BookTranslatorForm", new Author());

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
            ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
            GetCity(model.AuthorCountryID);
            return View("BookTranslatorForm", model);
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