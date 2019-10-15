using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using webApiMultipleDb.Models;

namespace webApiMultipleDb.Data
{
    public class UserDbContext : DbContext
    {
        private readonly IConfiguration _config;

        // public UserDbContext(IConfiguration config, DbContextOptions<UserDbContext> options)
        // {
        //     _config = config;
        // }

        public UserDbContext(IConfiguration config)
        {
            _config = config;
        }
        
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql(_config["ConnectionStrings:UserDBConnection"]);
    }
}