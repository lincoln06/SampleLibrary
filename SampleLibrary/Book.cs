using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    public class Book:Human
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Book (string firstName, string lastName, string title, int year)
        :base(firstName, lastName)
        {
            Title = title;
            Year = year;
        }
        public static Book AddNewBook(string firstName, string lastName, string title, int year)
        {
            return new Book(firstName, lastName, title, year);
        }
    }
}
