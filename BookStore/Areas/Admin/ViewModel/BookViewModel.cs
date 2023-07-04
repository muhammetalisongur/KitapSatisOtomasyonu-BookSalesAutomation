using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Areas.Admin.ViewModel
{
    public class BookViewModel
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string BookDescription { get; set; }
        public string BookImage { get; set; }
        public int BookPublisherID { get; set; }
        public int BookAuthorID { get; set; }
        public int BookCategoryID { get; set; }
        public int? BookTranslatorID { get; set; }
        public int BookPage { get; set; }
        public decimal BookPrice { get; set; }
        public string BookISBN { get; set; }
        public int BookStock { get; set; }
        public bool BookStatus { get; set; }
        public string CategoryName { get; set; }
        public string TranslatorName { get; set; }
        public string TranslatorSurname { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string PublisherName { get; set; }
    }
}