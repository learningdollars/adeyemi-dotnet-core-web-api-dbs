using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webApiMultipleDb.Data;
using webApiMultipleDb.Models;

namespace webApiMultipleDb.Repository
{
    public class BookRepository : IBookRepository
    {
      private readonly BookDbContext _context;
      public BookRepository (BookDbContext context) {
          _context = context;
      }
      public async Task<IEnumerable<Book>> GetBooks() {
          var books = await _context.Book.ToListAsync();
          return books;
       }
      public async Task AddBook(Book book) {
          await _context.Book.AddAsync(book);
          await _context.SaveChangesAsync();
       }
    }
}