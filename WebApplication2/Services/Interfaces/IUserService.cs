using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services.Communications;

namespace WebApplication2.Services.Interfaces
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(User user);
        Task<User> FindByEmailAsync(string email);
    }
}
