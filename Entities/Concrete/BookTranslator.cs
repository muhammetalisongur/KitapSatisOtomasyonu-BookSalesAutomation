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
    public class BookTranslator : IEntity
    {
     
        public int ID { get; set; }

        [Required(ErrorMessage = "Çevirmen adı boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Çevirmen adı en fazla 50 karakter olabilir!")]
        [Display(Name = "Çevirmen Adı")]
        public string TranslatorName { get; set; }

        [Required(ErrorMessage = "Çevirmen soyadı boş geçilemez!")]
        [StringLength(50, ErrorMessage = "Çevirmen soyadı en fazla 50 karakter olabilir!")]
        [Display(Name = "Çevirmen Soyadı")]
        public string TranslatorSurname { get; set; }

        [Display(Name = "Çevirmen Adı Soyadı")]
        public string TranslatorFullName => $"{TranslatorName} {TranslatorSurname}";

        [Required(ErrorMessage = "Çevirmen biyografisi boş geçilemez!")]
        [StringLength(5000, ErrorMessage = "Çevirmen biyografisi en fazla 5000 karakter olabilir!")]
        [Display(Name = "Çevirmen Biyografisi")]
        public string TranslatorBiography { get; set; }


        [Display(Name = "Çevirmen Resmi")]
        public string TranslatorImage { get; set; }

        [Required(ErrorMessage = "Çevirmen ülkesi boş geçilemez!")]
        [Display(Name = "Çevirmen Ülkesi")]
        [ForeignKey("Country")]
        public int TranslatorCountryID { get; set; }

        [Display(Name = "Çevirmen Şehri")]
        [ForeignKey("City")]
        public int? TranslatorCityID { get; set; }


        [NotMapped]
        public string CountryName { get; set; }
        [NotMapped]
        public string CityName { get; set; }

        [NotMapped]
        [Display(Name = "Çevirmen Ülke / Şehir")]
        public string TranslatorCountryCity => CountryName + " / " + (CityName == null ? "Şehir Yok" : CityName);


        // Navigation Property
        public virtual ICollection<Book> Books { get; set; }
        public virtual Country Country { get; set; }
        public virtual City City { get; set; }
    }
}
