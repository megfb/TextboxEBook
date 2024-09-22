using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Abstract
{
    public interface IPublisherService
    {
        List<Publisher> GetAll();

        void Delete(int id);

        void Add(Publisher publisher);
        void Update(Publisher publisher);
        Publisher GetById(int id);
    }
}
