using Netivot_Project.Enums;
using System.Collections.Generic;

namespace Netivot_Project.entities
{
    public class DonorEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public ActiveStatusEnum DonorStatus { get; set; }
        public DateOnly LastDonation { get; set; }

        public DonorEntity()
        {
        }

        public DonorEntity(int id, string firstName, string lastName, string email, int phoneNumber, ActiveStatusEnum donorStatus, DateOnly lastDonation)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DonorStatus = donorStatus;
            LastDonation = lastDonation;
        }

        public DonorEntity(DonorEntity other)
        {
            Id = other.Id;
            FirstName = other.FirstName;
            LastName = other.LastName;
            Email = other.Email;
            PhoneNumber = other.PhoneNumber;
            DonorStatus = other.DonorStatus;
            LastDonation = other.LastDonation;
        }
    }
}
