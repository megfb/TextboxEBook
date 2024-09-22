using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Abstract
{
    public interface IOrderService
    {
        void Add(Order order);
        List<Order> GetOrderByUserId(string UserId);
        Order GetByOrderId(int id);
        List<Order> GetAll();
        void Delete(int id);
    }
}
