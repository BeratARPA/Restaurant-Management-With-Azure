using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Add(T t)
        {
            using (AzureContext context = new AzureContext())
            {
                context.Entry(t).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T t)
        {
            using (AzureContext context = new AzureContext())
            {
                context.Entry(t).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (AzureContext context = new AzureContext())
            {
                return context.Set<T>().Where(filter).FirstOrDefault();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (AzureContext context = new AzureContext())
            {
                return filter == null
                ? context.Set<T>().ToList()
                : context.Set<T>().Where(filter).ToList();
            }
        }

        public T GetById(int id)
        {
            using (AzureContext context = new AzureContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Update(T t)
        {
            using (AzureContext context = new AzureContext())
            {
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
