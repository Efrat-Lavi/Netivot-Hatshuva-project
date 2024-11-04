using Netivot_Project.Enums;

namespace Netivot_Project.entities
{
    public class AvrechEntity
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public WorkStatusEnum WorkStatus { get; set; }
        public DaysEnum JobDay { get; set; }

        public AvrechEntity()
        {
        }

        public AvrechEntity(int id, string firstName, string lastName, GenderEnum gender, int age, string email, string phoneNumber, WorkStatusEnum workStatus, DaysEnum jobDay)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            Email = email;
            PhoneNumber = phoneNumber;
            WorkStatus = workStatus;
            JobDay = jobDay;
        }
        public AvrechEntity(AvrechEntity other)
        {
            Id = other.Id;
            FirstName = other.FirstName;
            LastName = other.LastName;
            Gender = other.Gender;
            Age = other.Age;
            Email = other.Email;
            PhoneNumber = other.PhoneNumber;
            WorkStatus = other.WorkStatus;
            JobDay = other.JobDay;
        }

    }
}
