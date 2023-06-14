using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Kitap adı boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Kitap adı en fazla 50 karakter olabilir!")]
        [Display(Name = "Kitap Adı")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Kitap açıklaması boş geçilemez!")]
        [StringLength(5000, ErrorMessage = "Kitap açıklaması en fazla 5000 karakter olabilir!")]
        [Display(Name = "Kitap Açıklaması")]
        public string BookDescription { get; set; }

        [Required(ErrorMessage = "Kitap resmi boş geçilemez!")]
        [StringLength(250, ErrorMessage = "Kitap resmi en fazla 250 karakter olabilir!")]
        [Display(Name = "Kitap Resmi")]
        public string BookImage { get; set; }

        [Required(ErrorMessage = "Kitap yayıncısı boş geçilemez!")]
        [Display(Name = "Kitap Yayıncısı")]
        [ForeignKey("Publisher")]
        public int BookPublisherID { get; set; }

        [Required(ErrorMessage = "Kitap yazarı boş geçilemez!")]
        [Display(Name = "Kitap Yazarı")]
        [ForeignKey("Author")]
        public int BookAuthorID { get; set; }

        [Required(ErrorMessage = "Kitap kategorisi boş geçilemez!")]
        [Display(Name = "Kitap Kategorisi")]
        [ForeignKey("Category")]
        public int BookCategoryID { get; set; }

        [Required(ErrorMessage = "Kitap dili boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Kitap dili en fazla 50 karakter olabilir!")]
        [Display(Name = "Kitap Dili")]
        public string BookLanguage { get; set; }

        [Required(ErrorMessage = "Kitap çevirmeni boş geçilemez!")]
        [Display(Name = "Kitap Çevirmeni")]
        [ForeignKey("BookTranslator")]
        public int BookTranslatorID { get; set; }

        [Required(ErrorMessage = "Kitap sayfa sayısı boş geçilemez!")]
        [Range(1, int.MaxValue, ErrorMessage = "Kitap sayfa sayısı en az 1 olabilir!")]
        [Display(Name = "Kitap Sayfa Sayısı")]
        public int BookPage { get; set; }

        [Required(ErrorMessage = "Kitap fiyatı boş geçilemez!")]
        [Range(1, int.MaxValue, ErrorMessage = "Kitap fiyatı en az 1 olabilir!")]
        [Display(Name = "Kitap Fiyatı")]
        public decimal BookPrice { get; set; }

        [Required(ErrorMessage = "Kitap ISBN numarası boş geçilemez!")]
        [StringLength(20, ErrorMessage = "Kitap ISBN numarası en fazla 20 karakter olabilir!")]
        [Display(Name = "Kitap ISBN Numarası")]
        public string BookISBN { get; set; }

        [Required(ErrorMessage = "Kitap stok sayısı boş geçilemez!")]
        [Range(1, int.MaxValue, ErrorMessage = "Kitap stok sayısı en az 1 olabilir!")]
        [Display(Name = "Kitap Stok Sayısı")]
        public int BookStock { get; set; }

        [Required(ErrorMessage = "Kitap basım tarihi boş geçilemez!")]
        [Range(1900, 2023, ErrorMessage = "Kitap basım tarihi 1900-2023 arasında olabilir!")]
        [Display(Name = "Kitap Basım Tarihi")]
        public int BookPublishDate { get; set; }

        [Required(ErrorMessage = "Kitap durumu boş geçilemez!")]
        [Display(Name = "Kitap Durumu")]
        public bool BookStatus { get; set; }


        // Navigation Property
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual BookTranslator BookTranslator { get; set; }



    }
}
