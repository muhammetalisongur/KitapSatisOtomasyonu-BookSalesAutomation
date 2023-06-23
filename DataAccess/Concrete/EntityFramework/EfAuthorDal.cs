using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAuthorDal : EfEntityRepositoryBase<Author, BookStoreContext>, IAuthorDal
    {
        public async Task<IEnumerable<Author>> GetAllAuthorsWithAddress(int pageNo)
        {
            using (var context = new BookStoreContext()) 
            {
                return await context.Authors
                       .Include(a => a.Country)
                       .Include(a => a.City)
                       .OrderBy(a => a.ID)
                       .Skip(pageNo * 5)
                       .Take(5)
                       .ToListAsync();
            }
        }
    }
}
