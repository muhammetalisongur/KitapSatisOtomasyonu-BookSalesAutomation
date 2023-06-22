using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations.Seeds
{
    public class CitySeed<T> : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            IList<City> cities = new List<City>();

            #region City
            // Türkiye
            cities.Add(new City() { ID = 1, CityName = "İstanbul", CountryID = 1 });
            cities.Add(new City() { ID = 2, CityName = "Ankara", CountryID = 1 });
            cities.Add(new City() { ID = 3, CityName = "İzmir", CountryID = 1 });
            cities.Add(new City() { ID = 4, CityName = "Bursa", CountryID = 1 });
            cities.Add(new City() { ID = 5, CityName = "Adana", CountryID = 1 });
            cities.Add(new City() { ID = 6, CityName = "Adıyaman", CountryID = 1 });
            cities.Add(new City() { ID = 7, CityName = "Afyonkarahisar", CountryID = 1 });
            cities.Add(new City() { ID = 8, CityName = "Ağrı", CountryID = 1 });
            cities.Add(new City() { ID = 9, CityName = "Aksaray", CountryID = 1 });
            cities.Add(new City() { ID = 10, CityName = "Amasya", CountryID = 1 });
            cities.Add(new City() { ID = 11, CityName = "Antalya", CountryID = 1 });
            cities.Add(new City() { ID = 12, CityName = "Ardahan", CountryID = 1 });
            cities.Add(new City() { ID = 13, CityName = "Artvin", CountryID = 1 });
            cities.Add(new City() { ID = 14, CityName = "Aydın", CountryID = 1 });
            cities.Add(new City() { ID = 15, CityName = "Balıkesir", CountryID = 1 });
            cities.Add(new City() { ID = 16, CityName = "Bartın", CountryID = 1 });
            cities.Add(new City() { ID = 17, CityName = "Batman", CountryID = 1 });
            cities.Add(new City() { ID = 18, CityName = "Bayburt", CountryID = 1 });
            cities.Add(new City() { ID = 19, CityName = "Bilecik", CountryID = 1 });
            cities.Add(new City() { ID = 20, CityName = "Bingöl", CountryID = 1 });
            cities.Add(new City() { ID = 21, CityName = "Bitlis", CountryID = 1 });
            cities.Add(new City() { ID = 22, CityName = "Bolu", CountryID = 1 });
            cities.Add(new City() { ID = 23, CityName = "Burdur", CountryID = 1 });
            cities.Add(new City() { ID = 24, CityName = "Çanakkale", CountryID = 1 });
            cities.Add(new City() { ID = 25, CityName = "Çankırı", CountryID = 1 });
            cities.Add(new City() { ID = 26, CityName = "Çorum", CountryID = 1 });
            cities.Add(new City() { ID = 27, CityName = "Denizli", CountryID = 1 });
            cities.Add(new City() { ID = 28, CityName = "Diyarbakır", CountryID = 1 });
            cities.Add(new City() { ID = 29, CityName = "Düzce", CountryID = 1 });
            cities.Add(new City() { ID = 30, CityName = "Edirne", CountryID = 1 });
            cities.Add(new City() { ID = 31, CityName = "Elazığ", CountryID = 1 });
            cities.Add(new City() { ID = 32, CityName = "Erzincan", CountryID = 1 });
            cities.Add(new City() { ID = 33, CityName = "Erzurum", CountryID = 1 });
            cities.Add(new City() { ID = 34, CityName = "Eskişehir", CountryID = 1 });
            cities.Add(new City() { ID = 35, CityName = "Gaziantep", CountryID = 1 });
            cities.Add(new City() { ID = 36, CityName = "Giresun", CountryID = 1 });
            cities.Add(new City() { ID = 37, CityName = "Gümüşhane", CountryID = 1 });
            cities.Add(new City() { ID = 38, CityName = "Hakkari", CountryID = 1 });
            cities.Add(new City() { ID = 39, CityName = "Hatay", CountryID = 1 });
            cities.Add(new City() { ID = 40, CityName = "Iğdır", CountryID = 1 });
            cities.Add(new City() { ID = 41, CityName = "Isparta", CountryID = 1 });
            cities.Add(new City() { ID = 42, CityName = "Kahramanmaraş", CountryID = 1 });
            cities.Add(new City() { ID = 43, CityName = "Karabük", CountryID = 1 });
            cities.Add(new City() { ID = 44, CityName = "Karaman", CountryID = 1 });
            cities.Add(new City() { ID = 45, CityName = "Kars", CountryID = 1 });
            cities.Add(new City() { ID = 46, CityName = "Kastamonu", CountryID = 1 });
            cities.Add(new City() { ID = 47, CityName = "Kayseri", CountryID = 1 });
            cities.Add(new City() { ID = 48, CityName = "Kırıkkale", CountryID = 1 });
            cities.Add(new City() { ID = 49, CityName = "Kırklareli", CountryID = 1 });
            cities.Add(new City() { ID = 50, CityName = "Kırşehir", CountryID = 1 });
            cities.Add(new City() { ID = 51, CityName = "Kilis", CountryID = 1 });
            cities.Add(new City() { ID = 52, CityName = "Kocaeli", CountryID = 1 });
            cities.Add(new City() { ID = 53, CityName = "Konya", CountryID = 1 });
            cities.Add(new City() { ID = 54, CityName = "Kütahya", CountryID = 1 });
            cities.Add(new City() { ID = 55, CityName = "Malatya", CountryID = 1 });
            cities.Add(new City() { ID = 56, CityName = "Manisa", CountryID = 1 });
            cities.Add(new City() { ID = 57, CityName = "Mardin", CountryID = 1 });
            cities.Add(new City() { ID = 58, CityName = "Mersin", CountryID = 1 });
            cities.Add(new City() { ID = 59, CityName = "Muğla", CountryID = 1 });
            cities.Add(new City() { ID = 60, CityName = "Muş", CountryID = 1 });
            cities.Add(new City() { ID = 61, CityName = "Nevşehir", CountryID = 1 });
            cities.Add(new City() { ID = 62, CityName = "Niğde", CountryID = 1 });
            cities.Add(new City() { ID = 63, CityName = "Ordu", CountryID = 1 });
            cities.Add(new City() { ID = 64, CityName = "Osmaniye", CountryID = 1 });
            cities.Add(new City() { ID = 65, CityName = "Rize", CountryID = 1 });
            cities.Add(new City() { ID = 66, CityName = "Sakarya", CountryID = 1 });
            cities.Add(new City() { ID = 67, CityName = "Samsun", CountryID = 1 });
            cities.Add(new City() { ID = 68, CityName = "Siirt", CountryID = 1 });
            cities.Add(new City() { ID = 69, CityName = "Sinop", CountryID = 1 });
            cities.Add(new City() { ID = 70, CityName = "Sivas", CountryID = 1 });
            cities.Add(new City() { ID = 71, CityName = "Şanlıurfa", CountryID = 1 });
            cities.Add(new City() { ID = 72, CityName = "Şırnak", CountryID = 1 });
            cities.Add(new City() { ID = 73, CityName = "Tekirdağ", CountryID = 1 });
            cities.Add(new City() { ID = 74, CityName = "Tokat", CountryID = 1 });
            cities.Add(new City() { ID = 75, CityName = "Trabzon", CountryID = 1 });
            cities.Add(new City() { ID = 76, CityName = "Tunceli", CountryID = 1 });
            cities.Add(new City() { ID = 77, CityName = "Uşak", CountryID = 1 });
            cities.Add(new City() { ID = 78, CityName = "Van", CountryID = 1 });
            cities.Add(new City() { ID = 79, CityName = "Yalova", CountryID = 1 });
            cities.Add(new City() { ID = 80, CityName = "Yozgat", CountryID = 1 });
            cities.Add(new City() { ID = 81, CityName = "Zonguldak", CountryID = 1 });

            // Amerika
            cities.Add(new City() { ID = 82, CityName = "Alabama", CountryID = 2 });
            cities.Add(new City() { ID = 83, CityName = "Alaska", CountryID = 2 });
            cities.Add(new City() { ID = 84, CityName = "Arizona", CountryID = 2 });
            cities.Add(new City() { ID = 85, CityName = "Arkansas", CountryID = 2 });
            cities.Add(new City() { ID = 86, CityName = "California", CountryID = 2 });
            cities.Add(new City() { ID = 87, CityName = "Colorado", CountryID = 2 });
            cities.Add(new City() { ID = 88, CityName = "Connecticut", CountryID = 2 });
            cities.Add(new City() { ID = 89, CityName = "Delaware", CountryID = 2 });
            cities.Add(new City() { ID = 90, CityName = "Florida", CountryID = 2 });
            cities.Add(new City() { ID = 91, CityName = "Georgia", CountryID = 2 });
            cities.Add(new City() { ID = 92, CityName = "Hawaii", CountryID = 2 });
            cities.Add(new City() { ID = 93, CityName = "Idaho", CountryID = 2 });
            cities.Add(new City() { ID = 94, CityName = "Illinois", CountryID = 2 });
            cities.Add(new City() { ID = 95, CityName = "Indiana", CountryID = 2 });
            cities.Add(new City() { ID = 96, CityName = "Iowa", CountryID = 2 });
            cities.Add(new City() { ID = 97, CityName = "Kansas", CountryID = 2 });
            cities.Add(new City() { ID = 98, CityName = "Kentucky", CountryID = 2 });
            cities.Add(new City() { ID = 99, CityName = "Louisiana", CountryID = 2 });
            cities.Add(new City() { ID = 100, CityName = "Maine", CountryID = 2 });
            cities.Add(new City() { ID = 101, CityName = "Maryland", CountryID = 2 });
            cities.Add(new City() { ID = 102, CityName = "Massachusetts", CountryID = 2 });
            cities.Add(new City() { ID = 103, CityName = "Michigan", CountryID = 2 });
            cities.Add(new City() { ID = 104, CityName = "Minnesota", CountryID = 2 });
            cities.Add(new City() { ID = 105, CityName = "Mississippi", CountryID = 2 });
            cities.Add(new City() { ID = 106, CityName = "Missouri", CountryID = 2 });
            cities.Add(new City() { ID = 107, CityName = "Montana", CountryID = 2 });
            cities.Add(new City() { ID = 108, CityName = "Nebraska", CountryID = 2 });
            cities.Add(new City() { ID = 109, CityName = "Nevada", CountryID = 2 });
            cities.Add(new City() { ID = 110, CityName = "New Hampshire", CountryID = 2 });
            cities.Add(new City() { ID = 111, CityName = "New Jersey", CountryID = 2 });
            cities.Add(new City() { ID = 112, CityName = "New Mexico", CountryID = 2 });
            cities.Add(new City() { ID = 113, CityName = "New York", CountryID = 2 });
            cities.Add(new City() { ID = 114, CityName = "North Carolina", CountryID = 2 });
            cities.Add(new City() { ID = 115, CityName = "North Dakota", CountryID = 2 });
            cities.Add(new City() { ID = 116, CityName = "Ohio", CountryID = 2 });
            cities.Add(new City() { ID = 117, CityName = "Oklahoma", CountryID = 2 });
            cities.Add(new City() { ID = 118, CityName = "Oregon", CountryID = 2 });
            cities.Add(new City() { ID = 119, CityName = "Pennsylvania", CountryID = 2 });
            cities.Add(new City() { ID = 120, CityName = "Rhode Island", CountryID = 2 });
            cities.Add(new City() { ID = 121, CityName = "South Carolina", CountryID = 2 });
            cities.Add(new City() { ID = 122, CityName = "South Dakota", CountryID = 2 });
            cities.Add(new City() { ID = 123, CityName = "Tennessee", CountryID = 2 });
            cities.Add(new City() { ID = 124, CityName = "Texas", CountryID = 2 });
            cities.Add(new City() { ID = 125, CityName = "Utah", CountryID = 2 });
            cities.Add(new City() { ID = 126, CityName = "Vermont", CountryID = 2 });
            cities.Add(new City() { ID = 127, CityName = "Virginia", CountryID = 2 });
            cities.Add(new City() { ID = 128, CityName = "Washington", CountryID = 2 });
            cities.Add(new City() { ID = 129, CityName = "West Virginia", CountryID = 2 });
            cities.Add(new City() { ID = 130, CityName = "Wisconsin", CountryID = 2 });
            cities.Add(new City() { ID = 131, CityName = "Wyoming", CountryID = 2 });
            cities.Add(new City() { ID = 132, CityName = "Washington DC", CountryID = 2 });
            cities.Add(new City() { ID = 133, CityName = "New York City", CountryID = 2 });
            cities.Add(new City() { ID = 134, CityName = "Los Angeles", CountryID = 2 });
            cities.Add(new City() { ID = 135, CityName = "Chicago", CountryID = 2 });
            cities.Add(new City() { ID = 136, CityName = "Houston", CountryID = 2 });
            cities.Add(new City() { ID = 137, CityName = "Philadelphia", CountryID = 2 });
            cities.Add(new City() { ID = 138, CityName = "Phoenix", CountryID = 2 });
            cities.Add(new City() { ID = 139, CityName = "San Antonio", CountryID = 2 });
            cities.Add(new City() { ID = 140, CityName = "San Diego", CountryID = 2 });
            cities.Add(new City() { ID = 141, CityName = "Dallas", CountryID = 2 });
            cities.Add(new City() { ID = 142, CityName = "San Jose", CountryID = 2 });
            cities.Add(new City() { ID = 143, CityName = "Austin", CountryID = 2 });
            cities.Add(new City() { ID = 144, CityName = "Indianapolis", CountryID = 2 });
            cities.Add(new City() { ID = 145, CityName = "Jacksonville", CountryID = 2 });
            cities.Add(new City() { ID = 146, CityName = "San Francisco", CountryID = 2 });

            // Almanya
            cities.Add(new City() { ID = 147, CityName = "Berlin", CountryID = 3 });
            cities.Add(new City() { ID = 148, CityName = "Hamburg", CountryID = 3 });
            cities.Add(new City() { ID = 149, CityName = "Munich", CountryID = 3 });
            cities.Add(new City() { ID = 150, CityName = "Cologne", CountryID = 3 });
            cities.Add(new City() { ID = 151, CityName = "Frankfurt", CountryID = 3 });
            cities.Add(new City() { ID = 152, CityName = "Stuttgart", CountryID = 3 });
            cities.Add(new City() { ID = 153, CityName = "Düsseldorf", CountryID = 3 });


            // İngiltere
            cities.Add(new City() { ID = 154, CityName = "London", CountryID = 4 });
            cities.Add(new City() { ID = 155, CityName = "Birmingham", CountryID = 4 });
            cities.Add(new City() { ID = 156, CityName = "Glasgow", CountryID = 4 });
            cities.Add(new City() { ID = 157, CityName = "Liverpool", CountryID = 4 });
            cities.Add(new City() { ID = 158, CityName = "Leeds", CountryID = 4 });
            cities.Add(new City() { ID = 159, CityName = "Sheffield", CountryID = 4 });
            cities.Add(new City() { ID = 160, CityName = "Edinburgh", CountryID = 4 });
            cities.Add(new City() { ID = 161, CityName = "Bristol", CountryID = 4 });
            cities.Add(new City() { ID = 162, CityName = "Manchester", CountryID = 4 });
            cities.Add(new City() { ID = 163, CityName = "Leicester", CountryID = 4 });
            cities.Add(new City() { ID = 164, CityName = "Coventry", CountryID = 4 });


            // Fransa
            cities.Add(new City() { ID = 165, CityName = "Paris", CountryID = 5 });
            cities.Add(new City() { ID = 166, CityName = "Marseille", CountryID = 5 });
            cities.Add(new City() { ID = 167, CityName = "Lyon", CountryID = 5 });
            cities.Add(new City() { ID = 168, CityName = "Toulouse", CountryID = 5 });
            cities.Add(new City() { ID = 169, CityName = "Nice", CountryID = 5 });
            cities.Add(new City() { ID = 170, CityName = "Nantes", CountryID = 5 });
            cities.Add(new City() { ID = 171, CityName = "Strasbourg", CountryID = 5 });
            cities.Add(new City() { ID = 172, CityName = "Montpellier", CountryID = 5 });
            cities.Add(new City() { ID = 173, CityName = "Bordeaux", CountryID = 5 });
            cities.Add(new City() { ID = 174, CityName = "Lille", CountryID = 5 });
            cities.Add(new City() { ID = 175, CityName = "Rennes", CountryID = 5 });
            cities.Add(new City() { ID = 176, CityName = "Reims", CountryID = 5 }); 
            #endregion


            context.Cities.AddRange(cities);
            
        }
    }
}
