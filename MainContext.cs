using System;
using read2book.Data;
using Microsoft.EntityFrameworkCore;

namespace read2book
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        public DbSet<Book> Books {get;set;}
    }
}
