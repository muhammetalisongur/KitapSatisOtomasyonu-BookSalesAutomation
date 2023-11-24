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
    public class PublisherManager : IPublisherService
    {
        private readonly IPublisherDal _publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }

        public void Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
        }

        public void Delete(Publisher publisher)
        {
            _publisherDal.Delete(publisher);
        }

        public List<Publisher> GetAll()
        {
            return _publisherDal.GetAll();
        }

        public Publisher GetById(int id)
        {
            return _publisherDal.GetById(x => x.ID == id);
        }

        public void Update(Publisher publisher)
        {
            _publisherDal.Update(publisher);
        }
    }
}
