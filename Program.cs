using System;
using System.Collections.Generic;
using System.Linq;

namespace Ôn_tập
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Laptop", Price = 1500, Category = "Electronics" },
                new Product { Id = 2, Name = "Phone", Price = 800, Category = "Electronics" },
                new Product { Id = 3, Name = "Mouse", Price = 200, Category = "Accessories" },
                new Product { Id = 4, Name = "Keyboard", Price = 300, Category = "Accessories" },
                new Product { Id = 5, Name = "Monitor", Price = 600, Category = "Electronics" },
                new Product { Id = 6, Name = "USB", Price = 100, Category = "Accessories" }
            };

            var expensive = products.Where(p => p.Price > 500);
            var sorted = products.OrderBy(p => p.Price);
            var cheapest = products.OrderBy(p => p.Price).Take(3);

            Console.WriteLine("Sản Phẩm giá > 500:");
            foreach (var p in expensive)
                Console.WriteLine($"{p.Name} : {p.Price}");

            Console.WriteLine("\nSắp xếp theo giá tăng dần:");
            foreach (var p in sorted)
                Console.WriteLine($"{p.Name} : {p.Price}");

            Console.WriteLine("\n3 Sản phẩm rẻ nhất:");
            foreach (var p in cheapest)
                Console.WriteLine($"{p.Name} : {p.Price}");

            Console.Write("\nNhập tên sản phẩm: ");
            string keyword = Console.ReadLine();

            var search = products.Where(p => p.Name.ToLower().Contains(keyword.ToLower()));
            foreach (var p in search)
                Console.WriteLine($"{p.Name} :{p.Price}");

            double total = products.Sum(p => p.Price);
            double avg = products.Average(p => p.Price);

            Console.WriteLine($"\nTổng giá trị: {total}");
            Console.WriteLine($"Giá trung bình: {avg}");
        }
    }
}