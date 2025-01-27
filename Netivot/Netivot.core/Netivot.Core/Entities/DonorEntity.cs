using Netivot.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Entities
{
    public class DonorEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ActiveStatusEnum DonorStatus { get; set; }
        public DateTime LastDonation { get; set; }
        public List<DonationEntity> Donations { get; set; }
        public DonorEntity()
        {
        }

        public DonorEntity(int id, string firstName, string lastName, string email, string phoneNumber, ActiveStatusEnum donorStatus, DateTime lastDonation)
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
