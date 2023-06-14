using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities.Concrete
{
    public class Author : IEntity
    {       
        public int ID { get; set; }

        [Required(ErrorMessage = "Yazar adı boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Yazar adı en fazla 50 karakter olabilir!")]
        [Display(Name = "Yazar Adı")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Yazar soyadı boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Yazar soyadı en fazla 50 karakter olabilir!")]
        [Display(Name = "Yazar Soyadı")]
        public string AuthorSurname { get; set; }

        [Display(Name = "Yazar Adı Soyadı")]
        public string AuthorFullName => $"{AuthorName} {AuthorSurname}";

        [Required(ErrorMessage = "Yazar biyografisi boş geçilemez!")]
        [StringLength(5000, ErrorMessage = "Yazar biyografisi en fazla 5000 karakter olabilir!")]
        [Display(Name = "Yazar Biyografisi")]
        public string AuthorBiography { get; set; }

        [Required(ErrorMessage = "Yazar resmi boş geçilemez!")]
        [StringLength(250, ErrorMessage = "Yazar resmi en fazla 250 karakter olabilir!")]
        [Display(Name = "Yazar Resmi")]
        public string AuthorImage { get; set; }

        [Required(ErrorMessage = "Yazar ülkesi boş geçilemez!")]
        [Display(Name = "Yazar Ülkesi")]
        public string AuthorCountry { get; set; }

        [Required(ErrorMessage = "Yazar şehri boş geçilemez!")]
        [Display(Name = "Yazar Şehri")]
        public string AuthorCity { get; set; }

        [Display(Name = "Yazar Ülke / Şehir")]
        public string AuthorCountryCity => $"{AuthorCountry} / {AuthorCity}";




        // Navigation Property
        public virtual ICollection<Book> Books { get; set; }

    }
}
