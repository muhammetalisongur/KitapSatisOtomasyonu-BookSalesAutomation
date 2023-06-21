using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Configurations.Seeds
{
    public class CountrySeed<T> : DropCreateDatabaseAlways<Context>
    {

        protected override void Seed(Context context)
        {
            IList<Country> countries = new List<Country>();

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


            foreach (Country country in countries)
                context.Countries.Add(country);


            //context.Countries.AddRange(countries);

            base.Seed(context);

        }
    }
}
