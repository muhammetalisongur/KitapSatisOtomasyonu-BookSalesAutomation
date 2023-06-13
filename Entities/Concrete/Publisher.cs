using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Publisher : IEntity
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Yayınevi adı boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Yayınevi adı en fazla 50 karakter olabilir!")]
        [Display(Name = "Yayınevi Adı")]
        public string PublisherName { get; set; }

        [Required(ErrorMessage = "Yayınevi açıklaması boş geçilemez!")]
        [StringLength(5000, ErrorMessage = "Yayınevi açıklaması en fazla 5000 karakter olabilir!")]
        [Display(Name = "Yayınevi Açıklaması")]
        public string PublisherDescription { get; set; }

        [Required(ErrorMessage = "Yayınevi adresi boş geçilemez!")]
        [StringLength(250, ErrorMessage = "Yayınevi adresi en fazla 250 karakter olabilir!")]
        [Display(Name = "Yayınevi Adresi")]
        public string PublisherAddress { get; set; }


        [Required(ErrorMessage = "Yayınevi e-posta adresi boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Yayınevi e-posta adresi en fazla 50 karakter olabilir!")]
        [Display(Name = "Yayınevi E-Posta Adresi")]
        public string PublisherEmail { get; set; }

        [Required(ErrorMessage = "Yayınevi resmi boş geçilemez!")]
        [StringLength(250, ErrorMessage = "Yayınevi resmi en fazla 250 karakter olabilir!")]
        [Display(Name = "Yayınevi Resmi")]
        public string PublisherImage { get; set; }

        [Required(ErrorMessage = "Yayınevi ülkesi boş geçilemez!")]
        [Display(Name = "Yayınevi Ülkesi")]
        public string PublisherCountry { get; set; }

        [Required(ErrorMessage = "Yayınevi şehri boş geçilemez!")]
        [Display(Name = "Yayınevi Şehri")]
        public string PublisherCity { get; set; }
        public string PublisherCountryCity => $"{PublisherCountry} / {PublisherCity}";


        // Navigation Property
        public virtual ICollection<Book> Books { get; set; }
    }
}
