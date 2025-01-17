﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Data.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        IQueryable<T> Where(Expression<Func<T, bool>> predicate);

        Task<T> AddAsync(T entity);

        void Remove(T entity);

        T Update(T entity);
    }
}
