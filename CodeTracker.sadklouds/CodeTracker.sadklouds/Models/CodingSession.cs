﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTracker.Models
{
    public class CodingSession
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }

        public CodingSession(int id, DateTime startTime, DateTime endTime, TimeSpan duration )
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
            
        }
    }
}
