using Microsoft.EntityFrameworkCore;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Data.Repositories
{
    public class Repository<T>:IRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        public Repository(DataContext context)
        {
            _dbSet = context.Set<T>();
        }
   
        public T GetById(int id)
        {
            if (_dbSet == null)
                return null;
            return _dbSet.Find(id);
        }
        public T Add(T t)
        {
            _dbSet.Add(t);

            return t;
        }
        public T Update(int id, T t)
        {
           
            var existingEntity = _dbSet.Find(id);
            if (existingEntity == null || t == null)
            {
                return null;
            }
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                      .Where(prop => prop.Name != "Id");

            foreach (var property in properties)
            {
                var updatedValue = property.GetValue(t);

                if (updatedValue != null)
                    property.SetValue(existingEntity, updatedValue);
            }
            return t;
        }
        public bool Delete(int id)
        {
            if (_dbSet == null || _dbSet.Find(id) == null)
                return false;
            try
            {
            _dbSet.Remove(GetById(id));

                return true;
            }
            catch { return false; }
        }
  
    }
}
