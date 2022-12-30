using EntityLayer.Abstract;
using System;
using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Ticket:IEntity
    {
        public int Id { get; set; }
        public int TicketNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethodText { get; set; }
        public string CustomerNote { get; set; }

        public int RestaurantId { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
