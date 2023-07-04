using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Areas.Admin.ViewModel
{
    public class BookTranslatorViewModel
    {
        public int ID { get; set; }
        public string TranslatorName { get; set; }
        public string TranslatorSurname { get; set; }
        public string TranslatorBiography { get; set; }
        public string TranslatorImage { get; set; }
        public int TranslatorCountryID { get; set; }
        public int TranslatorCityID { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }

    }
}