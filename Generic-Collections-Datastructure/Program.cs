using Generic_Collections_Datastructure.Models;

namespace Generic_Collections_Datastructure
{
    class Program
    {
        static void Main(string[] args)
        {



            Library student = new Library();
            Book book = new Book("Secret", 223);
            Book book1 = new Book("The last guy", 332);
            Book book2 = new Book("Paulina Cohenn", 4342);
            Book book3 = new Book("Before WWI", 33350);
            book.Sell();
            book1.Add();
            student.ShowInfo();
            student.GetBookById();
            student.RemoveById();

        }
    }
