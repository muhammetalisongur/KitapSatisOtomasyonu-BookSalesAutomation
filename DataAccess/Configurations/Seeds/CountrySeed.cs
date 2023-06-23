using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Configurations.Seeds
{
    public class CountrySeed : DropCreateDatabaseIfModelChanges<BookStoreContext>
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

        }
    }
}
