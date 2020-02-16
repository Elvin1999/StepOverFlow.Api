using System;
using System.Collections.Generic;
using System.Text;

namespace StepOverFlow.Application.Questions.Commands
{
    public class CreateQuestionModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int SkillId { get; set; }
        public int SpecialityId { get; set; }
    }
}
