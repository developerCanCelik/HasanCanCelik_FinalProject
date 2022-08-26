﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
        List<T> List();
        T GetById(int id);
        List<T> List(Expression<Func<T, bool>> filter);
        T Find(Expression<Func<T, bool>> where);
    }
}
