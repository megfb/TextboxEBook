using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        void Add(Category category);
        void Delete(int id);

        Category GetById(int id);

        void Update(Category category);
    }
}
