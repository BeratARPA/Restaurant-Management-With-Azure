using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class RestaurantManager : IRestaurantService
    {
        private readonly IRestaurantDal _restaurantDal;

        public RestaurantManager(IRestaurantDal restaurantDal)
        {
            _restaurantDal = restaurantDal;
        }

        public void Add(Restaurant t)
        {
            _restaurantDal.Add(t);
        }

        public void Delete(Restaurant t)
        {
            _restaurantDal.Delete(t);
        }

        public Restaurant Get(Expression<Func<Restaurant, bool>> filter)
        {
            return _restaurantDal.Get(filter);
        }

        public List<Restaurant> GetAll(Expression<Func<Restaurant, bool>> filter = null)
        {
            return _restaurantDal.GetAll(filter);
        }

        public List<Restaurant> GetByCustomerId(int customerId)
        {
            return _restaurantDal.GetByCustomerId(customerId);
        }

        public Restaurant GetById(int id)
        {
            return _restaurantDal.GetById(id);
        }

        public void Update(Restaurant t)
        {
            _restaurantDal.Update(t);
        }
    }
}
