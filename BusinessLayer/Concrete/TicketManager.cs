using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class TicketManager : ITicketService
    {
        private readonly ITicketDal _ticketDal;

        public TicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }

        public void Add(Ticket t)
        {
            _ticketDal.Add(t);
        }

        public void Delete(Ticket t)
        {
            _ticketDal.Delete(t);
        }

        public Ticket Get(Expression<Func<Ticket, bool>> filter)
        {
            return _ticketDal.Get(filter);
        }

        public List<Ticket> GetAll(Expression<Func<Ticket, bool>> filter = null)
        {
            return _ticketDal.GetAll(filter);
        }

        public Ticket GetById(int id)
        {
            return _ticketDal.GetById(id);
        }

        public void Update(Ticket t)
        {
            _ticketDal.Update(t);
        }
    }
}
