using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webApiMultipleDb.Models;
using webApiMultipleDb.Data;


namespace webApiMultipleDb.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;
        public UserRepository(UserDbContext context) {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers() {
          return await _context.User.ToListAsync();
       }
      public async Task AddUser(User user) {
          await _context.User.AddAsync(user);
          await _context.SaveChangesAsync();
       }
    }
}