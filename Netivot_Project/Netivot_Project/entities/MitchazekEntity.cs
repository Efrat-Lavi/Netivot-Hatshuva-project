using Netivot_Project.Enums;

namespace Netivot_Project.entities
{
    public class MitchazekEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public SpiritualStateEnum SpiritualState { get; set; }
        public MatirialStatusEnum MaritalStatus { get; set; }
        public DaysEnum PreferredDay{ get; set; }

        public MitchazekEntity()
        {
        }

        public MitchazekEntity(int id, string firstName, string lastName, GenderEnum gender, int age, string email, int phoneNumber, SpiritualStateEnum spiritualState, MatirialStatusEnum maritalStatus, DaysEnum preferredDay)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            Email = email;
            PhoneNumber = phoneNumber;
            SpiritualState = spiritualState;
            MaritalStatus = maritalStatus;
            PreferredDay = preferredDay;
        }
        public MitchazekEntity(MitchazekEntity other)
        {
            Id = other.Id;
            FirstName = other.FirstName;
            LastName = other.LastName;
            Gender = other.Gender;
            Age = other.Age;
            Email = other.Email;
            PhoneNumber = other.PhoneNumber;
            SpiritualState = other.SpiritualState;
            MaritalStatus = other.MaritalStatus;
            PreferredDay = other.PreferredDay;
        }
    }
}
