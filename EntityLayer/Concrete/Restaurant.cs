using EntityLayer.Abstract;

namespace EntityLayer.Concrete
{
    public class Restaurant : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public decimal MinimumAmount { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
