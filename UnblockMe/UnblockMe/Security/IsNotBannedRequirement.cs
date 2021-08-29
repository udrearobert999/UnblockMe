using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Security
{
    public class IsNotBannedRequirement : IAuthorizationRequirement
    {
        public IsNotBannedRequirement()
        {
        }
    }
}
