using System.Collections.Generic;
using read2book.Data;
using System;


namespace read2book.Services
{
    public interface IBookService : IDisposable
    {
        Book FindBook(int id);
    }
}