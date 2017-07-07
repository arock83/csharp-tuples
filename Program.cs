using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("pizza", 9.63, 4));
            transactions.Add(("cake", 5.63, 3));
            transactions.Add(("soda", 1.25, 6));
            transactions.Add(("ice cream", 1.90, 3));
            transactions.Add(("napkins", .25, 12));
            double totalSales = 0;
            int totalItems = 0;
            foreach ((string product, double amount, int quantity) t in transactions)
            {
                totalSales += t.amount * t.quantity;
                totalItems += t.quantity;
            }

            Console.WriteLine($"Items Sold Today: {totalItems}");
            Console.WriteLine($"Total Revenue: ${totalSales}");
        }
    }
}
