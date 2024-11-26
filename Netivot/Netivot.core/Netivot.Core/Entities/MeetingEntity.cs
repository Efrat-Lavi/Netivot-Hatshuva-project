﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netivot.Core.Entities
{
    public class MeetingEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int AvrechId { get; set; }
        public int MitchazekId { get; set; }
        public string Subject { get; set; }

        public MeetingEntity()
        {
        }

        public MeetingEntity(int id, DateTime date, int avrech, int mitchazek, string subject)
        {
            Id = id;
            Date = date;
            AvrechId = avrech;
            MitchazekId = mitchazek;
            Subject = subject;
        }

        public MeetingEntity(MeetingEntity other)
        {
            Id = other.Id;
            Date = other.Date;
            AvrechId = other.AvrechId;
            MitchazekId = other.MitchazekId;
            Subject = other.Subject;
        }
    }
}