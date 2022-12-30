﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class, new()
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        T GetById(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
    }
}
