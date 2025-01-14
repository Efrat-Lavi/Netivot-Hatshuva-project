using Microsoft.EntityFrameworkCore;
using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using Netivot.Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Data.Repositories
{
    public class AvrechRepository:Repository<AvrechEntity>, IAvrechRepository
    {
        public AvrechRepository(DataContext dataContext)
            : base(dataContext)
        {
           
        }
        public List<AvrechEntity> GetFull()
        {
            return _dbSet.Include(a => a.Mitchazkim).ToList();
        }
        //private readonly DataContext _dataContext;
        //public AvrechRepository(DataContext context)
        //{
        //    _dataContext = context;
        //}
        //public List<AvrechEntity> GetAll()
        //{
        //    return _dataContext.avrechim.ToList();
        //}
        //public AvrechEntity GetById(int id)
        //{
        //    if (_dataContext.avrechim == null)
        //        return null;
        //    return _dataContext.avrechim.Find(id);
        //}
        //public bool Add(AvrechEntity avrech)
        //{

        //    if (avrech == null || _dataContext.avrechim.Find(avrech.Id) != null)
        //        return false;
        //    try
        //    {
        //        _dataContext.avrechim.Add(new AvrechEntity(avrech));

        //        return true;
        //    }
        //    catch { return false; }
        //}
        //public bool Update(int id, AvrechEntity avrech)
        //{
        //    if (_dataContext.avrechim == null || avrech == null)
        //        return false;
        //    AvrechEntity a = _dataContext.avrechim.Find(id);
        //    if (a == null)
        //        return false;
        //    a.FirstName = avrech.FirstName != null ? avrech.FirstName:a.FirstName;
        //    a.LastName = avrech.LastName != null ? avrech.LastName : a.LastName;
        //    a.Gender = avrech.Gender != null ? avrech.Gender : a.Gender;
        //    a.Age = avrech.Age != null ? avrech.Age : a.Age;
        //    a.Email = avrech.Email != null ? avrech.Email :a.Email;
        //    a.PhoneNumber = avrech.PhoneNumber != null ? avrech.PhoneNumber : a.PhoneNumber;
        //    a.WorkStatus = avrech.WorkStatus != null ? avrech.WorkStatus : a.WorkStatus;
        //    a.JobDay = avrech.JobDay != null ? avrech.JobDay : a.JobDay;
        //    return true;

        //}
        //public bool Delete(int id)
        //{
        //    if (_dataContext.avrechim == null || _dataContext.avrechim.Find(id) == null)
        //        return false;
        //    try
        //    {
        //        _dataContext.avrechim.Remove(GetById(id));

        //        return true;
        //    }
        //    catch { return false; }
        //}
        //public AvrechEntity GetByName(string firstName)
        //{
        //    if (_dataContext.avrechim == null)
        //        return null;
        //    return _dataContext.avrechim.Find(firstName);
        //}
    }
}
