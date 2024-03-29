namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                Id = 1,
                BrandName = "Koton",
                Model="Kofta",
                Price=20,
                Income=150,
                Count=30,
            };
            product.Sale();
        }
    }
    public class Product
    { 
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Cost { get; set; }
        public int Income { get; set; }
        public int Count { get; set; }

        public Product(int Id,string brandname,string model,int price,int cost,int income,int count)
        {
            Id = Id;
            BrandName = brandname;
            Model = model;
            Price = price;
            Cost = cost;
            Income = income;
            Count = count;
                
        }
        public Product()
        {

        }

       
        public void Sale()
        {
            if(Income<0)
            {
                Income= 0;
                Console.WriteLine(Income);
            }
            else
            {
                Console.WriteLine($"{Income} gelir");
            }
        }
    }

}

