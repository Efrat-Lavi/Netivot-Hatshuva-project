using Netivot.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Entities
{
    public class DonationDto
    {

        public int Id { get; set; }
        public int DonorId { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }
        public ActiveStatusEnum DonationStatus { get; set; }

    }
}
