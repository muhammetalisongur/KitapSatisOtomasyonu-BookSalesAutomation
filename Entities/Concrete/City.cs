using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class City : IEntity
    {
        public int ID { get; set; }

        [Display(Name = "Şehir Adı")]
        [Required(ErrorMessage = "Şehir Adı Boş Geçilemez")]
        public string CityName { get; set; }

        [ForeignKey("Country")]
        public int? CountryID { get; set; }

        [Display(Name = "Ülke / Şehir")]
        public string CountryCityName => $"{Country.CountryName} / {CityName}";


        //Navigation Property

        public virtual Country Country { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Publisher> Publishers { get; set; }
        public virtual ICollection<BookTranslator> BookTranslator { get; set; }
    }
}
