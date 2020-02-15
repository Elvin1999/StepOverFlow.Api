using StepOverFlow.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Posts.Commands.Factory
{
    public class PostFactory : IPostFactory
    {
        public Post Create(CreatePostModel model)
        {
            var post = new Post
            {
                Description = model.Description,
                Title = model.Name,
                CreatedAt = DateTimeOffset.Now
            };
            return post;
        }

        
    }
}
