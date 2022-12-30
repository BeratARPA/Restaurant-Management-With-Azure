using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IRestaurantService : IGenericService<Restaurant>
    {
        List<Restaurant> GetByCustomerId(int customerId);
    }
}
