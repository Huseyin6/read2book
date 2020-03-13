using System;
using System.ComponentModel.DataAnnotations;

namespace read2book.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public string Author { get; set; }

        public DateTime BeginToReadDate { get; set; }

        public DateTime EndToReadDate { get; set; }

        public int PageCount { get; set; }

        public string Abstract { get; set; }
    }
}