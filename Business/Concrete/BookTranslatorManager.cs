using Business.Abstract;
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
        private readonly IBookTranslatorService _bookTranslatorService;

        public BookTranslatorManager(IBookTranslatorService bookTranslatorService)
        {
            _bookTranslatorService = bookTranslatorService;
        }

        public void Add(BookTranslator translator)
        {
            _bookTranslatorService.Add(translator);
        }

        public void Delete(BookTranslator translator)
        {
            _bookTranslatorService.Delete(translator);
        }

        public List<BookTranslator> GetAll()
        {
            return _bookTranslatorService.GetAll();
        }

        public BookTranslator GetById(int id)
        {
            return _bookTranslatorService.GetById(id);
        }

        public void Update(BookTranslator translator)
        {
           _bookTranslatorService.Update(translator);
        }
    }
}
