using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Interfaces
{
    public interface IMeetingService
    {
        List<MeetingEntity> GetAllMeetings();
        MeetingEntity GetMeetingById(int id);
        bool AddMeeting(MeetingEntity t);
        bool UpdateMeeting(int id, MeetingEntity t);
        bool DeleteMeeting(int id);
        MeetingEntity GetMeetingByName(string firstName);
        
    }
}
