using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Abstract
{
    public interface ILanguageService
    {
        List<Language> GetAll();
        void Add(Language language);
        void delete(int id);
        void Update(Language language);
        Language GetById(int id);
    }
}
