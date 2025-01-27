using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Netivot.Core.Entities;
namespace Netivot.API.PostModels
{
    public class MeetingPostModel
    {
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public int MitchazekId { get; set; }
        

     
    }
}
