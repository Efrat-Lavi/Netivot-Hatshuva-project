using Netivot.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Entities
{
    public class DonationEntity
    {

        [Key]
        public int Id { get; set; }
        public int DonorId { get; set; }
        public DonorEntity Donor { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }
        public ActiveStatusEnum DonationStatus { get; set; }
        public DonationEntity()
        {
        }

        public DonationEntity(int id, int idDonor, DateTime date, double sum, ActiveStatusEnum donationStatus)
        {
            Id = id;
            DonorId = idDonor;
            Date = date;
            Sum = sum;
            DonationStatus = donationStatus;
        }
        public DonationEntity(DonationEntity other)
        {
            Id = other.Id;
            DonorId = other.DonorId;
            Date = other.Date;
            Sum = other.Sum;
            DonationStatus = other.DonationStatus;
        }
    }
}
