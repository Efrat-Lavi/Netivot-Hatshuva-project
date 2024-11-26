using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Data.Repositories
{
    public class MeetingRepository : IRepository<MeetingEntity>
    {
        private readonly DataContext _dataContext;
        public MeetingRepository(DataContext context)
        {
            _dataContext = context;
        }
    

        public List<MeetingEntity> GetAll()
        {
            return _dataContext.meetings;
        }
        public MeetingEntity GetById(int id)
        {
            if (_dataContext.meetings == null)
                return null;
            return _dataContext.meetings.Find(m => m.Id == id);
        }
        public bool Add(MeetingEntity meeting)
        {
            if (_dataContext.meetings == null)
                _dataContext.meetings = new List<MeetingEntity>();
            if (meeting == null || _dataContext.meetings.Exists(m => m.Id == meeting.Id))
                return false;
            _dataContext.meetings.Add(new MeetingEntity(meeting));
            return _dataContext.Save<MeetingEntity>(_dataContext.meetings, "Meetings.csv"); ;
        }
        public bool Update(int id, MeetingEntity meeting)
        {
            if (_dataContext.meetings == null || meeting == null)
                return false;
            int i = _dataContext.meetings.FindIndex(m => m.Id == id);
            if (i == -1)
                return false;
            _dataContext.meetings[i].Date = meeting.Date;
            _dataContext.meetings[i].AvrechId = meeting.AvrechId;
            _dataContext.meetings[i].MitchazekId = meeting.MitchazekId;
            _dataContext.meetings[i].Subject = meeting.Subject;
            return _dataContext.Save<MeetingEntity>(_dataContext.meetings, "Meetings.csv"); ;
        }
        public bool Delete(int id)
        {
            if (_dataContext.meetings == null || !_dataContext.meetings.Exists(m => m.Id == id))
                return false;
            _dataContext.meetings.Remove(GetById(id));
            return _dataContext.Save<MeetingEntity>(_dataContext.meetings, "Meetings.csv"); ;
        }
        public MeetingEntity GetByName(string name)
        {
            if (_dataContext.meetings == null)
                return null;
            DateTime date = DateTime.ParseExact(name, "ddMMyy", System.Globalization.CultureInfo.InvariantCulture);
            return _dataContext.meetings.Find(m => m.Date == date);
        }


    }
}
