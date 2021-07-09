using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Services
{
    public class UserService : IUserService
    {
        private readonly UnblockMeContext _dbContext;
        public UserService (UnblockMeContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Users> GetActiveUsers()
        {
            return _dbContext.Users.ToList();
        }
    }

    public interface IUserService
    {
        public List<Users> GetActiveUsers();

    }
}
