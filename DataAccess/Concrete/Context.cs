using DataAccess.Configurations.Seeds;
using DataAccess.Migrations;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context : DbContext
    {

        public Context() : base("name=Context")
        {


            //Database.SetInitializer(new CategorySeed<Context>());
            //Database.SetInitializer(new CountrySeed<Context>());
            //Database.SetInitializer(new CitySeed<Context>());

        }



        public DbSet<Author> Authors { get; set; } //hangi nesnem hangi nesneye karşılık gelecek
        public DbSet<Book> Books { get; set; }
        public DbSet<BookTranslator> BookTranslators { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasMany(i => i.Cities).WithRequired().WillCascadeOnDelete(false);

        }


    }
}
