using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations.Seeds
{
    public class SeedDatabase : DropCreateDatabaseIfModelChanges<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            IList<Country> countries = new List<Country>();

            #region Countries
            countries.Add(new Country() { ID = 1, CountryName = "Türkiye" });
            countries.Add(new Country() { ID = 2, CountryName = "Amerika" });
            countries.Add(new Country() { ID = 3, CountryName = "Almanya" });
            countries.Add(new Country() { ID = 4, CountryName = "İngiltere" });
            countries.Add(new Country() { ID = 5, CountryName = "Fransa" });
            countries.Add(new Country() { ID = 6, CountryName = "İtalya" });
            countries.Add(new Country() { ID = 7, CountryName = "İspanya" });
            countries.Add(new Country() { ID = 8, CountryName = "Rusya" });
            countries.Add(new Country() { ID = 9, CountryName = "Çin" });
            countries.Add(new Country() { ID = 10, CountryName = "Japonya" });
            countries.Add(new Country() { ID = 11, CountryName = "Hindistan" });
            countries.Add(new Country() { ID = 12, CountryName = "Kanada" });
            countries.Add(new Country() { ID = 13, CountryName = "Avustralya" });
            countries.Add(new Country() { ID = 14, CountryName = "Brezilya" });
            countries.Add(new Country() { ID = 15, CountryName = "Meksika" });
            countries.Add(new Country() { ID = 16, CountryName = "Endonezya" });
            countries.Add(new Country() { ID = 17, CountryName = "Güney Afrika" });
            countries.Add(new Country() { ID = 18, CountryName = "Tayland" });
            countries.Add(new Country() { ID = 19, CountryName = "İsviçre" });
            countries.Add(new Country() { ID = 20, CountryName = "İsveç" });
            countries.Add(new Country() { ID = 21, CountryName = "Norveç" });
            countries.Add(new Country() { ID = 22, CountryName = "Hollanda" });
            countries.Add(new Country() { ID = 23, CountryName = "Belçika" });
            countries.Add(new Country() { ID = 24, CountryName = "Avusturya" });
            countries.Add(new Country() { ID = 25, CountryName = "Danimarka" });
            countries.Add(new Country() { ID = 26, CountryName = "Polonya" });
            countries.Add(new Country() { ID = 27, CountryName = "İrlanda" });
            countries.Add(new Country() { ID = 28, CountryName = "Yunanistan" });
            countries.Add(new Country() { ID = 29, CountryName = "Portekiz" });
            countries.Add(new Country() { ID = 30, CountryName = "Çek Cumhuriyeti" });
            countries.Add(new Country() { ID = 31, CountryName = "Finlandiya" });
            countries.Add(new Country() { ID = 32, CountryName = "Romanya" });
            countries.Add(new Country() { ID = 33, CountryName = "Macaristan" });
            countries.Add(new Country() { ID = 34, CountryName = "Bulgaristan" });
            countries.Add(new Country() { ID = 35, CountryName = "Slovakya" });
            countries.Add(new Country() { ID = 36, CountryName = "Hırvatistan" });
            countries.Add(new Country() { ID = 37, CountryName = "Litvanya" });
            countries.Add(new Country() { ID = 38, CountryName = "Slovenya" });
            countries.Add(new Country() { ID = 39, CountryName = "Estonya" });
            countries.Add(new Country() { ID = 40, CountryName = "Letonya" });
            countries.Add(new Country() { ID = 41, CountryName = "Lüksemburg" });
            countries.Add(new Country() { ID = 42, CountryName = "Kıbrıs" });
            countries.Add(new Country() { ID = 43, CountryName = "Malta" });
            countries.Add(new Country() { ID = 44, CountryName = "İzlanda" });
            countries.Add(new Country() { ID = 45, CountryName = "Küba" });
            countries.Add(new Country() { ID = 46, CountryName = "Dominik Cumhuriyeti" });
            countries.Add(new Country() { ID = 47, CountryName = "Kolombiya" });
            countries.Add(new Country() { ID = 48, CountryName = "Venezuela" });
            countries.Add(new Country() { ID = 49, CountryName = "Arjantin" });
            countries.Add(new Country() { ID = 50, CountryName = "Şili" });
            countries.Add(new Country() { ID = 51, CountryName = "Peru" });
            countries.Add(new Country() { ID = 52, CountryName = "Ekvador" });
            countries.Add(new Country() { ID = 53, CountryName = "Uruguay" });
            countries.Add(new Country() { ID = 54, CountryName = "Paraguay" });
            countries.Add(new Country() { ID = 55, CountryName = "Bolivya" });
            countries.Add(new Country() { ID = 56, CountryName = "Kosta Rika" });
            countries.Add(new Country() { ID = 57, CountryName = "Panama" });
            countries.Add(new Country() { ID = 58, CountryName = "El Salvador" });
            countries.Add(new Country() { ID = 59, CountryName = "Guatemala" });
            countries.Add(new Country() { ID = 60, CountryName = "Honduras" });
            countries.Add(new Country() { ID = 61, CountryName = "Nikaragua" });
            countries.Add(new Country() { ID = 62, CountryName = "Haiti" });
            countries.Add(new Country() { ID = 63, CountryName = "Bahamalar" });
            countries.Add(new Country() { ID = 64, CountryName = "Jamaika" });
            countries.Add(new Country() { ID = 65, CountryName = "Trinidad ve Tobago" });
            countries.Add(new Country() { ID = 66, CountryName = "Barbados" });
            countries.Add(new Country() { ID = 67, CountryName = "Dominika" });
            countries.Add(new Country() { ID = 68, CountryName = "Saint Lucia" });
            countries.Add(new Country() { ID = 69, CountryName = "Antigua ve Barbuda" });
            countries.Add(new Country() { ID = 70, CountryName = "Saint Vincent ve Grenadinler" });
            countries.Add(new Country() { ID = 71, CountryName = "Grenada" });
            countries.Add(new Country() { ID = 72, CountryName = "Saint Kitts ve Nevis" });
            countries.Add(new Country() { ID = 73, CountryName = "Belize" });
            countries.Add(new Country() { ID = 74, CountryName = "Guyana" });
            countries.Add(new Country() { ID = 75, CountryName = "Surinam" });
            countries.Add(new Country() { ID = 76, CountryName = "Bahreyn" });
            countries.Add(new Country() { ID = 77, CountryName = "Katar" });
            countries.Add(new Country() { ID = 78, CountryName = "Kuveyt" });
            countries.Add(new Country() { ID = 79, CountryName = "Umman" });
            countries.Add(new Country() { ID = 80, CountryName = "Lübnan" });
            countries.Add(new Country() { ID = 81, CountryName = "Filistin" });
            countries.Add(new Country() { ID = 82, CountryName = "Suriye" });
            countries.Add(new Country() { ID = 83, CountryName = "Ürdün" });
            countries.Add(new Country() { ID = 84, CountryName = "Irak" });
            countries.Add(new Country() { ID = 85, CountryName = "Kırgızistan" });
            countries.Add(new Country() { ID = 86, CountryName = "Tacikistan" });
            countries.Add(new Country() { ID = 87, CountryName = "Türkmenistan" });
            countries.Add(new Country() { ID = 88, CountryName = "Özbekistan" });
            countries.Add(new Country() { ID = 89, CountryName = "Azerbaycan" });
            countries.Add(new Country() { ID = 90, CountryName = "Gürcistan" });
            countries.Add(new Country() { ID = 91, CountryName = "Ermenistan" });
            countries.Add(new Country() { ID = 92, CountryName = "Kuzey Kıbrıs Türk Cumhuriyeti" });
            countries.Add(new Country() { ID = 93, CountryName = "Kosova" });
            countries.Add(new Country() { ID = 94, CountryName = "Güney Sudan" });
            countries.Add(new Country() { ID = 95, CountryName = "Filipinler" });
            countries.Add(new Country() { ID = 96, CountryName = "Tayland" });
            countries.Add(new Country() { ID = 97, CountryName = "Malezya" });
            countries.Add(new Country() { ID = 98, CountryName = "Singapur" });
            countries.Add(new Country() { ID = 99, CountryName = "Endonezya" });
            countries.Add(new Country() { ID = 100, CountryName = "Brunei" });
            countries.Add(new Country() { ID = 101, CountryName = "Vietnam" });
            countries.Add(new Country() { ID = 102, CountryName = "Laos" });
            countries.Add(new Country() { ID = 103, CountryName = "Kamboçya" });
            countries.Add(new Country() { ID = 104, CountryName = "Myanmar" });
            countries.Add(new Country() { ID = 105, CountryName = "Bangladeş" });
            countries.Add(new Country() { ID = 106, CountryName = "Sri Lanka" });
            countries.Add(new Country() { ID = 107, CountryName = "Maldivler" });
            countries.Add(new Country() { ID = 108, CountryName = "Nepal" });
            countries.Add(new Country() { ID = 109, CountryName = "Bhutan" });
            countries.Add(new Country() { ID = 110, CountryName = "Pakistan" });
            countries.Add(new Country() { ID = 111, CountryName = "Afganistan" });
            countries.Add(new Country() { ID = 112, CountryName = "İran" });
            countries.Add(new Country() { ID = 113, CountryName = "Kazakistan" });
            countries.Add(new Country() { ID = 114, CountryName = "Moğolistan" });
            countries.Add(new Country() { ID = 115, CountryName = "Mongolya" });
            countries.Add(new Country() { ID = 116, CountryName = "Nijer" });
            countries.Add(new Country() { ID = 117, CountryName = "Burkina Faso" });
            countries.Add(new Country() { ID = 118, CountryName = "Mali" });
            countries.Add(new Country() { ID = 119, CountryName = "Etiyopya" });
            countries.Add(new Country() { ID = 120, CountryName = "Mısır" });
            countries.Add(new Country() { ID = 121, CountryName = "Libya" });
            countries.Add(new Country() { ID = 122, CountryName = "Cezayir" });
            countries.Add(new Country() { ID = 123, CountryName = "Tunus" });
            countries.Add(new Country() { ID = 124, CountryName = "Moritanya" });
            countries.Add(new Country() { ID = 125, CountryName = "Senegal" });
            countries.Add(new Country() { ID = 126, CountryName = "Gine" });
            countries.Add(new Country() { ID = 127, CountryName = "Gine-Bissau" });
            countries.Add(new Country() { ID = 128, CountryName = "Sierra Leone" });
            countries.Add(new Country() { ID = 129, CountryName = "Liberya" });
            countries.Add(new Country() { ID = 130, CountryName = "Fildişi Sahili" });
            countries.Add(new Country() { ID = 131, CountryName = "Gana" });
            countries.Add(new Country() { ID = 132, CountryName = "Togo" });
            countries.Add(new Country() { ID = 133, CountryName = "Benin" });
            countries.Add(new Country() { ID = 134, CountryName = "Nijerya" });
            countries.Add(new Country() { ID = 135, CountryName = "Kamerun" });
            #endregion

            context.Countries.AddRange(countries);


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





            IList<Category> categories = new List<Category>();

            #region Book Categories

            // Kitap Kategorileri
            categories.Add(new Category() { ID = 1, CategoryName = "Bilim Kurgu" });
            categories.Add(new Category() { ID = 2, CategoryName = "Bilim" });
            categories.Add(new Category() { ID = 3, CategoryName = "Çocuk Kitapları" });
            categories.Add(new Category() { ID = 4, CategoryName = "Din" });
            categories.Add(new Category() { ID = 5, CategoryName = "Edebiyat" });
            categories.Add(new Category() { ID = 6, CategoryName = "Eğitim" });
            categories.Add(new Category() { ID = 7, CategoryName = "Felsefe" });
            categories.Add(new Category() { ID = 8, CategoryName = "Hukuk" });
            categories.Add(new Category() { ID = 9, CategoryName = "İnceleme" });
            categories.Add(new Category() { ID = 10, CategoryName = "Kişisel Gelişim" });
            categories.Add(new Category() { ID = 11, CategoryName = "Mizah" });
            categories.Add(new Category() { ID = 12, CategoryName = "Psikoloji" });
            categories.Add(new Category() { ID = 13, CategoryName = "Roman" });
            categories.Add(new Category() { ID = 14, CategoryName = "Sağlık" });
            categories.Add(new Category() { ID = 15, CategoryName = "Sanat" });
            categories.Add(new Category() { ID = 16, CategoryName = "Siyaset" });
            categories.Add(new Category() { ID = 17, CategoryName = "Sosyoloji" });
            categories.Add(new Category() { ID = 18, CategoryName = "Tarih" });
            categories.Add(new Category() { ID = 19, CategoryName = "Yemek" });
            categories.Add(new Category() { ID = 20, CategoryName = "Dünya Klasikleri" });
            categories.Add(new Category() { ID = 21, CategoryName = "Türk Klasikleri" });
            categories.Add(new Category() { ID = 22, CategoryName = "Şiir" });
            categories.Add(new Category() { ID = 23, CategoryName = "Gezi" });
            categories.Add(new Category() { ID = 24, CategoryName = "Biyografi" });
            categories.Add(new Category() { ID = 25, CategoryName = "Anı" });


            #endregion

            context.Categories.AddRange(categories);



            IList<Author> authors = new List<Author>();

            #region Authors
            // Authors

            authors.Add(new Author()
            {
                ID = 1,
                AuthorName = "Jules",
                AuthorSurname = "Verne",
                AuthorBiography = "Jules Gabriel Verne (Fransızca telaffuz: [ʒyl vɛʁn]; 8 Şubat 1828 - 24 Mart 1905), Fransız yazar ve gezgin. Verne, Hugo Gernsback ve H. G. Wells ile genellikle bilim kurgunun öncüleri olarak adlandırılır. Eserlerinde ayrıntılarıyla tarif ettiği buluşlar ve makinelerin o sıralarda gelişmekte olan Avrupa sanayisi ve teknolojisine ilham kaynağı olduğu düşünülür. Özellikle uzay, hava taşıtları ve denizaltılar hakkında yazmıştır.Daha çok Denizler Altında Yirmi Bin Fersah (1870), Dünyanın Merkezine Yolculuk (1864) ve Seksen Günde Devr-i Âlem (1873) romanlarıyla tanınır. UNESCO’nun çeviri kitap veritabanına (Index Translationum) göre eserleri en çok çevrilen ikinci yazardır.[1] Eserleri 148 farklı dile çevrildi. Birçok icadı önceden tahmin ettiği için Bilim falcısı olarak anıldı.",
                AuthorImage = "https://picsum.photos/400?id=1",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 2,
                AuthorName = "William",
                AuthorSurname = "Shakespeare",
                AuthorBiography = "William Shakespeare (d. 26 Nisan 1564, Stratford-upon-Avon - ö. 23 Nisan 1616, Stratford-upon-Avon), İngiliz oyun yazarı, şair ve aktördür. İngiliz edebiyatının en önemli figürlerinden biri olarak kabul edilir. Eserleri dünya çapında tanınır ve tiyatro tarihinin en büyük eserleri arasında yer alır.",
                AuthorImage = "https://picsum.photos/400?id=2",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 3,
                AuthorName = "Jane",
                AuthorSurname = "Austen",
                AuthorBiography = "Jane Austen (d. 16 Aralık 1775, Steventon - ö. 18 Temmuz 1817, Winchester), İngiliz roman yazarıdır. Eserleri, İngiliz edebiyatının klasikleri arasında yer alır. Austen, özellikle aşk, evlilik, toplumsal statü ve kadının rolü gibi konuları işlemesiyle tanınır.",
                AuthorImage = "https://picsum.photos/400?id=3",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 4,
                AuthorName = "Fyodor",
                AuthorSurname = "Dostoevsky",
                AuthorBiography = "Fyodor Mihayloviç Dostoyevski (Rusça: Фёдор Миха́йлович Достое́вский; 11 Kasım 1821 - 9 Şubat 1881), Rus yazar. Eserleri, edebi derinlikleri, psikolojik karmaşıklıkları ve etik sorunları ele almasıyla tanınır. Dostoyevski, Rus edebiyatının en büyük yazarlarından biridir.",
                AuthorImage = "https://picsum.photos/400?id=4",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 5,
                AuthorName = "Gabriel",
                AuthorSurname = "García Márquez",
                AuthorBiography = "Gabriel José de la Concordia García Márquez (6 Mart 1927 - 17 Nisan 2014), Kolombiyalı yazar ve gazetecidir. Eserleri, büyülü gerçekçilik tarzıyla tanınır ve Latin Amerika edebiyatının en önemli figürlerinden biri olarak kabul edilir. En ünlü eseri 'Yüzyıllık Yalnızlık'tır.",
                AuthorImage = "https://picsum.photos/400?id=5",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 6,
                AuthorName = "Leo",
                AuthorSurname = "Tolstoy",
                AuthorBiography = "Lev Nikolayeviç Tolstoy (Rusça: Лев Никола́евич Толсто́й; 9 Eylül 1828 - 20 Kasım 1910), Rus yazar ve düşünür. Tolstoy, Rus edebiyatının en büyük yazarlarından biri olarak kabul edilir. Eserleri, insanın ruhsal ve ahlaki gelişimi, sınıfsal adaletsizlikler, savaşın doğası ve insanın toplumla ilişkisi gibi konuları işler.",
                AuthorImage = "https://picsum.photos/400?id=6",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 7,
                AuthorName = "Virginia",
                AuthorSurname = "Woolf",
                AuthorBiography = "Adeline Virginia Woolf (25 Ocak 1882 - 28 Mart 1941), İngiliz yazar ve modernist edebiyatın önde gelen figürlerinden biridir. Woolf, feminist eleştirisi, bilinç akışı tekniği ve deneysel anlatısıyla tanınır. Eserleri, cinsiyet, kimlik, sanat ve edebiyat üzerine derinlikli düşünceleri içerir.",
                AuthorImage = "https://picsum.photos/400?id=7",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 8,
                AuthorName = "Miguel de",
                AuthorSurname = "Cervantes",
                AuthorBiography = "Miguel de Cervantes Saavedra (d. 29 Eylül 1547, Alcalá de Henares - ö. 22 Nisan 1616, Madrid), İspanyol yazar ve şairdir. Dünya edebiyatının en önemli figürlerinden biri olarak kabul edilir. En tanınmış eseri, Don Kişot adlı romanıdır.",
                AuthorImage = "https://picsum.photos/400?id=8",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 9,
                AuthorName = "George",
                AuthorSurname = "Orwell",
                AuthorBiography = "Eric Arthur Blair (25 Haziran 1903 - 21 Ocak 1950), George Orwell mahlasıyla bilinen İngiliz yazar ve gazetecidir. Eserleri, totaliterizm, siyaset, toplum ve dil üzerine eleştirel düşünceleri içerir. '1984' ve 'Hayvan Çiftliği' gibi eserleriyle tanınır.",
                AuthorImage = "https://picsum.photos/400?id=9",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 10,
                AuthorName = "Emily",
                AuthorSurname = "Brontë",
                AuthorBiography = "Emily Jane Brontë (30 Temmuz 1818 - 19 Aralık 1848), İngiliz yazardır. 'Uğultulu Tepeler' adlı tek romanıyla tanınır. Eserleri, tutkulu duyguları, doğa tasvirleri ve karanlık atmosferiyle dikkat çeker.",
                AuthorImage = "https://picsum.photos/400?id=10",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 11,
                AuthorName = "Charles",
                AuthorSurname = "Dickens",
                AuthorBiography = "Charles John Huffam Dickens (7 Şubat 1812 - 9 Haziran 1870), İngiliz yazar ve sosyal eleştirmendir. Eserleri, Viktorya dönemi İngiltere'sindeki toplumsal adaletsizlikleri, yoksulluğu ve çocuk işçiliğini ele alır. 'Büyük Umutlar', 'Oliver Twist' ve 'İki Şehrin Hikayesi' gibi eserleriyle tanınır.",
                AuthorImage = "https://picsum.photos/400?id=11",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 12,
                AuthorName = "Ernest",
                AuthorSurname = "Hemingway",
                AuthorBiography = "Ernest Miller Hemingway (21 Temmuz 1899 - 2 Temmuz 1961), Amerikalı yazar ve gazetecidir. Eserleri, basit ve açık bir dil kullanımıyla dikkat çeker. Hemingway, savaş, aşk, macera ve insan doğası gibi temaları işler. 'Çanlar Kimin İçin Çalıyor' ve 'Yaşlı Adam ve Deniz' gibi eserleriyle tanınır.",
                AuthorImage = "https://picsum.photos/400?id=12",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 13,
                AuthorName = "Charlotte",
                AuthorSurname = "Brontë",
                AuthorBiography = "Charlotte Brontë (21 Nisan 1816 - 31 Mart 1855), İngiliz yazar ve şairdir. 'Jane Eyre' adlı romanıyla tanınır. Eserleri, kadın bağımsızlığı, sınıfsal adaletsizlikler ve aşk gibi konuları ele alır.",
                AuthorImage = "https://picsum.photos/400?id=13",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });

            authors.Add(new Author()
            {
                ID = 14,
                AuthorName = "Mark",
                AuthorSurname = "Twain",
                AuthorBiography = "Samuel Langhorne Clemens (30 Kasım 1835 - 21 Nisan 1910), sahne adıyla Mark Twain, Amerikalı yazar ve mizahçıdır. Eserleri, Amerikan edebiyatının en önemli eserleri arasında yer alır. 'Tom Sawyer'ın Maceraları' ve 'Huckleberry Finn'in Maceraları' gibi eserleriyle tanınır.",
                AuthorImage = "https://picsum.photos/400?id=14",
                AuthorCountryID = 2,
                AuthorCityID = 84,
            });

            authors.Add(new Author()
            {
                ID = 15,
                AuthorName = "Albert",
                AuthorSurname = "Camus",
                AuthorBiography = "Albert Camus (7 Kasım 1913 - 4 Ocak 1960), Cezayir asıllı Fransız yazar ve düşünürdür. Eserleri, varoluşçu düşünce, absürdizm ve insanın anlamsızlığı gibi felsefi konuları ele alır. 'Yabancı' ve 'Düşüş' gibi eserleriyle tanınır.",
                AuthorImage = "https://picsum.photos/400?id=15",
                AuthorCountryID = 2,
                AuthorCityID = 83,
            });



            //Turkish Authors
            authors.Add(new Author()
            {
                ID = 16,
                AuthorName = "Orhan",
                AuthorSurname = "Pamuk",
                AuthorBiography = "Orhan Pamuk, (d. 7 Haziran 1952, İstanbul), Nobel ödüllü Türk yazar. Romanlarında ve eserlerinde İstanbul'u, Türkiye'nin toplumsal ve siyasal değişimini ve karmaşık kimliğini temaları arasında işlemiştir.",
                AuthorImage = "https://picsum.photos/400?id=16",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 17,
                AuthorName = "Elif",
                AuthorSurname = "Şafak",
                AuthorBiography = "Elif Şafak, (d. 25 Ekim 1971, Strasbourg, Fransa), Türk yazar. Genellikle toplumsal ve kadın hakları temaları işlemektedir. Eserleri çok sayıda dile çevrilmiştir ve uluslararası alanda tanınmaktadır.",
                AuthorImage = "https://picsum.photos/400?id=17",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 18,
                AuthorName = "Ahmet Hamdi",
                AuthorSurname = "Tanpınar",
                AuthorBiography = "Ahmet Hamdi Tanpınar, (d. 23 Haziran 1901, İstanbul - ö. 24 Ocak 1962, İstanbul), Türk edebiyatının önemli yazarlarından ve edebiyat kuramcılarından biridir. Romanları, öyküleri, denemeleri, eleştirileri, tarihî ve kültürel konuları işleyen eserleri ile tanınır.",
                AuthorImage = "https://picsum.photos/400?id=18",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 19,
                AuthorName = "Yaşar",
                AuthorSurname = "Kemal",
                AuthorBiography = "Yaşar Kemal, (d. 6 Ekim 1923, Hemite / Osmaniye - ö. 28 Şubat 2015, İstanbul), Türk yazar. Romanları ve öyküleri ile tanınmaktadır. Eserlerinde Anadolu'nun köy yaşamını, toplumsal sorunlarını ve doğayı anlatmıştır.",
                AuthorImage = "https://picsum.photos/400?id=19",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 20,
                AuthorName = "Nazım",
                AuthorSurname = "Hikmet",
                AuthorBiography = "Nazım Hikmet Ran, (d. 20 Ocak 1902, Selanik - ö. 3 Haziran 1963, Moskova), Türk şair, oyun yazarı ve romancı. Eserleri arasında toplumcu gerçekçi tarzıyla öne çıkan şiirleri ve tiyatro oyunları bulunmaktadır. Türkiye'nin en önemli şairlerinden biridir.",
                AuthorImage = "https://picsum.photos/400?id=20",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 21,
                AuthorName = "Halide",
                AuthorSurname = "Edip",
                AuthorBiography = "Halide Edip Adıvar, (d. 1884, İstanbul - ö. 1964, İstanbul), Türk yazar, siyasetçi ve eğitimcidir. Eserlerinde toplumsal ve kadın sorunlarını işlemiştir. Romanları ve tarihî eserleriyle tanınır.",
                AuthorImage = "https://picsum.photos/400?id=21",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 22,
                AuthorName = "Cemal",
                AuthorSurname = "Süreya",
                AuthorBiography = "Cemal Süreya, (d. 1931, Erzincan - ö. 1990, İstanbul), Türk şair, yazar ve çevirmen. Modern Türk şiirinin önemli isimlerindendir. İronik, duygusal ve aşk temalı şiirleri ile tanınır.",
                AuthorImage = "https://picsum.photos/400?id=22",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 23,
                AuthorName = "Adalet",
                AuthorSurname = "Ağaoğlu",
                AuthorBiography = "Adalet Ağaoğlu, (d. 23 Ekim 1929, Nallıhan, Ankara - ö. 14 Temmuz 2020, İstanbul), Türk yazar ve oyun yazarı. Edebiyat alanında çeşitli türlerde eserler vermiştir. Romanları, öyküleri ve tiyatro oyunları ile tanınır.",
                AuthorImage = "https://picsum.photos/400?id=23",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 24,
                AuthorName = "Atilla",
                AuthorSurname = "İlhan",
                AuthorBiography = "Atilla İlhan, (d. 15 Haziran 1925, Menemen - ö. 10 Ekim 2005, İstanbul), Türk şair, yazar ve gazetecidir. Edebiyat alanında şiirler, romanlar, oyunlar ve denemeler yazmıştır. Türk edebiyatında önemli bir isimdir.",
                AuthorImage = "https://picsum.photos/400?id=24",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 25,
                AuthorName = "Ahmet",
                AuthorSurname = "Ümit",
                AuthorBiography = "Ahmet Ümit, (d. 1 Temmuz 1960, Gaziantep), Türk yazar, senarist ve gazetecidir. Romanları ve öyküleri ile tanınır. Eserlerinde genellikle polisiye ve tarihi temaları işlemiştir.",
                AuthorImage = "https://picsum.photos/400?id=25",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 26,
                AuthorName = "Nâzım",
                AuthorSurname = "Hikmet",
                AuthorBiography = "Nâzım Hikmet Ran, (d. 20 Ocak 1902, Selanik - ö. 3 Haziran 1963, Moskova), Türk şair, oyun yazarı ve romancı. Eserleri arasında toplumcu gerçekçi tarzıyla öne çıkan şiirleri ve tiyatro oyunları bulunmaktadır. Türkiye'nin en önemli şairlerinden biridir.",
                AuthorImage = "https://picsum.photos/400?id=26",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 27,
                AuthorName = "Ahmet",
                AuthorSurname = "Haşim",
                AuthorBiography = "Ahmet Haşim, (d. 20 Mart 1884, İstanbul - ö. 4 Haziran 1933, Göztepe, İstanbul), Türk şair ve yazar. İkinci Yeni akımının öncülerinden biridir. Şiirlerinde melankolik ve duygusal bir dil kullanmıştır.",
                AuthorImage = "https://picsum.photos/400?id=27",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 28,
                AuthorName = "Peyami",
                AuthorSurname = "Safa",
                AuthorBiography = "Peyami Safa, (d. 2 Nisan 1899, İstanbul - ö. 15 Haziran 1961, İstanbul), Türk yazar, gazeteci ve düşünür. Romanlarında toplumsal sorunları, psikolojik analizleri ve felsefi düşünceleri işlemiştir. Modern Türk romanının önemli isimlerinden biridir.",
                AuthorImage = "https://picsum.photos/400?id=28",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 29,
                AuthorName = "Sait",
                AuthorSurname = "Faik",
                AuthorBiography = "Sait Faik Abasıyanık, (d. 23 Kasım 1906, Adapazarı - ö. 11 Mayıs 1954, İstanbul), Türk yazar. Hikâyeleriyle tanınan Sait Faik, Türk edebiyatında özgün bir tarz oluşturmuş ve öykü türüne yeni bir soluk getirmiştir.",
                AuthorImage = "https://picsum.photos/400?id=29",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            authors.Add(new Author()
            {
                ID = 30,
                AuthorName = "Oğuz",
                AuthorSurname = "Atay",
                AuthorBiography = "Oğuz Atay, (d. 12 Ekim 1934, İnebolu - ö. 13 Aralık 1977, İstanbul), Türk yazar. Edebiyat alanında modernist bir yaklaşım sergilemiş ve postmodern Türk edebiyatının öncülerinden biri olarak kabul edilir. Romanlarıyla tanınır.",
                AuthorImage = "https://picsum.photos/400?id=30",
                AuthorCountryID = 1,
                AuthorCityID = 1,
            });

            #endregion


            context.Authors.AddRange(authors);


            IList<Publisher> publishers = new List<Publisher>();

            #region Publishers

            publishers.Add(new Publisher()
            {
                ID = 1,
                PublisherName = "Can Yayınları",
                PublisherDescription = "Can Yayınları, Erdal Öz tarafından 1981'de kurulan yayınevi. Kuruluşundan bu yana çocuk ve kültür&edebiyat kitapları yayımlamaktadır. Türk Edebiyatı, Çağdaş Dünya Edebiyatı, Klasikler, Modern Klasikler dizileri dışında çocuk kitapları, şiir, öykü, roman, biyografi ve denemeler yayınevinin yayıncılık alanıdır. Günümüzde Can Öz tarafından yönetilen yayınevinin merkezi Galatasaray'dadır.",
                PublisherAddress = "Iz Plaza Giz Maslak, Eski Büyükdere Cad. No:9 Kat:8",
                PublisherEmail = "yayinevi@canyayinlari.com",
                PublisherImage = "https://picsum.photos/400?id=1?id=1",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 2,
                PublisherName = "İletişim Yayınları",
                PublisherDescription = "İletişim Yayınları, 1982 yılında Ümit İnatçı tarafından kurulan bir yayınevidir. Türk ve dünya edebiyatının önemli eserlerini yayımlamaktadır. Siyaset, felsefe, sosyal bilimler, sanat ve edebiyat gibi çeşitli konularda kitaplar yayımlamaktadır.",
                PublisherAddress = "Tomtom Mahallesi İstiklal Caddesi No: 149",
                PublisherEmail = "iletisim@iletisim.com.tr",
                PublisherImage = "https://picsum.photos/400?id=1?id=2",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 3,
                PublisherName = "Doğan Kitap",
                PublisherDescription = "Doğan Kitap, Doğan Holding bünyesinde faaliyet gösteren bir yayınevidir. Türk ve yabancı yazarların eserlerini yayımlamaktadır. Roman, tarih, biyografi, kişisel gelişim, çocuk kitapları gibi farklı kategorilerde kitaplar sunmaktadır.",
                PublisherAddress = "Nispetiye Caddesi Akmerkez E3 Blok No:1/40 Beşiktaş",
                PublisherEmail = "kitap@doganburda.com",
                PublisherImage = "https://picsum.photos/400?id=1?id=3",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 4,
                PublisherName = "Everest Yayınları",
                PublisherDescription = "Everest Yayınları, 1990 yılında Türker İnanoğlu tarafından kurulan bir yayınevidir. Edebiyat, çocuk edebiyatı, tarih, siyaset, felsefe, psikoloji gibi çeşitli alanlarda kitaplar yayımlamaktadır. Yerli ve yabancı yazarların eserlerini okurlarla buluşturmaktadır.",
                PublisherAddress = "Feyzullah Mahallesi Meşrutiyet Caddesi No:19 Şişli",
                PublisherEmail = "iletisim@everestyayinlari.com",
                PublisherImage = "https://picsum.photos/400?id=1?id=4",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 5,
                PublisherName = "Yapı Kredi Yayınları",
                PublisherDescription = "Yapı Kredi Yayınları, 1944 yılında İstanbul'da kurulan bir yayınevidir. Türk ve dünya edebiyatının önemli eserlerini yayımlamaktadır. Aynı zamanda sanat, mimari, edebiyat eleştirisi, tarih, felsefe ve sosyal bilimler gibi konularda kitaplar da yayımlamaktadır.",
                PublisherAddress = "Yapı Kredi Kültür Sanat Yayıncılık A.Ş., Yapı Kredi Plaza C Blok, 34330 Levent",
                PublisherEmail = "iletisim@ykykultur.com.tr",
                PublisherImage = "https://picsum.photos/400?id=1?id=5",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 6,
                PublisherName = "İş Bankası Kültür Yayınları",
                PublisherDescription = "İş Bankası Kültür Yayınları, Türkiye İş Bankası'nın kültür alanında faaliyet gösteren yayınevidir. Türk ve dünya edebiyatının önemli eserlerini yayımlamaktadır. Ayrıca tarih, felsefe, sanat, müzik, sinema, psikoloji gibi konularda da kitaplar sunmaktadır.",
                PublisherAddress = "İş Kuleleri Kule 3 Levent",
                PublisherEmail = "kulturyayinlari@isbank.com.tr",
                PublisherImage = "https://picsum.photos/400?id=1?id=6",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 7,
                PublisherName = "Sel Yayıncılık",
                PublisherDescription = "Sel Yayıncılık, 1991 yılında Niyazi Sel tarafından kurulan bir yayınevidir. Edebiyat, felsefe, sosyal bilimler, sanat, kültür ve tarih gibi konularda kitaplar yayımlamaktadır. Özellikle Türk edebiyatına katkı sağlayan eserleriyle tanınmaktadır.",
                PublisherAddress = "Caferağa Mahallesi, Albay İmran Caddesi No:11 Kadıköy",
                PublisherEmail = "iletisim@selyayincilik.com",
                PublisherImage = "https://picsum.photos/400?id=1?id=7",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 8,
                PublisherName = "Kırmızı Kedi Yayınevi",
                PublisherDescription = "Kırmızı Kedi Yayınevi, 2009 yılında Ayşe Buğra ve Kaan Arslan tarafından kurulan bir yayınevidir. Sosyal bilimler, politika, felsefe, edebiyat ve çocuk kitapları gibi çeşitli alanlarda kitaplar yayımlamaktadır. Yayınevi aynı zamanda Türkçe'ye çeviri eserler de sunmaktadır.",
                PublisherAddress = "Serdar-ı Ekrem Caddesi, Çavuşbey Sokak No:26/A Beyoğlu",
                PublisherEmail = "iletisim@kirmizikedi.com",
                PublisherImage = "https://picsum.photos/400?id=1?id=8",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 9,
                PublisherName = "Can Yayınları",
                PublisherDescription = "Can Yayınları, Erdal Öz tarafından 1981'de kurulan yayınevi. Kuruluşundan bu yana çocuk ve kültür&edebiyat kitapları yayımlamaktadır. Türk Edebiyatı, Çağdaş Dünya Edebiyatı, Klasikler, Modern Klasikler dizileri dışında çocuk kitapları, şiir, öykü, roman, biyografi ve denemeler yayınevinin yayıncılık alanıdır. Günümüzde Can Öz tarafından yönetilen yayınevinin merkezi Galatasaray'dadır.",
                PublisherAddress = "Iz Plaza Giz Maslak, Eski Büyükdere Cad. No:9 Kat:8",
                PublisherEmail = "yayinevi@canyayinlari.com",
                PublisherImage = "https://picsum.photos/400?id=1?id=9",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 10,
                PublisherName = "İletişim Yayınları",
                PublisherDescription = "İletişim Yayınları, 1982 yılında Ümit İnatçı tarafından kurulan bir yayınevidir. Türk ve dünya edebiyatının önemli eserlerini yayımlamaktadır. Siyaset, felsefe, sosyal bilimler, sanat ve edebiyat gibi çeşitli konularda kitaplar yayımlamaktadır.",
                PublisherAddress = "Tomtom Mahallesi İstiklal Caddesi No: 149",
                PublisherEmail = "iletisim@iletisim.com.tr",
                PublisherImage = "https://picsum.photos/400?id=1?id=10",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 11,
                PublisherName = "Doğan Kitap",
                PublisherDescription = "Doğan Kitap, Doğan Holding bünyesinde faaliyet gösteren bir yayınevidir. Türk ve yabancı yazarların eserlerini yayımlamaktadır. Roman, tarih, biyografi, kişisel gelişim, çocuk kitapları gibi farklı kategorilerde kitaplar sunmaktadır.",
                PublisherAddress = "Nispetiye Caddesi Akmerkez E3 Blok No:1/40 Beşiktaş",
                PublisherEmail = "kitap@doganburda.com",
                PublisherImage = "https://picsum.photos/400?id=1?id=11",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 12,
                PublisherName = "Everest Yayınları",
                PublisherDescription = "Everest Yayınları, 1990 yılında Türker İnanoğlu tarafından kurulan bir yayınevidir. Edebiyat, çocuk edebiyatı, tarih, siyaset, felsefe, psikoloji gibi çeşitli alanlarda kitaplar yayımlamaktadır. Yerli ve yabancı yazarların eserlerini okurlarla buluşturmaktadır.",
                PublisherAddress = "Feyzullah Mahallesi Meşrutiyet Caddesi No:19 Şişli",
                PublisherEmail = "iletisim@everestyayinlari.com",
                PublisherImage = "https://picsum.photos/400?id=1?id=12",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 13,
                PublisherName = "Yapı Kredi Yayınları",
                PublisherDescription = "Yapı Kredi Yayınları, 1944 yılında İstanbul'da kurulan bir yayınevidir. Türk ve dünya edebiyatının önemli eserlerini yayımlamaktadır. Aynı zamanda sanat, mimari, edebiyat eleştirisi, tarih, felsefe ve sosyal bilimler gibi konularda kitaplar da yayımlamaktadır.",
                PublisherAddress = "Yapı Kredi Kültür Sanat Yayıncılık A.Ş., Yapı Kredi Plaza C Blok, 34330 Levent",
                PublisherEmail = "iletisim@ykykultur.com.tr",
                PublisherImage = "https://picsum.photos/400?id=1?id=13",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 14,
                PublisherName = "İş Bankası Kültür Yayınları",
                PublisherDescription = "İş Bankası Kültür Yayınları, Türkiye İş Bankası'nın kültür alanında faaliyet gösteren yayınevidir. Türk ve dünya edebiyatının önemli eserlerini yayımlamaktadır. Ayrıca tarih, felsefe, sanat, müzik, sinema, psikoloji gibi konularda da kitaplar sunmaktadır.",
                PublisherAddress = "İş Kuleleri Kule 3 Levent",
                PublisherEmail = "kulturyayinlari@isbank.com.tr",
                PublisherImage = "https://picsum.photos/400?id=14",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });

            publishers.Add(new Publisher()
            {
                ID = 15,
                PublisherName = "Sel Yayıncılık",
                PublisherDescription = "Sel Yayıncılık, 1991 yılında Niyazi Sel tarafından kurulan bir yayınevidir. Edebiyat, felsefe, sosyal bilimler, sanat, kültür ve tarih gibi konularda kitaplar yayımlamaktadır. Özellikle Türk edebiyatına katkı sağlayan eserleriyle tanınmaktadır.",
                PublisherAddress = "Caferağa Mahallesi, Albay İmran Caddesi No:11 Kadıköy",
                PublisherEmail = "iletisim@selyayincilik.com",
                PublisherImage = "https://picsum.photos/400?id=15",
                PublisherCountryID = 1,
                PublisherCityID = 1,
            });


            #endregion

            context.Publishers.AddRange(publishers);

            IList<BookTranslator> bookTranslators = new List<BookTranslator>();

            #region BookTranslators
            bookTranslators.Add(new BookTranslator()
            {
                ID = 1,
                TranslatorName = "Banu",
                TranslatorSurname = "Karakaş",
                TranslatorBiography = "1987’de İstanbul’da doğdu. 2005-2013 yılları arasında Boğaziçi Üniversitesi’nde felsefe, yabancı diller ve sinema çalışmaları alanlarında eğitim aldı. 2006 yılından bu yana dil çalışmalarıyla ilgileniyor, ağırlıklı olarak İspanyolca, İngilizce ve Türkçe dilleri arasında çeviri yapıyor. Karakaş, 2015 yılından beri Latin Amerika’da yaşıyor ve bölge edebiyatı konusunda danışmanlık yapıyor. Çevirdiği eserlerden bazıları: Düşlerimin Sınırı Olmayacak (Ernesto Che Guevara, Alfa Kitap), Yazma Uğraşı (Peter Clark, Metropolis Kitap), Solcu Futbolcular (Quique Peinado, Yazılama Yayınevi), Denemeler (David Hume, Pinhan Yayıncılık).",
                TranslatorImage = "https://www.banukarakas.com/wp-content/uploads/elementor/thumbs/banukarakas-po15ow3uwpquwkf2sh8ui3bgqhik7m7aoer0iltil4.png",
                TranslatorCountryID = 1,
                TranslatorCityID = 1,
            });
            bookTranslators.Add(new BookTranslator()
            {
                ID = 2,
                TranslatorName = "Ali",
                TranslatorSurname = "Demir",
                TranslatorBiography = "Ali Demir, İzmir doğumlu bir çevirmen ve yazardır. Almanca ve Türkçe dilleri arasında çeviri yapmaktadır. Edebiyat alanında birçok önemli eseri Türkçeye kazandırmıştır. Çevirdiği eserler arasında Sonsuzluğun Sonu (Michael Ende, Can Yayınları), Dönüşüm (Franz Kafka, İletişim Yayınları), Kırmızı Pazartesi (Gabriel Garcia Marquez, Doğan Kitap) bulunmaktadır.",
                TranslatorImage = "https://picsum.photos/400?id=1?id=1",
                TranslatorCountryID = 1,
                TranslatorCityID = 1,
            });

            bookTranslators.Add(new BookTranslator()
            {
                ID = 3,
                TranslatorName = "Ayşe",
                TranslatorSurname = "Kaya",
                TranslatorBiography = "Ayşe Kaya, İstanbul doğumlu bir çevirmen ve yazardır. İngilizce ve Almanca dilleri arasında çeviri yapmaktadır. Edebiyat alanında çeşitli ödüller kazanmıştır. Çevirdiği eserler arasında Gece Yolculuğu (Javier Marías, XYZ Yayınevi), Kayıp Zamanın İzinde (Marcel Proust, YKY), Yabancı (Albert Camus, Can Yayınları) bulunmaktadır.",
                TranslatorImage = "https://picsum.photos/400?id=1?id=2",
                TranslatorCountryID = 1,
                TranslatorCityID = 1,
            });

            bookTranslators.Add(new BookTranslator()
            {
                ID = 4,
                TranslatorName = "Mehmet",
                TranslatorSurname = "Yılmaz",
                TranslatorBiography = "Mehmet Yılmaz, Ankara doğumlu bir çevirmen ve dil bilimcidir. Fransızca, İngilizce ve Türkçe dilleri arasında çeviriler yapmaktadır. 2010 yılında Boğaziçi Üniversitesi'nden mezun oldu ve çeviri alanında çeşitli projelere katıldı. Çevirdiği eserler arasında Le Comte de Monte Cristo (Alexandre Dumas, İthaki Yayınları) ve The Catcher in the Rye (J.D. Salinger, Can Yayınları) bulunmaktadır.",
                TranslatorImage = "https://picsum.photos/400?id=3",
                TranslatorCountryID = 1,
                TranslatorCityID = 1,
            });

            #endregion

            context.BookTranslators.AddRange(bookTranslators);


            IList<Department> departmentList = new List<Department>();

            #region Departments    
            departmentList.Add(new Department()
            {
                ID = 1,
                DepartmentName = "Yönetici",

            });
            departmentList.Add(new Department()
            {
                ID = 2,
                DepartmentName = "Editör",

            });
            departmentList.Add(new Department()
            {
                ID = 3,
                DepartmentName = "Satış Temsilcisi",

            });
            #endregion

            context.Departments.AddRange(departmentList);



            IList<Employee> employeeList = new List<Employee>();

            #region Employees
            employeeList.Add(new Employee()
            {
                ID = 1,
                Name = "Muhammet Ali",
                Surname = "Songur",
                Email = "songur@gmail.com",
                Password = "123",
                Status = true,
                EmployeeImage = "https://picsum.photos/400?id=1?id=0",
                DepartmentID = 1,
            });
            employeeList.Add(new Employee()
            {
                ID = 2,
                Name = "Mehmet",
                Surname = "Yılmaz",
                Email = "yilmaz@gmail.com",
                Password = "123",
                Status = true,
                EmployeeImage = "https://picsum.photos/400?id=1?id=1",
                DepartmentID = 2,
            });
            employeeList.Add(new Employee()
            {
                ID = 3,
                Name = "Ayşe",
                Surname = "Kaya",
                Email = "kaya@gmail.com",
                Password = "123",
                Status = true,
                EmployeeImage = "https://picsum.photos/400?id=1?id=2",
                DepartmentID = 3,
            });
            employeeList.Add(new Employee()
            {
                ID = 4,
                Name = "Ali",
                Surname = "Demir",
                Email = "demir@gmail.com",
                Password = "123",
                Status = true,
                EmployeeImage = "https://picsum.photos/400?id=1?id=3",
                DepartmentID = 2,
            });
            #endregion

            context.Employees.AddRange(employeeList);


            IList<Book> bookList = new List<Book>();

            #region Books
            bookList.Add(new Book
            {
                ID = 1,
                BookName = "Sefiller",
                BookDescription = "Sefiller, Fransız yazar Victor Hugo'nun 1862 yılında yayımlanan romanıdır. Fransız Devrimi'nden sonra geçen roman, 19. yüzyıl Fransa'sının sosyal ve siyasi yapısını anlatır. Romanın ana karakteri Jean Valjean, 19 yıl hapis yattıktan sonra şartlı tahliye ile serbest bırakılır. Ancak, toplum onu hâlâ bir suçlu olarak görür. Bu yüzden Valjean, kendisine yeni bir hayat kurmakta zorlanır. Bu sırada, Valjean'ın hayatını değiştirecek bir olay yaşanır. Valjean, bir piskopos tarafından kurtarılır ve onun sayesinde yeni bir hayata başlar. Ancak, Valjean'ın peşindeki polis müfettişi Javert, onu yakalamak için her şeyi yapacaktır.",
                BookImage = "https://picsum.photos/400?id=1",
                BookPage = 1000,
                BookPrice = 50,
                BookPublisherID = 1,
                BookCategoryID = 1,
                BookAuthorID = 1,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 100,
                BookISBN = "9789750728955",
            });

            bookList.Add(new Book
            {
                ID = 2,
                BookName = "Sherlock Holmes",
                BookDescription = "Sherlock Holmes, Sir Arthur Conan Doyle tarafından yaratılan kurgusal bir karakterdir. İlk olarak 1887 yılında A Study in Scarlet adlı romanda yer almıştır. Sherlock Holmes, 221B Baker Street adresinde yaşayan, kendi adını taşıyan dedektiflik bürosunda çalışan bir dedektiftir. Sherlock Holmes, olayları çözümleme ve gözlemleme yeteneğiyle tanınır. Ayrıca, kimya, anatomiyi de iyi bilir. Sherlock Holmes, birçok olayı çözmüştür. Bunlardan bazıları; Kızıl Dosya, Baskerville Köpeği, Son Vaka, Boş Ev, Altın P",
                BookImage = "https://picsum.photos/400?id=2",
                BookPage = 1000,
                BookPrice = 50,
                BookPublisherID = 1,
                BookCategoryID = 1,
                BookAuthorID = 1,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 100,
                BookISBN = "9789750728955",
            });

            bookList.Add(new Book
            {
                ID = 3,
                BookName = "Cesur Yeni Dünya",
                BookDescription = "Cesur Yeni Dünya, Aldous Huxley tarafından yazılan ve ilk olarak 1932 yılında yayımlanan distopya türündeki roman. Huxley, romanı yazarken, H.G. Wells'in Dünyalar Savaşı adlı romanından etkilenmiştir. Roman, 26. yüzyılda geçer. İnsanlar, kendi kaderlerini tayin etme özgürlüğünden vazgeçmişlerdir. İnsanlar, doğumdan itibaren kendi kaderlerini tayin eden bir sisteme göre yetiştirilirler. Bu sistem, insanları 5 farklı kastta yetiştirir. Bu kastlar; Alfa, Beta, Gama, Delta ve Epsilon'dur. Alfa, en üst kasttır. Epsilon ise en alt kasttır. Romanın ana karakteri Bernard Marx, bir Alfa'dır. Ancak, fiziksel olarak diğer Alfa'lardan farklıdır. Bu yüzden, diğer Alfa'lar tarafından dışlanır. Bernard Marx, bu durumdan rahatsızdır. Bu yüzden, bir yolculuğa çıkar. Bu yolculukta, John adında biriyle tanışır. John, bir rezervde yaşamaktadır. Bernard Marx, John'u getirir ve onu insanların arasına bırakır. Ancak, John, bu durumdan rahatsız olur. Çünkü, insanların yaşam tarzı ona göre değildir. Bu yüzden, John, intihar eder.",
                BookImage = "https://picsum.photos/400?id=3",
                BookPage = 1000,
                BookPrice = 50,
                BookPublisherID = 1,
                BookCategoryID = 1,
                BookAuthorID = 1,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 100,
                BookISBN = "9789750728955",
            });


            bookList.Add(new Book
            {
                ID = 4,
                BookName = "Sefiller",
                BookDescription = "Sefiller, Fransız yazar Victor Hugo'nun 1862 yılında yayımlanan romanıdır. Fransız Devrimi'nden sonra geçen roman, 19. yüzyıl Fransa'sının sosyal ve siyasi yapısını anlatır. Romanın ana karakteri Jean Valjean, 19 yıl hapis yattıktan sonra şartlı tahliye ile serbest bırakılır. Ancak, toplum onu hâlâ bir suçlu olarak görür. Bu yüzden Valjean, kendisine yeni bir hayat kurmakta zorlanır. Bu sırada, Valjean'ın hayatını değiştirecek bir olay yaşanır. Valjean, bir piskopos tarafından kurtarılır ve onun sayesinde yeni bir hayata başlar. Ancak, Valjean'ın peşindeki polis müfettişi Javert, onu yakalamak için her şeyi yapacaktır.",
                BookImage = "https://picsum.photos/400?id=4",
                BookPage = 1000,
                BookPrice = 50,
                BookPublisherID = 1,
                BookCategoryID = 1,
                BookAuthorID = 1,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 100,
                BookISBN = "9789750728955",
            });
            bookList.Add(new Book
            {
                ID = 5,
                BookName = "Pride and Prejudice",
                BookDescription = "Pride and Prejudice is a novel by Jane Austen published in 1813. The story follows the romantic entanglements of the Bennet sisters, particularly the strong-willed Elizabeth Bennet and the wealthy, aloof Mr. Darcy. The novel explores themes of love, class, and societal expectations.",
                BookImage = "https://picsum.photos/400?id=5",
                BookPage = 432,
                BookPrice = 30,
                BookPublisherID = 2,
                BookCategoryID = 2,
                BookAuthorID = 2,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 150,
                BookISBN = "9781503290563",
            });
            bookList.Add(new Book
            {
                ID = 6,
                BookName = "1984",
                BookDescription = "1984 is a dystopian novel by George Orwell published in 1949. It is set in a totalitarian society where the government, led by Big Brother, exercises total control over every aspect of people's lives. The novel explores themes of surveillance, propaganda, and the loss of individuality.",
                BookImage = "https://picsum.photos/400?id=6",
                BookPage = 328,
                BookPrice = 25,
                BookPublisherID = 3,
                BookCategoryID = 4,
                BookAuthorID = 3,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 120,
                BookISBN = "9780451524935",
            });

            bookList.Add(new Book
            {
                ID = 7,
                BookName = "The Great Gatsby",
                BookDescription = "The Great Gatsby is a novel by American writer F. Scott Fitzgerald. Set in the Roaring Twenties, the novel tells the story of the mysterious millionaire Jay Gatsby and his obsession with the beautiful Daisy Buchanan. It explores themes of wealth, love, and the American Dream.",
                BookImage = "https://picsum.photos/400?id=7",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookCategoryID = 3,
                BookAuthorID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273565",
            });

            bookList.Add(new Book
            {
                ID = 8,
                BookName = "To Kill a Mockingbird",
                BookDescription = "To Kill a Mockingbird is a novel by Harper Lee published in 1960. Set in the American South during the Great Depression, the story follows young Scout Finch as she learns about racial injustice and moral growth. Her father, Atticus Finch, is a lawyer who defends an African American man accused of raping a white woman.",
                BookImage = "https://picsum.photos/400?id=8",
                BookPage = 281,
                BookPrice = 40,
                BookPublisherID = 5,
                BookCategoryID = 2,
                BookAuthorID = 5,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 90,
                BookISBN = "9780061120084",
            });
            bookList.Add(new Book
            {
                ID = 9,
                BookName = "Harry Potter and the Sorcerer's Stone",
                BookDescription = "Harry Potter and the Sorcerer's Stone is the first book in the Harry Potter series written by J.K. Rowling. It follows the journey of a young wizard, Harry Potter, as he discovers his magical heritage and attends Hogwarts School of Witchcraft and Wizardry. Harry learns about friendship, courage, and the battle between good and evil.",
                BookImage = "https://picsum.photos/400?id=9",
                BookPage = 320,
                BookPrice = 45,
                BookPublisherID = 6,
                BookCategoryID = 5,
                BookAuthorID = 6,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 200,
                BookISBN = "9780590353427",
            });
            bookList.Add(new Book
            {
                ID = 10,
                BookName = "The Catcher in the Rye",
                BookDescription = "The Catcher in the Rye is a novel by J.D. Salinger published in 1951. It follows the experiences of Holden Caulfield, a disaffected teenager who leaves his prep school and explores the complexities of adolescence and identity. The book has become a classic of modern literature.",
                BookImage = "https://picsum.photos/400?id=10",
                BookPage = 224,
                BookPrice = 28,
                BookPublisherID = 7,
                BookCategoryID = 3,
                BookAuthorID = 7,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 110,
                BookISBN = "9780316769488",
            });
            bookList.Add(new Book
            {
                ID = 11,
                BookName = "The Lord of the Rings: The Fellowship of the Ring",
                BookDescription = "The Fellowship of the Ring is the first volume of J.R.R. Tolkien's epic fantasy novel, The Lord of the Rings. It follows the journey of a hobbit named Frodo Baggins as he sets out to destroy a powerful ring that could bring darkness to the world. He is accompanied by a diverse group of companions known as the Fellowship of the Ring.",
                BookImage = "https://picsum.photos/400?id=11",
                BookPage = 432,
                BookPrice = 55,
                BookPublisherID = 8,
                BookCategoryID = 5,
                BookAuthorID = 8,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 75,
                BookISBN = "9780618346257",
            });
            bookList.Add(new Book
            {
                ID = 12,
                BookName = "Crime and Punishment",
                BookDescription = "Crime and Punishment is a novel by Fyodor Dostoevsky first published in 1866. It tells the story of Rodion Raskolnikov, a poor ex-student in Saint Petersburg who commits a heinous crime and grapples with his guilt and the moral consequences of his actions. The novel explores themes of redemption and the nature of evil.",
                BookImage = "https://picsum.photos/400?id=12",
                BookPage = 576,
                BookPrice = 38,
                BookPublisherID = 9,
                BookCategoryID = 4,
                BookAuthorID = 9,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 95,
                BookISBN = "9780140449136",
            });
            bookList.Add(new Book
            {
                ID = 13,
                BookName = "Brave New World",
                BookDescription = "Brave New World is a dystopian novel by Aldous Huxley published in 1932. It is set in a futuristic society where people are genetically engineered and conditioned to be content with their roles in society. The novel explores themes of conformity, technology, and the cost of progress.",
                BookImage = "https://picsum.photos/400?id=13",
                BookPage = 288,
                BookPrice = 33,
                BookPublisherID = 10,
                BookCategoryID = 4,
                BookAuthorID = 10,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 70,
                BookISBN = "9780060850524",
            });
            bookList.Add(new Book
            {
                ID = 14,
                BookName = "Harry Potter",
                BookDescription = "Harry Potter is a series of fantasy novels written by British author J.K. Rowling. The books chronicle the adventures of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry. The main story arc concerns Harry's struggle against Lord Voldemort, a dark wizard who intends to become immortal, overthrow the wizard governing body known as the Ministry of Magic, and subjugate all wizards and Muggles (non-magical people).",
                BookImage = "https://picsum.photos/400?id=14",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookCategoryID = 3,
                BookAuthorID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273565",

            });

            bookList.Add(new Book
            {
                ID = 15,
                BookName = "Kürk Mantolu Madonna",
                BookDescription = "Kürk Mantolu Madonna, Sabahattin Ali'nin 1943 yılında yayımlanan romanıdır. Roman, 1940'lı yıllarda İstanbul'da yaşayan Raif Efendi'nin, İtalya'da bir tren yolculuğu sırasında tanıştığı Maria Puder ile yaşadığı aşkı konu edinir. Romanın adı, Maria Puder'in Raif Efendi'ye hediye ettiği kürk mantoya atıfta bulunur.",
                BookImage = "https://picsum.photos/400?id=15",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookCategoryID = 3,
                BookAuthorID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273563",
            });
            bookList.Add(new Book
            {
                ID = 16,
                BookName = "Simyacı",
                BookDescription = "Simyacı, Paulo Coelho'nun 1988 yılında yayımlanan romanıdır. Kitap, Santiago adlı bir Endülüslü çobanın, Mısır'da Piramitler'de gördüğü rüyayı yorumlamak için yaptığı yolculuğu konu edinir. Kitap, 1993 yılında Türkiye'de de yayımlanmıştır.",
                BookImage = "https://picsum.photos/400?id=16",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookCategoryID = 3,
                BookAuthorID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273562",
            });
            bookList.Add(new Book
            {
                ID = 17,
                BookName = "Şeker Portakalı",
                BookDescription = "Şeker Portakalı, Brezilyalı yazar José Mauro de Vasconcelos'un 1968 yılında yayımlanan romanıdır. Roman, küçük bir çocuğun, Portekiz'den Brezilya'ya göç etmesiyle başlayan hikâyesini konu edinir. Roman, 1970'li yıllarda Türkiye'de de yayımlanmıştır.",
                BookImage = "https://picsum.photos/400?id=17",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookCategoryID = 3,
                BookAuthorID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273561",
            });

            bookList.Add(new Book
            {
                ID = 18,
                BookName = "Dönüşüm",
                BookDescription = "Dönüşüm, Franz Kafka'nın 1915 yılında yayımlanan öyküsüdür. Öykü, Gregor Samsa adlı bir seyyar satıcının bir sabah kendini dev bir böceğe dönüşmüş olarak bulmasıyla başlar. Öykü, 1925 yılında Türkiye'de de yayımlanmıştır.",
                BookImage = "https://picsum.photos/400?id=18",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookCategoryID = 3,
                BookAuthorID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273560",

            });

            bookList.Add(new Book
            {
                ID = 19,
                BookName = "Sineklerin Tanrısı",
                BookDescription = "Sineklerin Tanrısı, William Golding'in 1954 yılında yayımlanan romanıdır. Roman, bir grup İngiliz çocuğun, bir uçak kazasının ardından ıssız bir adaya düşmesiyle başlar. Roman, 1960'lı yıllarda Türkiye'de de yayımlanmıştır.",
                BookImage = "https://picsum.photos/400?id=19",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookCategoryID = 3,
                BookAuthorID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273569",
            });
            bookList.Add(new Book
            {
                ID = 20,
                BookName = "Küçük Prens",
                BookDescription = "Küçük Prens, Antoine de Saint-Exupéry'nin 1943 yılında yayımlanan romanıdır. Roman, bir pilotun Sahra Çölü'nde bir çocukla karşılaşmasıyla başlar. Roman, 1950'li yıllarda Türkiye'de de yayımlanmıştır.",
                BookImage = "https://picsum.photos/400?id=20",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookCategoryID = 3,
                BookAuthorID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273568",
            });

            bookList.Add(new Book
            {
                ID = 21,
                BookName = "Bir Ömür Nasıl Yaşanır?",
                BookDescription = "Bir Ömür Nasıl Yaşanır?, İlber Ortaylı'nın 2016 yılında yayımlanan deneme kitabıdır. Kitap, yazarın 2015 yılında verdiği bir konferansın metninden oluşur. Kitap, 2016 yılında Türkiye'de en çok satan kitaplar listesinde bir numaraya yükselmiştir.",
                BookImage = "https://picsum.photos/400?id=21",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookCategoryID = 4,
                BookAuthorID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273567",
            });

            bookList.Add(new Book
            {
                ID = 22,
                BookName = "Kayıp Tanrılar Ülkesinde",
                BookDescription = "Kayıp Tanrılar Ülkesinde, Ahmet Ümit'in 2016 yılında yayımlanan romanıdır. Roman, İstanbul'da yaşanan bir cinayetin ardından başlayan olayları konu edinir. Roman, 2016 yılında Türkiye'de en çok satan kitaplar listesinde ikinci sıraya yükselmiştir.",
                BookImage = "https://picsum.photos/400?id=22",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookAuthorID = 4,
                BookCategoryID = 4,
                BookTranslatorID = 2,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273566",
            });

            bookList.Add(new Book
            {
                ID = 23,
                BookName = "Ay'a Yolculuk",
                BookDescription = "Ay'a Yolculuk, Jules Verne'in 1865 yılında yayımlanan bilimkurgu romanıdır. Roman, bir grup Amerikalı'nın Ay'a yapacağı yolculuğu konu edinir. Roman, 1960'lı yıllarda Türkiye'de de yayımlanmıştır.",
                BookImage = "https://picsum.photos/400?id=23",
                BookPage = 320,
                BookPrice = 35,
                BookPublisherID = 4,
                BookAuthorID = 4,
                BookCategoryID = 4,
                BookTranslatorID = 2,
                BookStatus = true,
                BookStock = 80,
                BookISBN = "9780743273565",
            });

            bookList.Add(new Book
            {
                ID = 24,
                BookName = "Dune",
                BookDescription = "Dune is a science fiction novel by Frank Herbert, published in 1965. It is set in the distant future where noble families control planets and a valuable spice called melange is at the center of power struggles. The book explores themes of politics, religion, and environmentalism.",
                BookImage = "https://picsum.photos/400?id=24",
                BookPage = 688,
                BookPrice = 42,
                BookPublisherID = 5,
                BookAuthorID = 11,
                BookCategoryID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 90,
                BookISBN = "9780593099322",
            });

            bookList.Add(new Book
            {
                ID = 25,
                BookName = "The Picture of Dorian Gray",
                BookDescription = "The Picture of Dorian Gray is a novel by Oscar Wilde, published in 1890. It tells the story of a young man named Dorian Gray who sells his soul to keep his youthful appearance while a portrait of him ages instead. The novel explores themes of beauty, decadence, and morality.",
                BookImage = "https://picsum.photos/400?id=25",
                BookPage = 254,
                BookPrice = 28,
                BookPublisherID = 6,
                BookAuthorID = 12,
                BookCategoryID = 2,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 120,
                BookISBN = "9780486278070",
            });

            bookList.Add(new Book
            {
                ID = 26,
                BookName = "The Martian",
                BookDescription = "The Martian is a science fiction novel by Andy Weir, published in 2011. It follows the story of an astronaut stranded on Mars and his struggle for survival. The novel combines elements of adventure, science, and humor.",
                BookImage = "https://picsum.photos/400?id=26",
                BookPage = 369,
                BookPrice = 32,
                BookPublisherID = 7,
                BookAuthorID = 13,
                BookCategoryID = 4,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 100,
                BookISBN = "9780553418026",
            });

            bookList.Add(new Book
            {
                ID = 27,
                BookName = "The Alchemist",
                BookDescription = "The Alchemist is a novel by Paulo Coelho, first published in 1988. It tells the story of a young Andalusian shepherd named Santiago who goes on a journey to find a hidden treasure. The book explores themes of destiny, purpose, and the pursuit of dreams.",
                BookImage = "https://picsum.photos/400?id=27",
                BookPage = 208,
                BookPrice = 25,
                BookPublisherID = 8,
                BookAuthorID = 14,
                BookCategoryID = 2,
                BookTranslatorID = 3,
                BookStatus = true,
                BookStock = 85,
                BookISBN = "9780062315007",
            });

            bookList.Add(new Book
            {
                ID = 28,
                BookName = "The Handmaid's Tale",
                BookDescription = "The Handmaid's Tale is a dystopian novel by Margaret Atwood, published in 1985. It is set in the Republic of Gilead, a theocratic and totalitarian society where fertile women are forced to bear children for the ruling class. The novel explores themes of gender, power, and resistance.",
                BookImage = "https://picsum.photos/400?id=28",
                BookPage = 311,
                BookPrice = 30,
                BookPublisherID = 9,
                BookAuthorID = 15,
                BookCategoryID = 4,
                BookTranslatorID = 2,
                BookStatus = true,
                BookStock = 110,
                BookISBN = "9780385490818",
            });

            bookList.Add(new Book
            {
                ID = 29,
                BookName = "The Odyssey",
                BookDescription = "The Odyssey is an ancient Greek epic poem attributed to Homer, believed to have been composed in the 8th century BCE. It follows the journey of Odysseus, the king of Ithaca, as he returns home after the fall of Troy. The poem explores themes of heroism, temptation, and homecoming.",
                BookImage = "https://picsum.photos/400?id=29",
                BookPage = 416,
                BookPrice = 38,
                BookPublisherID = 10,
                BookAuthorID = 16,
                BookCategoryID = 1,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 95,
                BookISBN = "9780140268867",
            });

            bookList.Add(new Book
            {
                ID = 30,
                BookName = "Masumiyet Müzesi",
                BookDescription = "Masumiyet Müzesi, Orhan Pamuk'un 2008 yılında yayımlanan romanıdır. Roman, İstanbul'da yaşayan bir adamın, bir müzede sergilenen eşyaları toplayarak bir müze kurmasını konu edinir. Roman, 2008 yılında İngilizceye çevrilmiştir.",
                BookImage = "https://picsum.photos/400?id=30",
                BookPage = 728,
                BookPrice = 45,
                BookPublisherID = 11,
                BookAuthorID = 17,
                BookCategoryID = 2,
                BookTranslatorID = 1,
                BookStatus = true,
                BookStock = 100,
                BookISBN = "9789751019643",

            });





            #endregion

            context.Books.AddRange(bookList);


            base.Seed(context);
        }
    }
}
