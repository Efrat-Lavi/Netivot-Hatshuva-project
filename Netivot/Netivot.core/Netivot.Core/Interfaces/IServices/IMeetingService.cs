using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces.IServices
{
    public interface IMeetingService
    {
        IEnumerable<MeetingDto> GetAllMeetings();
        MeetingDto GetMeetingById(int id);
        MeetingDto AddMeeting(MeetingDto t);
        MeetingDto UpdateMeeting(int id, MeetingDto t);
        bool DeleteMeeting(int id);
        //MeetingEntity GetMeetingByName(string firstName);

    }
}
