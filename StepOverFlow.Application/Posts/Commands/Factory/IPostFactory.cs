using StepOverFlow.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Posts.Commands.Factory
{
    public interface IPostFactory
    {
        Post Create(CreatePostModel model);
    }
}
