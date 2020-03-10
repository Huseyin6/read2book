using System;
using System.Collections.Generic;
using System.Linq;
using read2book.Data;
using read2book;

namespace read2book.Services
{
    public class BookService : IBookService
    {
        private MainContext _db;

        public BookService(MainContext db)
        {
            _db = db;
        }

        public Book FindBook(int id){
            return _db.Books.FirstOrDefault(m=>m.Id==id);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}