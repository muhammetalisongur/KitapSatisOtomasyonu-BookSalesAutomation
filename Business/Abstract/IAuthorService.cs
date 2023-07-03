using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        List<Author> GetAll();
        Author GetById(int id);
        void Add(Author author);
        void Update(Author author);
        void Delete(Author author);


        //Task<IEnumerable<Author>> GetAllAuthorsWithAddress(int pageNo);

    }
}
