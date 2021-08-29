using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UnblockMe.Services;

namespace UnblockMe.Security
{
    public class IsNotBannedHandler : AuthorizationHandler<IsNotBannedRequirement>
    {
        private readonly IUserService _userService;

        public IsNotBannedHandler(IUserService userService)
        {
            _userService = userService;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsNotBannedRequirement requirement)
        {
            var user_id = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (user_id == null)
                context.Succeed(requirement);
            else
            { 
                var user = _userService.GetUserById(user_id);
                if (user.Banned == null)
                    context.Succeed(requirement);
            }
           

            return Task.CompletedTask;
        }
    }
}
