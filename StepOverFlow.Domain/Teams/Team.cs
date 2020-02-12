using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Messages;
using StepOverFlow.Domain.Users;
using StepOverFlow.Domain.UserTeams;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Teams
{
    public class Team : Entity<int>
    {
        public string Name { get; set; }
        public virtual List<Message> Messages { get; set; }
        public virtual List<UserTeam> UserTeams { get; set; }
        public string CreaterId { get; set; }
        public virtual AppUser Creater { get; set; }




    }
}
