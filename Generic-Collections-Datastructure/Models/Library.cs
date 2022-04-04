using System;
using System.Collections.Generic;

namespace Generic_Collections_Datastructure.Models
{
    class Library
    {


        public int BookLimit { get; set; }

        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void GetBookById(int? id)
        {


            int? ID = null;
            ID = id;

        }
        public void RemoveById(int? id)
        {
            foreach (var item in books)
            {
                if (item.ID==id)
                {
                    books.Remove(item);
                    Console.WriteLine($"{ item.Name},{item.PageCount},{item.AuthorName},{item.Price},{item. ID});
                }

            }

        }

        internal void RemoveById()
        {
            throw new NotImplementedException();
        }

        internal void GetBookById()
        {
            throw new NotImplementedException();
        }

        internal void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}