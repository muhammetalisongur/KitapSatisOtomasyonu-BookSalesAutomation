using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Migrations;
using Entities.Concrete;
using Microsoft.Ajax.Utilities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.EnterpriseServices;
using System.EnterpriseServices.Internal;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
        CountryManager countryManager = new CountryManager(new EfCountryDal());
        CityManager cityManager = new CityManager(new EfCityDal());


        [Route("Yazar")]
        [Route("Yazar/Index")]
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;           

            var context = new BookStoreContext();           

            var List = context.Database.SqlQuery<AuthorViewModel>(@"SELECT Authors.*, 
                                                                    Countries.CountryName, 
                                                                    Cities.CityName FROM Authors 
                                                                    LEFT OUTER JOIN Countries ON Authors.AuthorCountryID = Countries.ID 
                                                                    LEFT OUTER JOIN Cities ON Authors.AuthorCityID = Cities.ID").ToPagedList(_sayfaNo, 5);

            var model = new List<Author>();

            foreach (var item in List)
            {
                model.Add( new Author
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

            //var query = (from a in manager.GetAll()
            //             join c in countryManager.GetAll() on a.AuthorCountryID equals c.ID
            //             join ci in cityManager.GetAll() on a.AuthorCityID equals ci.ID
            //             select new Author
            //             {
            //                 ID = a.ID,
            //                 AuthorName = a.AuthorName,
            //                 AuthorSurname = a.AuthorSurname,
            //                 AuthorBiography = a.AuthorBiography,
            //                 AuthorImage = a.AuthorImage,
            //                 AuthorCountryCity = c.CountryName + (ci.CityName == null ? " / Şehir Yok" : " / " + ci.CityName)

            //             }).ToPagedList(_sayfaNo, 5);

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

        [Route("Yazar/YeniYazar")]
        [HttpGet]
        public ActionResult New()
        {
            ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
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
                var oldCountry = updateAuthor.AuthorCountryID;
                var oldCity = updateAuthor.AuthorCityID;
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

                if (author.AuthorFullName == oldAuthorFullName && author.AuthorBiography == oldBiography && author.AuthorCountryID == oldCountry && author.AuthorCityID == oldCity && extension == "")
                {
                    messageViewModel.Status = false;
                    messageViewModel.LinkText = "Yazar Listesi";
                    messageViewModel.Url = "/Admin/Yazar";
                    messageViewModel.Message = "Herhangi bir değişiklik yapılmadı...";

                    ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
                    GetCity(author.AuthorCountryID);
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
            ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
            GetCity(model.AuthorCountryID);
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
}