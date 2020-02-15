using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Posts.Commands
{
   public interface ICreatePostCommand
    {
        void Execute(CreatePostModel model);
    }
}
