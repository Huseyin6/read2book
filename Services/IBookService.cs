using System.Collections.Generic;
using read2book.Data;
using System;
using System.Threading.Tasks;

namespace read2book.Services
{
    public interface IBookService : IDisposable
    {
        Book GetBook(int id);
        List<Book> GetAllBooks();
        
    }
}