using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Areas.Admin.ViewModel
{
    public class PublisherViewModel
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public string PublisherDescription { get; set; }
        public string PublisherEmail { get; set; }
        public string PublisherImage { get; set; }
        public string PublisherAddress { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string PublisherCountryCity => CountryName + " / " + (CityName == null ? "Şehir Yok" : CityName);

    }
}