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
            return _dataContext.avrechim;
        }
        public AvrechEntity GetById(int id)
        {
            if (_dataContext.avrechim == null)
                return null;
            return _dataContext.avrechim.Find(a => a.Id == id);
        }
        public bool Add(AvrechEntity avrech)
        {
            if (_dataContext.avrechim == null)
                _dataContext.avrechim = new List<AvrechEntity>();
            if (avrech == null || _dataContext.avrechim.Exists(a => a.Id == avrech.Id))
                return false;
            _dataContext.avrechim.Add(new AvrechEntity(avrech));
            return _dataContext.Save<AvrechEntity>(_dataContext.avrechim, "Avrechim.csv");
        }
        public bool Update(int id, AvrechEntity avrech)
        {
            if (_dataContext.avrechim == null || avrech == null)
                return false;
            int i = _dataContext.avrechim.FindIndex(a => a.Id == id);
            if (i == -1)
                return false;
            _dataContext.avrechim[i].FirstName = avrech.FirstName;
            _dataContext.avrechim[i].LastName = avrech.LastName;
            _dataContext.avrechim[i].Gender = avrech.Gender;
            _dataContext.avrechim[i].Age = avrech.Age;
            _dataContext.avrechim[i].Email = avrech.Email;
            _dataContext.avrechim[i].PhoneNumber = avrech.PhoneNumber;
            _dataContext.avrechim[i].WorkStatus = avrech.WorkStatus;
            _dataContext.avrechim[i].JobDay = avrech.JobDay;
            return _dataContext.Save<AvrechEntity>(_dataContext.avrechim, "Avrechim.csv");
        }
        public bool Delete(int id)
        {
            if (_dataContext.avrechim == null || !_dataContext.avrechim.Exists(a => a.Id == id))
                return false;
            _dataContext.avrechim.Remove(GetById(id));
            return _dataContext.Save<AvrechEntity>(_dataContext.avrechim, "Avrechim.csv"); ;
        }
        public AvrechEntity GetByName(string firstName)
        {
            if (_dataContext.avrechim == null)
                return null;
            return _dataContext.avrechim.Find(a => a.FirstName == firstName);
        }
    }
}
