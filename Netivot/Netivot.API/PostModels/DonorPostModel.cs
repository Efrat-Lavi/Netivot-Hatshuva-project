﻿using Netivot.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.API.PostModels
{
    public class DonorPostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ActiveStatusEnum DonorStatus { get; set; }
        public DateTime LastDonation { get; set; }
        
    }
}
