using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    public class product
    {
        public string name;
        public string category;
        public double price;
        public int stockQuantity;
        public int minStockQuantity;    
        public product()
        {
            name = "unknown";
            category = "unknown";
            price = 0;
            stockQuantity = 0;
            minStockQuantity = 0;

        }
        public product(string name, string category, double price, int stockQuantity, int minStockQuantity)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stockQuantity = stockQuantity;
            this.minStockQuantity = minStockQuantity;
        }
        public product(product p)
        {
            name = p.name;
            category = p.category;
            price = p.price;
            stockQuantity = p.stockQuantity;
            minStockQuantity = p.minStockQuantity;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {name}, Category: {category}, Price: {price}, Stock: {stockQuantity}, Min Stock: {minStockQuantity}");
        }
        public double GetPrice()
        {
            return price;
        }
        public double CalculateSalesTax()
        {
            if (category.ToLower() == "groceries")
                return price * 0.10;
            else if (category.ToLower() == "fruits")
                return price * 0.05;
            else
                return price * 0.15;
        }
        public bool NeedsReorder()
        {
            return stockQuantity < minStockQuantity;
        }
    }
}
