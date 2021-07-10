using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace UnblockMe.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<Users> _userManager;
        private readonly UnblockMeContext _dbContext;
        private readonly IHttpContextAccessor _accesor;
        public UserService (UnblockMeContext dbContext, UserManager<Users> userManager, IHttpContextAccessor accesor)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _accesor = accesor;
        }
        public List<Users> GetActiveUsers()
        {
            return _dbContext.Users.ToList();
        }
        public Users GetLoggedInUser()
        {
            return _userManager
                .GetUserAsync(_accesor.HttpContext.User).Result;
           
           
        }
        public Users GetUserById(string id)
        {
            return _dbContext.Users.Find(id);
        }
    }

    public interface IUserService
    {
        public List<Users> GetActiveUsers();
        public Users GetLoggedInUser();
        public Users GetUserById(string id);
    }
}
