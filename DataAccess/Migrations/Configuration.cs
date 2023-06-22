namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.Concrete.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccess.Concrete.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            //Country
            context.Entry(new Entities.Concrete.Country { ID = 1, CountryName = "Türkiye" }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.Country { ID = 2, CountryName = "Amerika" }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.Country { ID = 3, CountryName = "Almanya" }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.Country { ID = 4, CountryName = "İngiltere" }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.Country { ID = 5, CountryName = "Fransa" }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.Country { ID = 6, CountryName = "İtalya" }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.Country { ID = 7, CountryName = "Çin" }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.Country { ID = 8, CountryName = "Japonya" }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.Country { ID = 9, CountryName = "Rusya" }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.Country { ID = 10, CountryName = "Hindistan" }).State = EntityState.Added;

            //City
            context.Entry(new Entities.Concrete.City { ID = 1, CityName = "Adana", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 2, CityName = "Adıyaman", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 3, CityName = "Afyonkarahisar", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 4, CityName = "Ağrı", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 5, CityName = "Amasya", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 6, CityName = "Ankara", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 7, CityName = "Antalya", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 8, CityName = "Artvin", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 9, CityName = "Aydın", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 10, CityName = "Balıkesir", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 11, CityName = "Bilecik", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 12, CityName = "Bingöl", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 13, CityName = "Bitlis", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 14, CityName = "Bolu", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 15, CityName = "Burdur", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 16, CityName = "Bursa", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 17, CityName = "Çanakkale", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 18, CityName = "Çankırı", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 19, CityName = "Çorum", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 20, CityName = "Denizli", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 21, CityName = "Diyarbakır", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 22, CityName = "Edirne", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 23, CityName = "Elazığ", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 24, CityName = "Erzincan", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 25, CityName = "Erzurum", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 26, CityName = "Eskişehir", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 27, CityName = "Gaziantep", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 28, CityName = "Giresun", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 29, CityName = "Gümüşhane", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 30, CityName = "Hakkâri", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 31, CityName = "Hatay", CountryID = 1 }).State = EntityState.Added;
            context.Entry(new Entities.Concrete.City { ID = 32, CityName = "Isparta", CountryID = 1 }).State = EntityState.Added;



        }
    }
}
