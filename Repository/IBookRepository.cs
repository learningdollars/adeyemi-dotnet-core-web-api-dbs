using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using webApiMultipleDb.Models;

namespace webApiMultipleDb.Repository
{
    public interface IBookRepository
    {
       Task<IEnumerable<Book>> GetBooks();
       Task AddBook(Book book);
    }
}