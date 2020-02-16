using StepOverFlow.Application.Questions.Commands;
using StepOverFlow.Domain.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Questions.Factory
{
    public interface IQuestionFactory
    {
        Question Create(CreateQuestionModel model);
    }
}
