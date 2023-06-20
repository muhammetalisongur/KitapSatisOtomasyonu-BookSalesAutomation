﻿using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
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


        [Route("Yayinevi")]
        [Route("Yayinevi/Index")]
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;
            var result = manager.GetAll().OrderByDescending(x => x.ID).ToPagedList<Publisher>(_sayfaNo, 5);
            return View(result);
        }



        [Route("Yayinevi/YeniYayinevi")]
        [HttpGet]
        public ActionResult New()
        {
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

                        return View("PublisherForm");
                    }

                }
                if (Path.GetFileName(Request.Files[0].FileName).Length > 0)
                {
                    var extension = Path.GetExtension(Request.Files[0].FileName);
                    var newFileName = publisher.PublisherName + extension;
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
                    return View("PublisherForm", new Author());
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
                var oldCountry = updatePublisher.PublisherCountry;

                string oldImage = publisher.PublisherImage;


                var fileName = Path.GetFileName(Request.Files[0].FileName);
                var path = "~/Areas/Admin/Images/Publisher/" + fileName;
                if (Path.GetFileName(Request.Files[0].FileName) != "")
                {
                    string fullPath = Request.MapPath("~" + oldImage);
                    if (System.IO.File.Exists(fullPath))
                    {
                        System.IO.File.Delete(fullPath);
                    }

                    Request.Files[0].SaveAs(Server.MapPath(path));
                    publisher.PublisherImage = "/Areas/Admin/Images/Author/" + fileName;

                }

                if (publisher.PublisherName == oldName && publisher.PublisherDescription == oldDesc && publisher.PublisherEmail == oldEmail && publisher.PublisherCountry
                    == oldCountry && path == "~/Areas/Admin/Images/Publisher/")
                {
                    messageViewModel.Status = false;
                    messageViewModel.LinkText = "YayınEvi Listesi";
                    messageViewModel.Url = "/Admin/Yayinevi";
                    messageViewModel.Message = "Herhangi bir değişiklik yapılmadı...";
                    TempData["message"] = messageViewModel;
                    return View("PublisherForm", new Publisher());

                }
                else
                {
                    if (path == "~/Areas/Admin/Images/Publisher/")
                        publisher.PublisherImage = oldImage;
                    manager.Update(publisher);
                    messageViewModel.Status = true;
                    messageViewModel.Message = "Bilgiler başarıyla güncellendi...";
                    TempData["message"] = messageViewModel;

                }
            }

            return RedirectToAction("Index", "Author");
        }

        [Route("Yayinevi/Guncelle/{id}")]
        public ActionResult Update(int id)
        {
            var model = manager.GetById(id);
            if (model == null)
                return HttpNotFound();
            return View("PublisherForm", model);
        }

        [Route("Yayinevi/Sil/{id}")]
        public ActionResult Delete(int id)
        {
            var deletePublisher = manager.GetById(id);
            if (deletePublisher == null)
                return HttpNotFound();
            manager.Delete(deletePublisher);
            messageViewModel.Status = true;
            messageViewModel.Message = deletePublisher.PublisherName + " isimli yayinevi silindi...";
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Publisher");

        }

    }
}