using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Data.Repositories
{
    public class AvrechRepository:IRepository<AvrechEntity>
    {
        private readonly DataContext _dataContext;
        public AvrechRepository(DataContext context)
        {
            _dataContext = context;
        }
        public List<AvrechEntity> GetAll()
        {
            return _dataContext.avrechim.ToList();
        }
        public AvrechEntity GetById(int id)
        {
            if (_dataContext.avrechim == null)
                return null;
            return _dataContext.avrechim.Find(id);
        }
        public bool Add(AvrechEntity avrech)
        {

            if (avrech == null || _dataContext.avrechim.Find(avrech.Id) != null)
                return false;
            _dataContext.avrechim.Add(new AvrechEntity(avrech));
            try
            {
                _dataContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Update(int id, AvrechEntity avrech)
        {
            if (_dataContext.avrechim == null || avrech == null)
                return false;
            AvrechEntity a = _dataContext.avrechim.Find(id);
            if (a == null)
                return false;
            a.FirstName = avrech.FirstName != null ? avrech.FirstName:a.FirstName;
            a.LastName = avrech.LastName != null ? avrech.LastName : a.LastName;
            a.Gender = avrech.Gender != null ? avrech.Gender : a.Gender;
            a.Age = avrech.Age != null ? avrech.Age : a.Age;
            a.Email = avrech.Email != null ? avrech.Email :a.Email;
            a.PhoneNumber = avrech.PhoneNumber != null ? avrech.PhoneNumber : a.PhoneNumber;
            a.WorkStatus = avrech.WorkStatus != null ? avrech.WorkStatus : a.WorkStatus;
            a.JobDay = avrech.JobDay != null ? avrech.JobDay : a.JobDay;
            try
            {
                _dataContext.SaveChanges();
                return true;
            }
            catch  { return false; }

        }
        public bool Delete(int id)
        {
            if (_dataContext.avrechim == null || _dataContext.avrechim.Find(id) == null)
                return false;
            _dataContext.avrechim.Remove(GetById(id));
            try
            {
                _dataContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public AvrechEntity GetByName(string firstName)
        {
            if (_dataContext.avrechim == null)
                return null;
            return _dataContext.avrechim.Find(firstName);
        }
    }
}
