using System;
using System.Collections.Generic;
namespace Chapter14
{
    public class Books
    {
        //Question 20
        public string BookTitle{get; set;}
       public string BookAuthor{get; set;}
       public string Publisher{get; set;}
       public DateTime ReleasedDate{get;}
       public int ISBN{get; set;}
       public Books(string bookTitle, string bookAuthor, string publisher, DateTime releasedDate, int isbn)
       {
           BookTitle = bookTitle;
           BookAuthor = bookAuthor;
           Publisher = publisher;
           ReleasedDate = releasedDate;
           ISBN = isbn;
       }
        
    }
}