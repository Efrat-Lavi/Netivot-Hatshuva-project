using Netivot_Project.Enums;

namespace Netivot_Project.entities
{
    public class MeetingServices
    {
        public List<MeetingEntity> GetAllMeeting()
        {
            return DataManager.dataContexts.meetings;
        }
        public MeetingEntity GetMeetingById(int id)
        {
            if (DataManager.dataContexts.meetings == null)
                return null;
            return DataManager.dataContexts.meetings.Find(m => m.Id == id);
        }
        public bool AddMeeting(MeetingEntity meeting)
        {
            if (DataManager.dataContexts.meetings == null)
                DataManager.dataContexts.meetings = new List<MeetingEntity>();
            if (meeting == null || DataManager.dataContexts.meetings.Exists(m => m.Id == meeting.Id))
                return false;
            DataManager.dataContexts.meetings.Add(new MeetingEntity(meeting));
            return true;
        }
        public bool UpdateMeeting(int id, MeetingEntity meeting)
        {
            if (DataManager.dataContexts.meetings == null || meeting == null)
                return false;
            int i = DataManager.dataContexts.meetings.FindIndex(m => m.Id == id);
            DataManager.dataContexts.meetings[i].Date = meeting.Date;
            DataManager.dataContexts.meetings[i].Avrech = meeting.Avrech;
            DataManager.dataContexts.meetings[i].Mitchazek = meeting.Mitchazek;
            DataManager.dataContexts.meetings[i].Subject = meeting.Subject;
            return true;
        }
        public bool DeleteMeeting(int id)
        {
            if (DataManager.dataContexts.meetings == null || !DataManager.dataContexts.meetings.Exists(m => m.Id == id))
                return false;
            DataManager.dataContexts.meetings.Remove(GetMeetingById(id));
            return true;
        }
        public MeetingEntity GetMeetingByDate(DateOnly date)
        {
            if (DataManager.dataContexts.meetings == null)
                return null;
            return DataManager.dataContexts.meetings.Find(m => m.Date == date);
        }

    }
}
