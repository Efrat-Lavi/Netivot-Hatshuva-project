using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using Netivot.Core.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class MeetingServices:IMeetingService
    {
        readonly IRepositoryManager _iRepository;
        public MeetingServices(IRepositoryManager repository)
        {
            _iRepository = repository;
        }
        public List<MeetingEntity> GetAllMeetings()
        {
            return _iRepository._meetingRepository.GetFull();
        }
        public MeetingEntity GetMeetingById(int id)
        {
            return _iRepository._meetingRepository.GetById(id);

        }
        public bool AddMeeting(MeetingEntity meeting)
        {
            bool succeed = _iRepository._meetingRepository.Add(meeting);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        public bool UpdateMeeting(int id, MeetingEntity meeting)
        {
            bool succeed = _iRepository._meetingRepository.Update(id,meeting);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        public bool DeleteMeeting(int id)
        {
            bool succeed = _iRepository._meetingRepository.Delete(id);
            if (succeed)
                _iRepository.save();
            return succeed;
        }
        //public MeetingEntity GetMeetingByName(string firstName)
        //{
        //    return _iRepository.GetByName(firstName);

        //}
    }
}
