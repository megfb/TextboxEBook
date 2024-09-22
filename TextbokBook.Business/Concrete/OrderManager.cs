using System;
using System.Collections.Generic;
using System.Text;
using TextbokBook.Business.Abstract;
using TextboxBook.Dal.Abstract;
using TextboxBook.Entity.Concrete;

namespace TextbokBook.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(int id)
        {
            _orderDal.Delete(new Order { Id = id });
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAllWithDetails();
        }

        public Order GetByOrderId(int id)
        {
            return _orderDal.GetOrder(id);
        }

        public List<Order> GetOrderByUserId(string UserId)
        {
            return _orderDal.GetAll(p => p.UserId == UserId);

        }

    }
}
