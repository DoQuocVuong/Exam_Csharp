using System;

namespace ConsoleApplication9
{
    public class Product
    { 
        int ProductID;
        string Name;
        string Price;
        public int ProductId
        {
            get => ProductID;
            set => ProductID = value;
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public string Price1
        {
            get => Price;
            set => Price = value;
        }
//        public Product(int productId, string name, string price)
//        {
//            ProductID = productId;
//            Name = name;
//            Price = price;
//        }
        public  void Add()
        {
            ProductID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input product ID: ");
            Name = Console.ReadLine();
            Console.WriteLine("Input product's name: ");
            Price = Console.ReadLine();
            Console.WriteLine("Input product's price: ");
        }

        public void Display()
        {
            Console.WriteLine("Product ID: "+ ProductId);
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Price: "+ Price);
        }

        public void Delete()
        {
            Console.WriteLine("Choose the product ID you want to delete: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Name.Remove(x);
        }

        public void Menu()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by ID");
            Console.WriteLine("4. Exit");
            Console.WriteLine("-----------------------------");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Add();
                    Menu();
                    break;
                case 2:
                    Display();
                    Menu();
                    break;
                case 3:
                    Delete();
                    Menu();
                    break;
                case 4:
                    Console.WriteLine("End process.");
                    return;

            }
        }
        public static void Main(string []arg){
        Product p = new Product();
        p.Menu();
        }
    }
}