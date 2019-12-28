using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Repositories;
using WebApplication2.Security.Hashing;
using WebApplication2.Services.Communications;
using WebApplication2.Services.Interfaces;

namespace WebApplication2.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }
        //private ApplicationUserManager UserManager
        //{
        //    get
        //    {
        //        return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
        //    }
        //}

        public async Task<CreateUserResponse> CreateUserAsync(User user)
        {
            user.UserRole = ERole.Common;
            user.Name = "Default";
            //Microsoft.AspNet.Identity.IdentityResult result = await UserManager.CreateAsync(user, user.Password);
            await _userRepository.AddAsync(user);
            await _unitOfWork.CompleteAsync();
            return new CreateUserResponse(true, null, user);
        }

        public async Task<User> FindByEmailAsync(string email)
        {
            return await _userRepository.FindByEmailAsync(email);
        }
    }
}
