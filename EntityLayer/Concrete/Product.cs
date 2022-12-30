using EntityLayer.Abstract;

namespace EntityLayer.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
