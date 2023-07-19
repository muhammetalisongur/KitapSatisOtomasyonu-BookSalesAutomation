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
    [RouteArea("Admin")]
    public class PublisherController : Controller
    {

        // GET: Admin/Publisher
        PublisherManager manager = new PublisherManager(new EfPublisherDal());
        MessageViewModel messageViewModel = new MessageViewModel();
        CountryManager countryManager = new CountryManager(new EfCountryDal());
        CityManager cityManager = new CityManager(new EfCityDal());


        [Route("Yayinevi")]
        [Route("Yayinevi/Index")]
        public ActionResult Index(int? SayfaNo)
        {

            if (User.IsInRole("Satış Temsilcisi"))
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "login");
            }


            int _sayfaNo = SayfaNo ?? 1;


            var context = new BookStoreContext();

            var List = context.Database.SqlQuery<PublisherViewModel>(@"SELECT Publishers.*, 
                                                                       Countries.CountryName, 
                                                                       Cities.CityName FROM Publishers 
                                                                       LEFT OUTER JOIN Countries ON Publishers.PublisherCountryID = Countries.ID 
                                                                       LEFT OUTER JOIN Cities ON Publishers.PublisherCityID = Cities.ID");


            var model = new List<Publisher>();

            foreach (var item in List)
            {
                model.Add(new Publisher
                {
                    ID = item.ID,
                    PublisherName = item.PublisherName,
                    PublisherDescription = item.PublisherDescription,
                    PublisherEmail = item.PublisherEmail,
                    PublisherImage = item.PublisherImage,
                    PublisherAddress = item.PublisherAddress,
                    CountryName = item.CountryName,
                    CityName = item.CityName,

                });
            }

            //var query = (from p in manager.GetAll()
            //             join c in countryManager.GetAll() on p.ID equals c.ID
            //             join ci in cityManager.GetAll() on p.ID equals ci.ID
            //             select new Publisher
            //             {
            //                 PublisherName = p.PublisherName,
            //                 PublisherDescription = p.PublisherDescription,
            //                 PublisherEmail = p.PublisherEmail,
            //                 PublisherImage = p.PublisherImage,
            //                 PublisherAddress = p.PublisherAddress,
            //                 PublisherCountry = p.PublisherCountry,
            //                 PublisherCity = p.PublisherCity,
            //                 PublisherCountryCity = c.CountryName + " / " + ci.CityName,

            //             }).OrderByDescending(x => x.ID).ToPagedList(_sayfaNo, 5);

            //var result = manager.GetAll().OrderByDescending(x => x.ID).ToPagedList<Publisher>(_sayfaNo, 5);

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
            if (result.Count == 0) { ViewBag.CityList = null; }
            else { ViewBag.CityList = new SelectList(result, "ID", "CityName"); }
            return PartialView("DisplayCity");
        }

        [Route("Yayinevi/YeniYayinevi")]
        [HttpGet]
        public ActionResult New()
        {
            ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
            return View("PublisherForm", new Publisher());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return View("PublisherForm");
            }


            if (publisher.ID == 0)
            {
                var name = manager.GetAll();
                foreach (var item in name)
                {
                    if (publisher.PublisherName == item.PublisherName)
                    {
                        messageViewModel.Status = false;
                        messageViewModel.LinkText = "YayınEvi Listesi";
                        messageViewModel.Url = "/Admin/Yayinevi";
                        messageViewModel.Message = "Bu yayınevi zaten mevcut...";
                        TempData["message"] = messageViewModel;


                        ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
                        GetCity(publisher.PublisherCountryID);
                        return View("PublisherForm");
                    }

                }
                if (Path.GetFileName(Request.Files[0].FileName).Length > 0)
                {
                    var extension = Path.GetExtension(Request.Files[0].FileName);
                    var newFileName = publisher.PublisherName + "-" + DateTime.Now.ToString("dd-MM-yyyy-H-mm") + extension;
                    var path = "~/Areas/Admin/Images/Publisher/" + newFileName;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    publisher.PublisherImage = "/Areas/Admin/Images/Publisher/" + newFileName;

                    manager.Add(publisher);
                    messageViewModel.Message = publisher.PublisherName + " yayinevi başarıyle eklendi...";
                }
                else
                {
                    messageViewModel.Status = false;
                    messageViewModel.Message = "Yazar resmi boş geçilemez!";
                    TempData["message"] = messageViewModel;
                    ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
                    GetCity(publisher.PublisherCountryID);
                    return View("PublisherForm", new Publisher());
                }
            }
            else
            {
                var updatePublisher = manager.GetById(publisher.ID);
                if (updatePublisher == null)
                {
                    return HttpNotFound();
                }

                var oldName = updatePublisher.PublisherName;
                var oldDesc = updatePublisher.PublisherDescription;
                var oldEmail = updatePublisher.PublisherEmail;
                var oldCountry = updatePublisher.PublisherCountryID;
                var oldCity = updatePublisher.PublisherCityID;

                string oldImage = updatePublisher.PublisherImage;


                var extension = Path.GetExtension(Request.Files[0].FileName);
                var newFileName = publisher.PublisherName + "-" + "Update" + "-" + DateTime.Now.ToString("dd-MM-yyyy-H-mm") + extension;
                var path = "~/Areas/Admin/Images/Publisher/" + newFileName;
                if (Path.GetFileName(Request.Files[0].FileName) != "")
                {
                    string fullPath = Request.MapPath("~" + oldImage);
                    if (System.IO.File.Exists(fullPath))
                    {
                        System.IO.File.Delete(fullPath);
                    }

                    Request.Files[0].SaveAs(Server.MapPath(path));
                    publisher.PublisherImage = "/Areas/Admin/Images/Publisher/" + newFileName;

                }

                if (publisher.PublisherName == oldName && publisher.PublisherDescription == oldDesc && publisher.PublisherEmail == oldEmail && publisher.PublisherCountryID
                    == oldCountry && publisher.PublisherCityID
                    == oldCity && extension == "")
                {
                    messageViewModel.Status = false;
                    messageViewModel.LinkText = "YayınEvi Listesi";
                    messageViewModel.Url = "/Admin/Yayinevi";
                    messageViewModel.Message = "Herhangi bir değişiklik yapılmadı...";
                    ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
                    GetCity(publisher.PublisherCountryID);
                    TempData["message"] = messageViewModel;
                    return View("PublisherForm", new Publisher());

                }
                else
                {
                    if (extension == "")
                        publisher.PublisherImage = oldImage;
                    manager.Update(publisher);
                    messageViewModel.Status = true;
                    messageViewModel.Message = "Bilgiler başarıyla güncellendi...";
                    TempData["message"] = messageViewModel;

                }
            }

            return RedirectToAction("Index", "Publisher");
        }

        [Route("Yayinevi/Guncelle/{id}")]
        public ActionResult Update(int id)
        {
            var model = manager.GetById(id);
            if (model == null)
                return HttpNotFound();
            ViewBag.Country = new SelectList(GetCountries(), "ID", "CountryName");
            GetCity(model.PublisherCountryID);
            return View("PublisherForm", model);
        }

        [Route("Yayinevi/Sil/{id}")]
        public ActionResult Delete(int id)
        {
            var deletePublisher = manager.GetById(id);
            if (deletePublisher == null)
                return HttpNotFound();

            string oldImage = deletePublisher.PublisherImage;
            string fullPath = Request.MapPath("~" + oldImage);
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }

            manager.Delete(deletePublisher);
            messageViewModel.Status = true;
            messageViewModel.Message = deletePublisher.PublisherName + " isimli yayinevi silindi...";
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Publisher");

        }

    }
}