using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Data.Repositories
{
    public class MitchazekRepository : IRepository<MitchazekEntity>
    {
        private readonly DataContext _dataContext;
        public MitchazekRepository(DataContext context)
        {
            _dataContext = context;
        }
 
        public List<MitchazekEntity> GetAll()
        {
            return _dataContext.mitchazkim;
        }
        public MitchazekEntity GetById(int id)
        {
            if (_dataContext.mitchazkim == null)
                return null;
            return _dataContext.mitchazkim.Find(m => m.Id == id);
        }
        public bool Add(MitchazekEntity mitchazek)
        {
            if (_dataContext.mitchazkim == null)
                _dataContext.mitchazkim = new List<MitchazekEntity>();
            if (mitchazek == null || _dataContext.mitchazkim.Exists(m => m.Id == mitchazek.Id))
                return false;
            _dataContext.mitchazkim.Add(new MitchazekEntity(mitchazek));
            return _dataContext.Save<MitchazekEntity>(_dataContext.mitchazkim, "Mitchazkim.csv"); ;
        }
        public bool Update(int id, MitchazekEntity mitchazek)
        {
            if (_dataContext.mitchazkim == null || mitchazek == null)
                return false;
            int i = _dataContext.mitchazkim.FindIndex(m => m.Id == id);
            if (i == -1)
                return false;
            _dataContext.mitchazkim[i].FirstName = mitchazek.FirstName;
            _dataContext.mitchazkim[i].LastName = mitchazek.LastName;
            _dataContext.mitchazkim[i].Gender = mitchazek.Gender;
            _dataContext.mitchazkim[i].Age = mitchazek.Age;
            _dataContext.mitchazkim[i].Email = mitchazek.Email;
            _dataContext.mitchazkim[i].PhoneNumber = mitchazek.PhoneNumber;
            _dataContext.mitchazkim[i].SpiritualState = mitchazek.SpiritualState;
            _dataContext.mitchazkim[i].MaritalStatus = mitchazek.MaritalStatus;
            _dataContext.mitchazkim[i].PreferredDay = mitchazek.PreferredDay;
            return _dataContext.Save<MitchazekEntity>(_dataContext.mitchazkim, "Mitchazkim.csv"); ;
        }
        public bool Delete(int id)
        {
            if (_dataContext.mitchazkim == null || !_dataContext.mitchazkim.Exists(m => m.Id == id))
                return false;
            _dataContext.mitchazkim.Remove(GetById(id));
            return _dataContext.Save<MitchazekEntity>(_dataContext.mitchazkim, "Mitchazkim.csv"); ;
        }
        public MitchazekEntity GetByName(string name)
        {
            if (_dataContext.mitchazkim == null)
                return null;
            return _dataContext.mitchazkim.Find(m => m.FirstName == name);
        }

    }
}
