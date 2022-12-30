using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IRestaurantDal : IGenericDal<Restaurant>
    {
        List<Restaurant> GetByCustomerId(int customerId);
    }
}
