using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Questions.Commands
{
    public interface ICreateQuestionCommand
    {
        void Execute(CreateQuestionModel model);
    }
}
