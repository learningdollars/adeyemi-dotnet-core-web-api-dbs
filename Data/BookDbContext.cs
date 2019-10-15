using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using webApiMultipleDb.Models;

namespace webApiMultipleDb.Data
{
    public class BookDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public BookDbContext(IConfiguration config, DbContextOptions<BookDbContext> options) : base(options)
        {
            _config = config;
        }
        
        public DbSet<Book> Book { get; set; }
    }
}