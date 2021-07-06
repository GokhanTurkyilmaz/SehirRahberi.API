using SehirRahberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRahberi.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> LogIn(string userName, string password);
        Task<bool> UserExists(string userName);
    }
}
