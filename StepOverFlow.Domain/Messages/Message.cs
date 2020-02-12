using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Teams;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Messages
{
    public class Message : Entity<int>
    {
        public string Text { get; set; }
        public string SenderUserId { get; set; }
        public virtual AppUser SenderUser { get; set; }
        public int RecieverTeamId { get; set; }
        public virtual Team RecieverTeam { get; set; }
    }
}
