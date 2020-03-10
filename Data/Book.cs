using System;
using System.ComponentModel.DataAnnotations;

namespace read2book.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
       
        [Display(Name="Adı")]
        public string Name { get; set; }
      
    }
}