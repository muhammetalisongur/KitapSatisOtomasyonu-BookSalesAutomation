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
    public class City : IEntity
    {
        public int ID { get; set; }

        [Display(Name = "Şehir Adı")]
        [Required(ErrorMessage = "Şehir Adı Boş Geçilemez")]
        public string CityName { get; set; }

        [ForeignKey("Country")]
        public int CountryID { get; set; }

        [NotMapped]
        [Display(Name = "Ülke / Şehir")]
        public string CountryCityName => $"{Country.CountryName} / {CityName}";


        //Navigation Property
        public virtual Country Country { get; set; }
    }
}
