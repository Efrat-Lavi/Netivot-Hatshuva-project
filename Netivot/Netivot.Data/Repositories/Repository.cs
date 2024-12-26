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
        public Repository(DataContext context)
        {
            _dbSet = context.Set<T>();
        }
   
        //public List<T> GetAll()
        //{
        //    return _dbSet.Include(t=>t.).ToList();
        //}
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
            
            try
            {
            _dbSet.Add(t);

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
            return true;


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
