using AutoMapper;
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
        private readonly IMapper _mapper;

        public MeetingServices(IRepositoryManager iRepository, IMapper mapper)
        {
            _iRepository = iRepository;
            _mapper = mapper;
        }
        public IEnumerable<MeetingDto> GetAllMeetings()
        {
            var meetings = _iRepository._meetingRepository.GetFull();
            var meetingsDto = _mapper.Map<IEnumerable<MeetingDto>>(meetings);
            return meetingsDto;
        }
        public MeetingDto GetMeetingById(int id)
        {
            var meeting = _iRepository._meetingRepository.GetById(id);
            var meetingDto = _mapper.Map<MeetingDto>(meeting);  
            return meetingDto;

        }
        public MeetingDto AddMeeting(MeetingDto meetingDto)
        {
            var meeting = _mapper.Map<MeetingEntity>(meetingDto);
            meeting = _iRepository._meetingRepository.Add(meeting);
            if (meeting != null)
            {
                _iRepository.save();
                return meetingDto;
            }
            return null;
        }
        public MeetingDto UpdateMeeting(int id, MeetingDto meetingDto)
        {
            var meeting = _mapper.Map<MeetingEntity>(meetingDto);
            meeting = _iRepository._meetingRepository.Update(id,meeting);
            if (meeting != null)
            {
                _iRepository.save();
                return meetingDto;
            }
            return null;
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
