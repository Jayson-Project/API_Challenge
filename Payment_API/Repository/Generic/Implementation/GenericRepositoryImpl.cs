using Microsoft.EntityFrameworkCore;
using Payment_API.Model.Base;
using Payment_API.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Payment_API.Repository.Generic.Implementation
{
    public class GenericRepositoryImpl<T> : IRepository<T> where T : BaseEntity
    {
        private readonly SqlServerContext _context;
        private DbSet<T> dataset;

        public GenericRepositoryImpl(SqlServerContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();

                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(long Id)
        {
            try
            {
                var result = dataset.SingleOrDefault(p => p.Id.Equals(Id));
                if (result != null)
                    dataset.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exist(long? id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }

        public T FindById(long Id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(Id));
        }

        public T Update(T item)
        {
            try
            {

                if (!Exist(item.Id)) return null;

                var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));

                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
