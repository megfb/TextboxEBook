using System;
using System.Collections.Generic;
using System.Text;
using TextbokBook.Business.Abstract;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Concrete
{
    public class GenderManager : IGenderService
    {
        private IGenderDal _genderDal;
        public GenderManager(IGenderDal genderDal)
        {
            _genderDal = genderDal;
        }
        public List<Gender> GetAll()
        {
            return _genderDal.GetAll();
        }
    }
}
