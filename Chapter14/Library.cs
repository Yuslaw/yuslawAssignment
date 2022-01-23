using System;
using System.Collections.Generic;
namespace Chapter14
{
    public class Library: Books
    {
        //Question 20 and 21
        public string LibraryNumber {get;}   
        public static List<Books> books = new List<Books>();
        public Library(string bookTitle, string bookAuthor, string publisher, DateTime releasedDate, int isbn, string libraryNumber) : base(bookTitle, bookAuthor, publisher, releasedDate, isbn)
        {
            AddBooks();
            LibraryNumber = GenerateNum();
        }
         public static string GenerateNum()
        {
            return $"LIB/{Guid.NewGuid().ToString().Substring(0, 7)}/";
        }
        public void AddBooks()
        {
            books.Add(this);
        }
        public void SearchBook()
        {
            for (var i = 0; i < books.Count; i++)
            {
                Console.WriteLine($" The Book TiTle is: {books[i].BookTitle} and the Author is: {books[i].BookAuthor}");
            }
        }
        public static void BookInfo()
        {
           for(int i = 0; i < books.Count; i ++)
           {
               Console.WriteLine($"The title of book {i + 1} is {books[i].BookTitle}, and the author of the book is {books[i].BookAuthor} the book was released on the {DateTime.Now} while trhe Isbn number is {books[i].ISBN}");
           }
        }
        public static void DeleteBook(string name)
        {
            foreach (var item in books)
            {
                if(item.BookTitle == name)
                {
                    books.Remove(item);
                }
                
            }
        }
        
    }

     public class Test
    {
        public static void BookMenu()
        {
            Console.WriteLine(">>>>>>..WELCOME LIBRARY>>>>>>>>");
            Console.WriteLine("How many books did you want to save in the library");
            int BookNumbers = int.Parse(Console.ReadLine());            
            for (var i = 0; i <BookNumbers; i++)
            {
                 Console.WriteLine("Enter the book title: ");
                string title = Console.ReadLine();        
                Console.WriteLine("Enter the book Author: ");
                string author = Console.ReadLine(); 
                Console.WriteLine("publisher name: ");
                string publisher = Console.ReadLine(); 
               Console.WriteLine("Enter book ISBN: ");
                int isbn = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter libraryNumber: ");
                string libraryNumber = Console.ReadLine(); 
                Library library = new Library(title, author, publisher, DateTime.Now, isbn, libraryNumber);
            }
            Library.BookInfo(); 
            Console.WriteLine("Enter the author name of the book you want to delete");
            string DeleteBook= Console.ReadLine();
           foreach (var item in Library.books)
           {
               if (item.BookAuthor == DeleteBook)
               {
                   Library.DeleteBook(item.BookAuthor);
               }
           }          

        }    
    }
}