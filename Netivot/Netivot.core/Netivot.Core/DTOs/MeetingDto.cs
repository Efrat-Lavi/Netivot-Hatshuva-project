using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Entities
{
    public class MeetingDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public int MitchazekId { get; set; }
        

      
    }
}
