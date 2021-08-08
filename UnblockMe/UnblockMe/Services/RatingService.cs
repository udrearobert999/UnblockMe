using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Services
{
    public class RatingService : IRatingService
    {
        private readonly UnblockMeContext _dbContext;
        private readonly IUserService _userService;

        public RatingService(IUserService userService , UnblockMeContext dbContext)
        {
            _dbContext = dbContext;
            _userService = userService;
        }
        public void AddRate(Ratings rate)
        {
            _dbContext.Ratings.Add(rate);
            _dbContext.SaveChanges();
        }
    }

    public interface IRatingService
    {
        public void AddRate(Ratings rate);
    }
}
