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
    public class MitchazekRepository : Repository<MitchazekEntity>,IMitchazekRepoisitory
    {
        public MitchazekRepository(DataContext dataContext)
            : base(dataContext)
        {
        }
        public List<MitchazekEntity> GetFull()
        {
            return _dbSet.Include(m => m.Meetings).Include(m=>m.Avrech).ToList();
        }
        //private readonly DataContext _dataContext;
        //public MitchazekRepository(DataContext context)
        //{
        //    _dataContext = context;
        //}

        //public List<MitchazekEntity> GetAll()
        //{
        //    return _dataContext.mitchazkim.ToList();
        //}
        //public MitchazekEntity GetById(int id)
        //{
        //    if (_dataContext.mitchazkim == null)
        //        return null;
        //    return _dataContext.mitchazkim.Find(id);
        //}
        //public bool Add(MitchazekEntity mitchazek)
        //{

        //    if (mitchazek == null || _dataContext.mitchazkim.Find(mitchazek.Id) != null)
        //        return false;
        //    _dataContext.mitchazkim.Add(new MitchazekEntity(mitchazek));
        //    try
        //    {
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    catch { return false; }
        //}
        //public bool Update(int id, MitchazekEntity mitchazek)
        //{
        //    if (_dataContext.mitchazkim == null || mitchazek == null)
        //        return false;
        //    MitchazekEntity m = _dataContext.mitchazkim.Find(id);
        //    if (m == null)
        //        return false;
        //    m.FirstName = mitchazek.FirstName;
        //    m.LastName = mitchazek.LastName;
        //    m.Gender = mitchazek.Gender;
        //    m.Age = mitchazek.Age;
        //    m.Email = mitchazek.Email;
        //    m.PhoneNumber = mitchazek.PhoneNumber;
        //    m.SpiritualState = mitchazek.SpiritualState;
        //    m.MaritalStatus = mitchazek.MaritalStatus;
        //    m.PreferredDay = mitchazek.PreferredDay;
        //    try
        //    {
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    catch { return false; }
        //}
        //public bool Delete(int id)
        //{
        //    if (_dataContext.mitchazkim == null || _dataContext.mitchazkim.Find(id)==null)
        //        return false;
        //    _dataContext.mitchazkim.Remove(GetById(id));
        //    try
        //    {
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    catch { return false; }
        //}
        //public MitchazekEntity GetByName(string name)
        //{
        //    if (_dataContext.mitchazkim == null)
        //        return null;
        //    return _dataContext.mitchazkim.Find(name);
        //}

    }
}
