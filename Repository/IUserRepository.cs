using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webApiMultipleDb.Models;

namespace webApiMultipleDb.Repository
{
    public interface IUserRepository
    {
       Task<IEnumerable<User>> GetUsers();
       Task AddUser(User user);
    }
}
