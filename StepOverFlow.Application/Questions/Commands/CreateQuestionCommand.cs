using StepOverFlow.Application.Interfaces;
using StepOverFlow.Application.Questions.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Questions.Commands
{
    public class CreateQuestionCommand : ICreateQuestionCommand
    {
        private IDatabaseService databaseService;
        private readonly IQuestionFactory factory;

        public CreateQuestionCommand(IDatabaseService databaseService,
            IQuestionFactory factory)
        {
            this.databaseService = databaseService;
            this.factory = factory;
        }

        public void Execute(CreateQuestionModel model)
        {
            var question = factory.Create(model);
            databaseService.Questions.Add(question);
            databaseService.Save();
        }
    }
}
