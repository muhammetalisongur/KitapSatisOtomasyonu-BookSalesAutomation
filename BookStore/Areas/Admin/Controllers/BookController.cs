using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
using DataAccess.Concrete;
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
    public class BookController : Controller
    {
        // GET: Admin/Book
        BookManager manager = new BookManager(new EfBookDal());
        MessageViewModel messageViewModel = new MessageViewModel();



        [Route("Kitap")]
        [Route("Kitap/Index")]
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;

            var model = new List<Author>();

          

            return View(model.ToPagedList(_sayfaNo, 5));
        }
    }
}