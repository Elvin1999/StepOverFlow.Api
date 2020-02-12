using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.EventUsers;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Events
{
    public class Event:Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTimeOffset EventTime { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual List<EventUser> EventUsers { get; set; }
    }
}
