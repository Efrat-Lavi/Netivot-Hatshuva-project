using Netivot.Core.Entities;
using Netivot.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Service
{
    public class MeetingServices:IMeetingService
    {
        readonly IRepository<MeetingEntity> _iRepository;
        public MeetingServices(IRepository<MeetingEntity> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<MeetingEntity> GetAllMeetings()
        {
            return _iRepository.GetAll();
        }
        public MeetingEntity GetMeetingById(int id)
        {
            return _iRepository.GetById(id);

        }
        public bool AddMeeting(MeetingEntity meeting)
        {
            return _iRepository.Add(meeting);

        }
        public bool UpdateMeeting(int id, MeetingEntity meeting)
        {
            return _iRepository.Update(id, meeting);

        }
        public bool DeleteMeeting(int id)
        {
            return _iRepository.Delete(id);

        }
        public MeetingEntity GetMeetingByName(string firstName)
        {
            return _iRepository.GetByName(firstName);

        }
    }
}
