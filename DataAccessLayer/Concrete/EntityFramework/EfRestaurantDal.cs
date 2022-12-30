using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfRestaurantDal : GenericRepository<Restaurant>, IRestaurantDal
    {
        public List<Restaurant> GetByCustomerId(int customerId)
        {
            using (AzureContext context = new AzureContext())
            {
                return context.Set<Restaurant>().Where(x => x.CustomerId == customerId).ToList();
            }
        }
    }
}
