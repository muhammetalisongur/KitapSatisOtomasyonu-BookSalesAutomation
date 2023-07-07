using System.Collections.Generic;
using System.Linq;
using BookStore.Areas.Admin.ViewModel;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using PagedList;
using System.Web.Mvc;
using DataAccess.Concrete;
using Entities.Concrete;
using System.IO;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BookStore.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class BookController : Controller
    {
        // GET: Admin/Book
        BookManager manager = new BookManager(new EfBookDal());
        MessageViewModel messageViewModel = new MessageViewModel();

        CategoryManager category = new CategoryManager(new EfCategoryDal());
        AuthorManager author = new AuthorManager(new EfAuthorDal());
        PublisherManager publisher = new PublisherManager(new EfPublisherDal());
        BookTranslatorManager translator = new BookTranslatorManager(new EfBookTranslatorDal());




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


        [Route("Kitap/YeniKitap")]
        [HttpGet]
        public ActionResult New()
        {

            // Select List Item Category
            var categoryList = category.GetAll();

            List<SelectListItem> categoryItems = (from i in categoryList
                                                  select new SelectListItem
                                                  {
                                                      Text = i.CategoryName,
                                                      Value = i.ID.ToString()
                                                  }).ToList();
            ViewBag.BookCategory = categoryItems;

            // Select List Item Author
            var authorList = author.GetAll();
            List<SelectListItem> authorItems = (from i in authorList
                                                select new SelectListItem
                                                {
                                                    Text = i.AuthorFullName,
                                                    Value = i.ID.ToString()
                                                }).ToList();
            ViewBag.BookAuthor = authorItems;

            // Select List Item Publisher
            var publisherList = publisher.GetAll();
            List<SelectListItem> publisherItems = (from i in publisherList
                                                   select new SelectListItem
                                                   {
                                                       Text = i.PublisherName,
                                                       Value = i.ID.ToString()
                                                   }).ToList();
            ViewBag.BookPublisher = publisherItems;

            // Select List Item Translator
            var translatorList = translator.GetAll();
            List<SelectListItem> translatorItems = (from i in translatorList
                                                    select new SelectListItem
                                                    {
                                                        Text = i.TranslatorName,
                                                        Value = i.ID.ToString()
                                                    }).ToList();

            ViewBag.BookTranslator = translatorItems;


            return View("BookForm", new Book());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Book book)
        {

            book.BookISBN = DateTime.Now.ToString("ddMMyyyyHHmmss");
            book.BookStatus = true;

            if (!ModelState.IsValid)
            {
                return View("BookForm");
            }

            // Kitap ekleme
            if (book.ID == 0)
            {
                var kontroList = manager.GetAll();
                foreach (var item in kontroList)
                {
                    if (book.BookName == item.BookName)
                    {
                        messageViewModel.Status = false;
                        messageViewModel.LinkText = "Kitap Listesi";
                        messageViewModel.Url = "/Admin/Kitap";
                        messageViewModel.Message = "Bu kitap zaten mevcut...";
                        TempData["message"] = messageViewModel;
                        return View("BookForm");
                    }

                }

                if (Path.GetFileName(Request.Files[0].FileName).Length > 0)
                {
                    var extension = Path.GetExtension(Request.Files[0].FileName);
                    var newFileName = book.BookName + "-" + DateTime.Now.ToString("dd-MM-yyyy-H-mm") + extension;
                    var path = "~/Areas/Admin/Images/Book/" + newFileName;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    book.BookImage = "/Areas/Admin/Images/Book/" + newFileName;

                    manager.Add(book);
                    messageViewModel.Message = book.BookName + " kitabı başarıyle eklendi...";
                }
                else
                {
                    messageViewModel.Status = false;
                    messageViewModel.Message = "Kitap resmi boş geçilemez!";
                    TempData["message"] = messageViewModel;

                    return View("BookForm", new Book());
                }
            }

            // Kitap guncelleme
            /*
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
            */
            return RedirectToAction("Index", "Book");
        }

        /*
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
        */

    }
}