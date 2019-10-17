using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using webApiMultipleDb.Models;

namespace webApiMultipleDb.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext( DbContextOptions<BookDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
    }
}