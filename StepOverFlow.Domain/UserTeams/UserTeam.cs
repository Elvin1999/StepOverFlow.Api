using StepOverFlow.Domain.Teams;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.UserTeams
{
    public class UserTeam
    {
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
