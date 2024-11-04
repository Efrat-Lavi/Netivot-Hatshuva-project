using Netivot_Project.Enums;

namespace Netivot_Project.entities
{
    public class MeetingServices
    {
        List<MeetingEntity> Meetings;
        public List<MeetingEntity> GetAllMeeting()
        {
            return Meetings;
        }
        public MeetingEntity GetMeetingById(int id)
        {
            if (Meetings == null)
                return null;
            return Meetings.Find(m => m.Id == id);
        }
        public bool PostMeeting(MeetingEntity meeting)
        {
            if (Meetings == null)
                Meetings = new List<MeetingEntity>();
            if (meeting == null || Meetings.Exists(m => m.Id == meeting.Id))
                return false;
            Meetings.Add(new MeetingEntity(meeting));
            return true;
        }
        public bool PutMeeting(int id, MeetingEntity meeting)
        {
            if (Meetings == null || meeting == null)
                return false;
            int i = Meetings.FindIndex(m => m.Id == id);
            Meetings[i] = new MeetingEntity(meeting);
            return true;
        }
        public bool DeleteMeeting(int id)
        {
            if (Meetings == null || !Meetings.Exists(m => m.Id == id))
                return false;
            Meetings.Remove(GetMeetingById(id));
            return true;
        }
        public MeetingEntity GetMeetingByDate(DateOnly date)
        {
            if (Meetings == null)
                return null;
            return Meetings.Find(m => m.Date == date);
        }

    }
}
