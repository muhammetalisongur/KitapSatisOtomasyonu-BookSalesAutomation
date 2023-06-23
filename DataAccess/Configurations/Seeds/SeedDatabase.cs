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
            countries.Add(new Country() { CountryName = "Türkiye" });
            countries.Add(new Country() { CountryName = "Amerika" });
            countries.Add(new Country() { CountryName = "Almanya" });
            countries.Add(new Country() { CountryName = "İngiltere" });
            countries.Add(new Country() { CountryName = "Fransa" });
            countries.Add(new Country() { CountryName = "İtalya" });
            countries.Add(new Country() { CountryName = "İspanya" });
            countries.Add(new Country() { CountryName = "Rusya" });
            countries.Add(new Country() { CountryName = "Çin" });

            context.Countries.AddRange(countries);

            IList<City> cities = new List<City>();
            //cities.Add(new City() { CityName = "İstanbul", CountryID = 1 });
            //cities.Add(new City() { CityName = "Ankara", CountryID = 1 });
            //cities.Add(new City() { CityName = "İzmir", CountryID = 1 });
            //cities.Add(new City() { CityName = "Adana", CountryID = 1 });
            //cities.Add(new City() { CityName = "Bursa", CountryID = 1 });

            context.Cities.AddRange(cities);

            IList<Category> categories = new List<Category>();
            categories.Add(new Category() { CategoryName = "Roman" });
            categories.Add(new Category() { CategoryName = "Hikaye" });
            categories.Add(new Category() { CategoryName = "Şiir" });
            categories.Add(new Category() { CategoryName = "Tiyatro" });
            categories.Add(new Category() { CategoryName = "Deneme" });
            categories.Add(new Category() { CategoryName = "Biyografi" });
            categories.Add(new Category() { CategoryName = "Gezi" });
            categories.Add(new Category() { CategoryName = "Bilim Kurgu" });
            categories.Add(new Category() { CategoryName = "Polisiye" });
            categories.Add(new Category() { CategoryName = "Aşk" });
            categories.Add(new Category() { CategoryName = "Tarih" });
            categories.Add(new Category() { CategoryName = "Felsefe" });
            categories.Add(new Category() { CategoryName = "Din" });
            categories.Add(new Category() { CategoryName = "Edebiyat" });
            categories.Add(new Category() { CategoryName = "Çocuk" });
            categories.Add(new Category() { CategoryName = "Psikoloji" });
            categories.Add(new Category() { CategoryName = "Sosyoloji" });
            categories.Add(new Category() { CategoryName = "Ekonomi" });
            categories.Add(new Category() { CategoryName = "Siyaset" });

            context.Categories.AddRange(categories);


            base.Seed(context);
        }
    }
}
