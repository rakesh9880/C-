using System;
using System.Collections.Generic;

namespace GenericCollectionDemo
{
    public class Product
    {
        public int Product_ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Product_ID = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {Product_ID}, Name: {Name}, Price: ${Price:F2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();

            productList.Add(new Product(101, "Laptop", 899.99));
            productList.Add(new Product(102, "Smartphone", 499.49));
            productList.Add(new Product(103, "Headphones", 99.99));

            Console.WriteLine("List of Products:");
            foreach (Product product in productList)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nEnter Product ID to search: ");
            int searchId = Convert.ToInt32(Console.ReadLine());

            Product foundProduct = productList.Find(p => p.Product_ID == searchId);

            if (foundProduct != null)
            {
                Console.WriteLine($"Product Found: {foundProduct}");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }

            Console.ReadLine();
        }
    }
}
