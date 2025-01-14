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
    public class MeetingRepository : Repository<MeetingEntity>,IMeetingRepository
    {
        public MeetingRepository(DataContext dataContext)
            : base(dataContext)
        {
        }
        public List<MeetingEntity> GetFull()
        {
            return _dbSet.Include(m=>m.Mitchazek).ToList();
        }
        //private readonly DataContext _dataContext;
        //public MeetingRepository(DataContext context)
        //{
        //    _dataContext = context;
        //}


        //public List<MeetingEntity> GetAll()
        //{
        //    return _dataContext.meetings.ToList();
        //}
        //public MeetingEntity GetById(int id)
        //{
        //    if (_dataContext.meetings == null)
        //        return null;
        //    return _dataContext.meetings.ToList().Find(m => m.Id == id);
        //}
        //public bool Add(MeetingEntity meeting)
        //{

        //    if (meeting == null || _dataContext.meetings.Find(meeting.Id) != null)
        //        return false;
        //    _dataContext.meetings.Add(new MeetingEntity(meeting));
        //    try
        //    {
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    catch { return false; }
        //}
        //public bool Update(int id, MeetingEntity meeting)
        //{
        //    if (_dataContext.meetings == null || meeting == null)
        //        return false;
        //    MeetingEntity m = _dataContext.meetings.Find(id);
        //    if (m == null)
        //        return false;
        //    m.Date = meeting.Date;
        //    m.AvrechId = meeting.AvrechId;
        //    m.MitchazekId = meeting.MitchazekId;
        //    m.Subject = meeting.Subject;
        //    try
        //    {
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    catch { return false; }
        //}
        //public bool Delete(int id)
        //{
        //    if (_dataContext.meetings == null || _dataContext.meetings.Find(id) == null)
        //        return false;
        //    _dataContext.meetings.Remove(GetById(id));
        //    try
        //    {
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    catch { return false; }
        //}
        //public MeetingEntity GetByName(string name)
        //{
        //    if (_dataContext.meetings == null)
        //        return null;
        //    DateTime date = DateTime.ParseExact(name, "ddMMyy", System.Globalization.CultureInfo.InvariantCulture);
        //    return _dataContext.meetings.Find(date);
        //}


    }
}
