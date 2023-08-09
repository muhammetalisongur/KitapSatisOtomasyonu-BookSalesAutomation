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

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        BookManager bookManager = new BookManager(new EfBookDal());

        // GET: Home
        [Route("Anasayfa")]
        [Route("")]
        [Route("Anasayfa/Index")]
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;

            var context = new BookStoreContext();

            var List = context.Database.SqlQuery<BookViewModel>(
                @"SELECT Books.*, Categories.CategoryName, BookTranslators.TranslatorName, BookTranslators.TranslatorSurname, Authors.AuthorName, Authors.AuthorSurname, Publishers.PublisherName
                           FROM            BookTranslators RIGHT OUTER JOIN
                         Books ON BookTranslators.ID = Books.BookTranslatorID LEFT OUTER JOIN
                         Authors ON Books.BookAuthorID = Authors.ID LEFT OUTER JOIN
                         Publishers ON Books.BookPublisherID = Publishers.ID LEFT OUTER JOIN
                         Categories ON Books.BookCategoryID = Categories.ID").ToList();



            var model = new List<Book>();



            foreach (var bookViewModel in List)
            {
                model.Add(new Book
                {
                    ID = bookViewModel.ID,
                    BookName = bookViewModel.BookName,
                    BookDescription = bookViewModel.BookDescription,
                    BookImage = bookViewModel.BookImage,
                    BookPublisherID = bookViewModel.BookPublisherID,
                    BookAuthorID = bookViewModel.BookAuthorID,
                    BookCategoryID = bookViewModel.BookCategoryID,
                    BookTranslatorID = bookViewModel.BookTranslatorID,
                    BookPage = bookViewModel.BookPage,
                    BookPrice = bookViewModel.BookPrice,
                    BookISBN = bookViewModel.BookISBN,
                    BookStock = bookViewModel.BookStock,
                    BookStatus = bookViewModel.BookStatus,
                    TranslatorFullName = bookViewModel.TranslatorName + " " + bookViewModel.TranslatorSurname,
                    AuthorFullName = bookViewModel.AuthorName + " " + bookViewModel.AuthorSurname,
                    PublisherName = bookViewModel.PublisherName,
                    CategoryName = bookViewModel.CategoryName,
                    BookSale = bookViewModel.BookSale

                });
            }

            return View(model.ToPagedList(_sayfaNo, 8));
        }


        public ActionResult BookDetail(int id)
        {
            var model = bookManager.GetById(id);

            return View(model);
        }

        [Route("Iletisim")]
        public ActionResult Contact()
        {
            return View();
        }


        [Route("Anasayfa/KategoriEnIyiSatis")]
        public PartialViewResult BookCategoryBestSalePartialView(int id)
        {
            var model = bookManager.GetAll().Where(x => x.BookCategoryID == id).OrderByDescending(x => x.BookSale).Take(3).ToList();

            return PartialView(model);
        }

    }
}