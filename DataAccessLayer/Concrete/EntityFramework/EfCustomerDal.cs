using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System.Linq;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public Customer GetByPhoneAndPassword(string phoneNumber, string password)
        {
            using (AzureContext context = new AzureContext())
            {
                return context.Set<Customer>().Where(x => x.PhoneNumber == phoneNumber && x.Password == password).FirstOrDefault();
            }
        }
    }
}
