using System;
using System.Collections.Generic;
using System.Text;
using TextbokBook.Business.Abstract;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Concrete
{
    public class LanguageManager : ILanguageService
    {
        private ILanguageDal _languageDal;
        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        public void Add(Language language)
        {
            _languageDal.Add(language);
        }

        public void delete(int id)
        {
            _languageDal.Delete(new Language { Id = id });
        }

        public List<Language> GetAll()
        {
            return _languageDal.GetAll();
        }

        public Language GetById(int id)
        {
            return _languageDal.GetById(id);
        }

        public void Update(Language language)
        {
            _languageDal.Update(language);
        }
    }
}
