using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookTranslatorManager : IBookTranslatorService
    {
       private readonly IBookTranslatorDal _bookTranslatorDal;

        public BookTranslatorManager(IBookTranslatorDal bookTranslatorDal)
        {
            _bookTranslatorDal = bookTranslatorDal;
        }

        public void Add(BookTranslator translator)
        {
            _bookTranslatorDal.Add(translator);
        }

        public void Delete(BookTranslator translator)
        {
            _bookTranslatorDal.Delete(translator);
        }

        public List<BookTranslator> GetAll()
        {
            return _bookTranslatorDal.GetAll();
        }

        public BookTranslator GetById(int id)
        {
            return _bookTranslatorDal.GetById(x=>x.ID == id);
        }

        public void Update(BookTranslator translator)
        {
            _bookTranslatorDal.Update(translator);
        }
    }
}
