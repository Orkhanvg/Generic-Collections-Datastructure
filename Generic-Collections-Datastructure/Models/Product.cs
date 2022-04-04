namespace Generic_Collections_Datastructure.Models
{
    public abstract class Product
    {


        private static int _id;
        public  int ID { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public static int Count { get; set; }
        public  double TotalInCome { get; set; }

        public abstract void Sell();
        public abstract void ShowInfo();

        public Product(string name, double price, int count, double totalincome, int id)
        {

            ID = id;
            ID++;
            ID = ID;
            Name = name;
            Price = price;
            Count = count;
            TotalInCome = totalincome;
           


        }


    }
}
