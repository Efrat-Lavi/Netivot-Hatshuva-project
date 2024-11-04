using Netivot_Project.Enums;

namespace Netivot_Project.entities
{
    public class MeetingEntity
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public AvrechEntity Avrech { get; set; }
        public MitchazekEntity Mitchazek { get; set; }
        public string Subject { get; set; }

        public MeetingEntity()
        {
        }

        public MeetingEntity(int id, DateOnly date, AvrechEntity avrech, MitchazekEntity mitchazek, string subject)
        {
            Id = id;
            Date = date;
            Avrech = avrech;
            Mitchazek = mitchazek;
            Subject = subject;
        }

        public MeetingEntity(MeetingEntity other)
        {
            Id = other.Id;
            Date = other.Date;
            Avrech = other.Avrech;
            Mitchazek = other.Mitchazek;
            Subject = other.Subject;
        }
    }
}
