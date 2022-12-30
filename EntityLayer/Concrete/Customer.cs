using EntityLayer.Abstract;
using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
