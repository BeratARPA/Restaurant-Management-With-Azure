using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICustomerService:IGenericService<Customer>
    {
        Customer GetByPhoneAndPassword(string phoneNumber, string password);
    }
}
