using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal : IGenericDal<Customer>
    {
        Customer GetByPhoneAndPassword(string phoneNumber, string password);
    }
}
