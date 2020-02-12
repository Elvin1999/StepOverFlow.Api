using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Notifications
{
    public class Notification : Entity<int>
    {
        public string Text { get; set; }
        public string SenderId { get; set; }
        public virtual AppUser Sender { get; set; }
        public string RecieverId { get; set; }
        public virtual AppUser Reciever { get; set; }
    }
}
