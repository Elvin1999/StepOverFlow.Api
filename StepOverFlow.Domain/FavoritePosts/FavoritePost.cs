using StepOverFlow.Domain.Base;
using StepOverFlow.Domain.Posts;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Domain.FavoritePosts
{
    public class FavoritePost : Entity<int>
    {
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
