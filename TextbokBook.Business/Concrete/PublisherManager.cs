using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TextbokBook.Business.Abstract;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Concrete
{
    public class PublisherManager : IPublisherService
    {
        private IPublisherDal _publisherDal;
        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }

        public void Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
        }

        public void Delete(int id)
        {
            _publisherDal.Delete(new Publisher { Id = id });
        }

        public List<Publisher> GetAll()
        {
            return _publisherDal.GetAll();
        }

        public Publisher GetById(int id)
        {
            return _publisherDal.GetById(id);
        }

        public void Update(Publisher publisher)
        {
            _publisherDal.Update(publisher);
        }
    }
}
