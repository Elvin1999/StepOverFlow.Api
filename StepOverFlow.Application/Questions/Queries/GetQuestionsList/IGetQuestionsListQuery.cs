using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Questions.Queries.GetQuestionsList
{
    public interface IGetQuestionsListQuery
    {
        List<QuestionListItemModel> Execute();
    }
}
