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
    [Authorize]
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
            //editor değilse girsin
            //if (User.IsInRole("Editör"))
            //{
            //    messageViewModel.Status = false;
            //    messageViewModel.Message = "Yetkisiz işlem...";
            //    TempData["message"] = messageViewModel;
            //    return RedirectToAction("Index", "Login");
            //}

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
            //editor değilse girsin
            if (User.IsInRole("Editör"))
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "Login");
            }

            ViewBagResult();

            return View("BookForm", new Book());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Book book)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View("BookForm");
            //}

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


                    book.BookISBN = ISBNGenerator.GenerateISBN();
                    book.BookStatus = true;
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

            else
            {
                var update = manager.GetById(book.ID);

                if (update == null)
                {
                    return HttpNotFound();
                }

                var oldName = update.BookName;
                var oldDescription = update.BookDescription;
                var oldPublisher = update.BookPublisherID;
                var oldAuthor = update.BookAuthorID;
                var oldCategory = update.BookCategoryID;
                var oldTranslator = update.BookTranslatorID;
                var oldPage = update.BookPage;
                var oldPrice = update.BookPrice;
                var oldStock = update.BookStock;
                var oldISBN = update.BookISBN;
                string oldImage = update.BookImage;

                var extension = Path.GetExtension(Request.Files[0].FileName);
                var newFileName = book.BookName + "-" + "Update" + "-" + DateTime.Now.ToString("dd-MM-yyyy-H-mm") + extension;
                var path = "~/Areas/Admin/Images/Book/" + newFileName;

                if (Path.GetFileName(Request.Files[0].FileName) != "")
                {
                    if (!oldImage.Contains("https"))
                    {
                        string fullPath = Request.MapPath("~" + oldImage);
                        if (System.IO.File.Exists(fullPath))
                        {
                            System.IO.File.Delete(fullPath);
                        }
                    }

                    Request.Files[0].SaveAs(Server.MapPath(path));
                    book.BookImage = "/Areas/Admin/Images/Book/" + newFileName;

                }

                if (book.BookName == oldName && book.BookDescription == oldDescription && book.BookPublisherID == oldPublisher && book.BookAuthorID == oldAuthor && book.BookCategoryID == oldCategory && book.BookTranslatorID == oldTranslator && book.BookPage == oldPage && book.BookPrice == oldPrice && book.BookStock == oldStock && extension == "")
                {
                    messageViewModel.Status = false;
                    messageViewModel.LinkText = "Kitap Listesi";
                    messageViewModel.Url = "/Admin/Kitap";
                    messageViewModel.Message = "Herhangi bir değişiklik yapılmadı...";
                    ViewBagResult();
                    ViewBag.image = oldImage;
                    TempData["message"] = messageViewModel;
                    return View("BookForm", new Book());

                }
                else
                {
                    if (extension == "")
                        book.BookImage = oldImage;

                    if (book.BookStock == 0)
                        book.BookStatus = false;
                    else
                        book.BookStatus = true;

                    book.BookISBN = oldISBN;
                    manager.Update(book);
                    messageViewModel.Status = true;
                    messageViewModel.Message = "Bilgiler başarıyla güncellendi...";
                    TempData["message"] = messageViewModel;
                }
            }

            return RedirectToAction("Index", "Book");
        }


        [Route("Kitap/Guncelle/{id}")]
        public ActionResult Update(int id)
        {
            //editor değilse girsin
            if (User.IsInRole("Editör"))
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "Login");
            }

            var model = manager.GetById(id);
            if (model == null)
                return HttpNotFound();

            ViewBagResult();
            return View("BookForm", model);
        }

        [Route("Kitap/Sil/{id}")]
        public ActionResult Delete(int id)
        {
            //editor değilse girsin
            if (User.IsInRole("Editör"))
            {
                messageViewModel.Status = false;
                messageViewModel.Message = "Yetkisiz işlem...";
                TempData["message"] = messageViewModel;
                return RedirectToAction("Index", "Login");
            }

            var delete = manager.GetById(id);
            if (delete == null)
                return HttpNotFound();
            string oldImage = delete.BookImage;
            string fullPath = Request.MapPath("~" + oldImage);
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
            manager.Delete(delete);
            messageViewModel.Status = true;
            messageViewModel.Message = delete.AuthorFullName + " isimli kitap silindi...";
            TempData["message"] = messageViewModel;
            return RedirectToAction("Index", "Book");

        }


        //ViewBag Doldurma 

        public void ViewBagResult()
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
                                                        Text = i.TranslatorFullName,
                                                        Value = i.ID.ToString()
                                                    }).ToList();

            ViewBag.BookTranslator = translatorItems;

        }


        // ISBN
        public class ISBNGenerator
        {
            public static string GenerateISBN()
            {
                Random random = new Random();

                // Generate 9 random digits
                int[] digits = new int[9];
                for (int i = 0; i < 9; i++)
                {
                    digits[i] = random.Next(0, 10);
                }

                // Calculate the checksum digit
                int checksum = 0;
                for (int i = 0; i < 9; i++)
                {
                    checksum += (i + 1) * digits[i];
                }
                checksum %= 11;

                // Append the checksum digit
                string isbn = string.Join("", digits) + (checksum == 10 ? "X" : checksum.ToString());

                // Format the ISBN with hyphens
                return $"{isbn.Substring(0, 3)}-{isbn.Substring(3, 1)}-{isbn.Substring(4, 4)}-{isbn.Substring(8)}";
            }
        }



    }
}