using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Posts;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.Likes
{
    public class Like : Entity<int>
    {
        public bool IsLiked { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
