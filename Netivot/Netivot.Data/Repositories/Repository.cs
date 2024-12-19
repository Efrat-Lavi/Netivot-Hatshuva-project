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
        private readonly DbSet<T> _dbSet;
        private readonly RepositoryManager _manager;
        public Repository(DataContext context,RepositoryManager _manager)
        {
            _dbSet = context.Set<T>();
            this._manager = _manager;
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(int id)
        {
            if (_dbSet == null)
                return null;
            return _dbSet.Find(id);
        }
        public bool Add(T t)
        {

            //if (t == null || _dbSet.Find(t.Id) != null)
            //    return false;
            _dbSet.Add(t);
            try
            {
                _manager.save();
                return true;
            }
            catch { return false; }
        }
        public bool Update(int id, T t)
        {
           
            var existingEntity = _dbSet.Find(id);
            if (existingEntity == null || t == null)
            {
                return false;
            }
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                      .Where(prop => prop.Name != "Id");

            foreach (var property in properties)
            {
                var updatedValue = property.GetValue(t);

                if (updatedValue != null)
                {
                    property.SetValue(existingEntity, updatedValue);
                }
            }
            try
            {
                _manager.save();
                return true;
            }
            catch { return false; }

        }
        public bool Delete(int id)
        {
            if (_dbSet == null || _dbSet.Find(id) == null)
                return false;
            _dbSet.Remove(GetById(id));
            try
            {
                _manager.save();
                return true;
            }
            catch { return false; }
        }
  
    }
}
