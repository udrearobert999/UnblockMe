using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Services
{
    public class RoleService : IRoleService
    {
        private readonly UnblockMeContext _dbContext;
        private readonly UserManager<Users> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleService(UnblockMeContext dbContext, UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public List<string> GetUserRoles(Users user)
        {
            var roles = _userManager?.GetRolesAsync(user)?.Result?.ToList();
            return roles;
        }
        public List<string> GetAvailableRoles()
        {
            var roles = _roleManager.Roles.Select(x => x.Name).ToList();
            return roles;
        }

        public void AddUserToRole(Users user, string role)
        {
            var fullRole = _dbContext.Roles.Where(r => r.Name == role).First();
            var userRole = new IdentityUserRole<string>();
            userRole.RoleId= fullRole.Id;
            userRole.UserId = user.Id;
            _dbContext.UserRoles.Add(userRole);
            _dbContext.SaveChanges();
        }

        public void RemoveUserFromRole(Users user, string role)
        {
            var fullRole = _dbContext.Roles.Where(r => r.Name == role).First();
            var userRole = new IdentityUserRole<string>();
            userRole.RoleId = fullRole.Id;
            userRole.UserId = user.Id;
            _dbContext.UserRoles.Remove(userRole);
            _dbContext.SaveChanges();
        }
    }

    public interface IRoleService
    {
        public void AddUserToRole(Users user, string role);
        public void RemoveUserFromRole(Users user, string role);
        public List<string> GetUserRoles(Users user);
        public List<string> GetAvailableRoles();
    }
}
