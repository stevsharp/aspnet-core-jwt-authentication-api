using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;

namespace WebApi.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }

}
