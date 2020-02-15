using StepOverFlow.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepOverFlow.Application.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery : IGetPostsListQuery
    {
        private IDatabaseService databaseService;

        public GetPostsListQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        public List<PostListItemModel> Execute()
        {
            var posts = databaseService.Posts.Select(i => new PostListItemModel()
            {
                Description = i.Description,
                Id = i.Id,
                Name = i.Title
            });
            return posts.ToList();
        }
    }
}
