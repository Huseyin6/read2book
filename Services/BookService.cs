using System;
using System.Collections.Generic;
using System.Linq;
using read2book.Data;
using read2book;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace read2book.Services
{
    public class BookService : IBookService
    {
        private MainContext _db;

        public BookService(MainContext db)
        {
            _db = db;
        }

        public Book GetBook(int id){
            return _db.Books.FirstOrDefault(m=>m.Id==id);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        public void DeleteBook(int id){
            var entity= GetBook(id);
            _db.Books.Remove(entity);
        }
    }
}