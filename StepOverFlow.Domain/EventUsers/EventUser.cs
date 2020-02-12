using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Enums.EEventStatus;
using StepOverFlow.Domain.Events;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.EventUsers
{//chx-chox deyil
    public class EventUser:Entity<int>
    {
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public EEventStatus EventStatus { get; set; }
    }
}
