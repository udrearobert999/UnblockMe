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
using Microsoft.EntityFrameworkCore;

namespace UnblockMe.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<Users> _userManager;
        private readonly UnblockMeContext _dbContext;
        private readonly IHttpContextAccessor _accesor;
        public UserService(UnblockMeContext dbContext, UserManager<Users> userManager, IHttpContextAccessor accesor)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _accesor = accesor;
        }
        public List<Users> GetActiveUsers()
        {
            return _dbContext.Users.Include(u => u.Banned).ToList();
        }
        public Users GetLoggedInUser()
        {
            if (_accesor.HttpContext.User.Identity.IsAuthenticated)
                return _userManager
                     .GetUserAsync(_accesor.HttpContext.User).Result;
            else
                return null;


        }
        public List<Cars> GetCarsListOfUser(Users curentUser = null)
        {
            if (curentUser == null)
                return _dbContext.Cars.ToList();
            else
            {
                var user = GetUserById(curentUser.Id);
                return user.Cars.ToList();
            }
        }
        public Users GetUserById(string id)
        {
            return _dbContext.Users
                        .Include(user => user.Cars)
                        .Include(user => user.RatesGot)
                        .Include(user=>user.Banned)
                        .Where(user => user.Id == id)
                        .First();
        }

        public void AddUserToRole(Users user, string role)
        {
            _userManager.AddToRoleAsync(user, role);
            _dbContext.SaveChanges();
        }

        public void AddOrUpdateUser(Users user)
        {
            if (_dbContext.Users.Any(u => u.Id == user.Id))
                _dbContext.Update(user);
            else
                _dbContext.Add(user);
            _dbContext.SaveChanges();
        }
        public List<Ratings> GetRatingsOfUser(Users user)
        {
            return _dbContext.Ratings
                .Include(u => u.Rater)
                .Include(uc => uc.Rated)
                .Where(r => r.rated_id == user.Id)
                .ToList();
        }
        public void BanUser(Users user, string reason, int duration)
        {
            if (user != null)
            {
              
                var banned_user = new banned_users(user.Id, reason, DateTime.UtcNow.AddDays(duration), user);
                user.Banned = banned_user;
                var ban_action = new BanActions(banned_user);
                ban_action.BanStart = DateTime.UtcNow;
                ban_action.BannedBy = GetLoggedInUser().Id;


                _dbContext.banned_users.Add(banned_user);
                _dbContext.BanActions.Add(ban_action);
                _dbContext.SaveChanges();
                
          
            }

        }
        public void UnbanUser(Users user)
        {
            
            _dbContext.banned_users.Remove(user.Banned);
            _dbContext.SaveChanges();
        }

        public Users GetUserByEmail(string email)
        {
            return _dbContext.Users.Include(u => u.Banned)
                .Where(u => u.Email == email)
                .ToList()
                .First();
        }
        public List<Users> GetUsersByUserName(string userName)
        {
            var users= _dbContext.Users.Include(u => u.Cars)
                .Include(u=>u.Banned)
                .Where(u => u.UserName.Contains(userName))
                .ToList();
            return users.GetRange(0, Math.Min(5, users.Count()));

        }
        public List<BanActions> GetUserBanInfo(string id)
        {
            return _dbContext.BanActions.Where(b => b.BannedId == id).ToList();
        }
    }

   

    public interface IUserService
    {
        public List<BanActions> GetUserBanInfo(string id);
        public List<Users> GetUsersByUserName(string userName);
        public Users GetUserByEmail(string email);
        public void UnbanUser(Users user);
        public void BanUser(Users user, string reason, int days);
        public List<Ratings> GetRatingsOfUser(Users user);
        public void AddOrUpdateUser(Users user);
        public void AddUserToRole(Users user, string role);
        public List<Cars> GetCarsListOfUser(Users curentUser = null);
        public List<Users> GetActiveUsers();
        public Users GetLoggedInUser();
        public Users GetUserById(string id);
    }
}
