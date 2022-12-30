using EntityLayer.Abstract;

namespace EntityLayer.Concrete
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }

        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
