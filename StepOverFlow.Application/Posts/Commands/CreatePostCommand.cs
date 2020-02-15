using StepOverFlow.Application.Interfaces;
using StepOverFlow.Application.Posts.Commands.Factory;
using StepOverFlow.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Posts.Commands
{
    public class CreatePostCommand : ICreatePostCommand
    {
        private IDatabaseService databaseService;
        private readonly IPostFactory factory;

        public CreatePostCommand(IDatabaseService databaseService,IPostFactory factory)
        {
            this.databaseService = databaseService;
            this.factory = factory;
        }

        public void Execute(CreatePostModel model)
        {
            var p = factory.Create(model);

            databaseService.Posts.Add(p);

            databaseService.Save();
        }
    }
}
