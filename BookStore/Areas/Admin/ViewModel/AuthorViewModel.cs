using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Areas.Admin.ViewModel
{
    public class AuthorViewModel
    {
        public int ID { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string AuthorFullName => $"{AuthorName} {AuthorSurname}";
        public string AuthorBiography { get; set; }
        public string AuthorImage { get; set; }
        public int AuthorCountryID { get; set; }
        public int? AuthorCityID { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string AuthorCountryCity => CountryName + " / " + (CityName == null ? "Şehir Yok" : CityName);

    }
}