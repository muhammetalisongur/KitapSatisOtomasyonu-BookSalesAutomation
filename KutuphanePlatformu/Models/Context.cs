using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KutuphanePlatformu.Models.EntityFramework
{
    public class Context : DbContext
    {
        public DbSet<Kategoriler> Kategoriler { get; set; }
        public DbSet<Kitaplar> Kitaplar { get; set; }
        public DbSet<Yazarlar> Yazarlar { get; set; }
        public DbSet<YayinEvleri> YayinEvleri { get; set; }
        public DbSet<Personeller> Personeller { get; set; }
        public DbSet<KitapHareketleri> KitapHareketleri { get; set; }
        public DbSet<Kasa> Kasa { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }
        public DbSet<Cezalar> Cezalar { get; set; }
    }

}