using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Questions.Queries.GetQuestionDetail
{
    public interface IGetQuestionDetailQuery
    {
        QuestionDetailItemModel Execute(int questionId);
    }
}
