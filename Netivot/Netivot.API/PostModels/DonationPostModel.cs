using Netivot.Core.Entities;
using Netivot.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.API.PostModels
{
    public class DonationPostModel
    {
        public int DonorId { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }
        public ActiveStatusEnum DonationStatus { get; set; }

        
    }
}
