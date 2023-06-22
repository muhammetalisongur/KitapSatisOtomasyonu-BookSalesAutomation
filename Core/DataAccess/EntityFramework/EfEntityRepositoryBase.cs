using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepostiory<TEntity>
        where TEntity : class, IEntity, new() //TEntity class olmalı , IEntity türünde olmalı , newlenebilmeli.

        where TContext : DbContext, new() //TContext DbContext türünde olmalı , newlenebilmeli 
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext()) //using içindeki context garbage collector yardımıyla belleği hızlıca temizler.Performans için yazdık.
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added; //ekle
                context.SaveChanges(); //kaydet
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted; //sil
                context.SaveChanges(); //kaydet
            }
        }

        public TEntity GetById(Func<TEntity, bool> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); //tek bir nesne döndürür.
            }
        }

        public List<TEntity> GetAll(Func<TEntity, bool> filter = null)
        {
            using(TContext context = new TContext())
            {

                //filter boş mu     EVET ise bütün datayı döndür           HAYIR ise filtreyi uygula 
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList(); //filter null ise ilk kısım çalışır değilse ikinci kısım çalışır.
            }
        }

        public void Update(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //referansı yakala
                updatedEntity.State = EntityState.Modified; //güncelle
                context.SaveChanges(); //kaydet
            }
        }
    }
}
