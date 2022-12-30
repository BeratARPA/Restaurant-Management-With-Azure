using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Add(Order t)
        {
            _orderDal.Add(t);
        }

        public void Delete(Order t)
        {
            _orderDal.Delete(t);
        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            return _orderDal.Get(filter);
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            return _orderDal.GetAll(filter);
        }

        public Order GetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public void Update(Order t)
        {
            _orderDal.Update(t);
        }
    }
}
