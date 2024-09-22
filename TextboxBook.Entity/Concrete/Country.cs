using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Abstract;


namespace TextboxBook.Entity.Concrete
{
    public class Country:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
