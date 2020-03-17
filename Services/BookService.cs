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
        private MainContext _dbContext;
        private DbSet<Book> _dbSet;
        public BookService(MainContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet=_dbContext.Set<Book>();
        }

        public Book GetBook(int id){
            return _dbSet.Find(id);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public List<Book> GetAllBooks()
        {
            return _dbSet.ToList();
        }

        public void DeleteBook(int id)
        {
            _dbSet.Remove(GetBook(id));
        }

        public void Insert(Book book)
        {
            _dbSet.Add(book);   
        }
        public void Update(Book book)
        {
            _dbContext.Entry(book).State=EntityState.Modified;
        }
        public void Save(){
            _dbContext.SaveChanges();
        }
    }
}