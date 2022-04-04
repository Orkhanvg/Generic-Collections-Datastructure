namespace Generic_Collections_Datastructure.Models 
using System;

internal class Book : Product
{
   

   

    public Book(string name, double price, int count, double totalincome) : base(name, price, count, totalincome)
    {
    }

    public string AuthorName { get; set; }

    public int PageCount { get; set; }

    public override void Sell()
    {

        if (Count == 0)
        {
            Console.WriteLine("Out of stock");

        }
        else
        {
            Count--;
            TotalInCome++;

        }

    }

    
    

    public override void ShowInfo()
    {
        System.Console.WriteLine($"{ID}, {Name}, {Price}, {Count}, { TotalInCome}, { AuthorName}, {PageCount}");


    }
}
}
