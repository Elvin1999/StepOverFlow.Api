using StepOverFlow.Application.Posts.Queries.GetPostsList;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Posts.Queries.GetPostsList
{
   public interface IGetPostsListQuery
    {
        List<PostListItemModel> Execute();
    }
}
