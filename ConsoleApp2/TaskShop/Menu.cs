using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TaskShop
{
    static class Menu
    {
        public static void Buy(Shop shop)
        {
            Console.WriteLine("Enter Producttype:(use 'c' for coffee and 't' for tea");
            string type = Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price:");
            double price = Convert.ToDouble(Console.ReadLine());
            if (shop.products.Any(p => p.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine("You have this product");
            }
            else
            {
                if (type == "c")
                {
                    shop.products.Add(new Coffee { Name = name, Count = count, Price = price });
                }
                else if (type == "t")
                {
                    shop.products.Add(new Tea { Name = name, Count = count, Price = price });
                }
                else
                {
                    Console.WriteLine("Error: Choose 't' or 'c'");
                }
            }
            
        }
        public static void Sell(Shop shop)
        {
            Console.WriteLine("Enter product name to sell");
            string name = Console.ReadLine();
            Console.WriteLine("Enter count");
            int count = Convert.ToInt32(Console.ReadLine());
            Product product = shop.products.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                Console.WriteLine("You don't have this product");
                return;
            }
            if(product.Count < count)
            {
                Console.WriteLine("You don't have "+count+" products");
            }
            else
            {
                product.Count -= count;
                shop.TotalIncome += product.Price * count;
                Console.WriteLine($"Total income is: {shop.TotalIncome}");
            }
        }
    }
}
