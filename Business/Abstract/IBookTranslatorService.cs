using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookTranslatorService
    {
        List<BookTranslator> GetAll();
        BookTranslator GetById(int id);
        void Add(BookTranslator translator);
        void Update(BookTranslator translator);
        void Delete(BookTranslator translator);
    }
}
