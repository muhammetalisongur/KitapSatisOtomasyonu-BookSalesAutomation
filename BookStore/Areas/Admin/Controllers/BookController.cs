using System.Collections.Generic;
using System.Linq;
using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using PagedList;
using System.Web.Mvc;
using DataAccess.Concrete;
using Entities.Concrete;

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


            var context = new BookStoreContext();

            var List = context.Database.SqlQuery<BookViewModel>(
                @"SELECT Books.ID, Books.BookName, Books.BookDescription, Books.BookImage, Books.BookPublisherID, Books.BookAuthorID, Books.BookCategoryID, Books.BookTranslatorID, Books.BookPage, Books.BookPrice, Books.BookISBN, 
                         Books.BookStock, Books.BookStatus, Categories.CategoryName, BookTranslators.TranslatorName, BookTranslators.TranslatorSurname, Authors.AuthorName, Authors.AuthorSurname, Publishers.PublisherName
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
                    CategoryName = bookViewModel.CategoryName

                });
            }

            return View(model.ToPagedList(_sayfaNo, 5));
        }
    }
}