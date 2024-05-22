﻿namespace TaskShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop products = new Shop();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Buy or sell product");
                Console.WriteLine("Select '1' to buy");
                Console.WriteLine("Select '2' to sell");
                Console.WriteLine("Select '3' to exit");
              
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Menu.Buy(products); break;
                    case 2:Menu.Sell(products); break;
                    case 3: exit = true; break;
                    
                    default: Console.WriteLine("Error: Enter '1' or '2'"); break;
                }
            }
        }
    }
}
