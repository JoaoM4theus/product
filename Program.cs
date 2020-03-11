using System;
using System.Globalization;

namespace Product {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity in stock: ");
            int quantity = int.Parse(Console.ReadLine());

            Product p = new Product(name, price, quantity);

            Product p2 = new Product(name, price);

            Product p3 = new Product {
                Name = "TV",
                Price = 500.00,
                Quantity = 20
            };

            Console.WriteLine("Product Data: " + p);

            Console.WriteLine();

            Console.Write("Enter the product number to be added to stock: ");
            int qti = int.Parse(Console.ReadLine());
            p.AddProducts(qti);
            Console.WriteLine();
            Console.WriteLine("Updated data: " + p);

            Console.WriteLine();
            Console.Write("Enter the number of products to be removed from stock: ");
            qti = int.Parse(Console.ReadLine());
            p.RemoveProducts(qti);
            Console.WriteLine();
            Console.WriteLine("Updated data: " + p);

        }
    }
}
