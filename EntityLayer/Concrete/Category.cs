using EntityLayer.Abstract;
using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int RestaurantId { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
