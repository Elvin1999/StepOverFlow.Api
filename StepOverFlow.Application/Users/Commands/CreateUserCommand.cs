using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using StepOverFlow.Application.Interfaces;
using StepOverFlow.Application.Users.Factory;
using StepOverFlow.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StepOverFlow.Application.Users.Commands
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private IDatabaseService databaseService;
        private readonly IUserFactory userFactory;
        private readonly UserManager<AppUser> userManager;
        private readonly ILogger logger;

        public CreateUserCommand(IDatabaseService databaseService,
            IUserFactory userFactory,
            UserManager<AppUser> userManager,
            ILogger logger)
        {
            this.databaseService = databaseService;
            this.userFactory = userFactory;
            this.userManager = userManager;
            this.logger = logger;
        }

        public async Task<IdentityResult> Execute(CreateUserModel model)
        {
            if (model != null)
            {
                var user = userFactory.Create(model);
                var result =await userManager.CreateAsync(user,model.Password);

                return result;
            }

            logger.LogError("Registermodel is null");
            throw new NullReferenceException("Data is Null");

        }

        
    }
}
