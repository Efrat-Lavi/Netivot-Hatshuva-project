using Netivot.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Entities
{
    public class MitchazekDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public SpiritualStateEnum SpiritualState { get; set; }
        public MatirialStatusEnum MaritalStatus { get; set; }
        public DaysEnum PreferredDay { get; set; }
        public int AvrechId { get; set; }
       
    }
}
