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
        public void AddOrUpdateRate(Ratings rate)
        {
            if (_dbContext.Ratings.
                Any(curentRate => curentRate.rater_id == rate.rater_id && curentRate.rated_id == rate.rated_id))
            {
                _dbContext.Update(rate);
            }
            else
                _dbContext.Add(rate);
            _dbContext.SaveChanges();
        }
    }

    public interface IRatingService
    {
        public void AddOrUpdateRate(Ratings rate);
    }
}
