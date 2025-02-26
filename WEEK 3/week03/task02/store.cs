using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
   public class store
    {
        public List<product> products = new List<product>();
        public void AddProduct()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Category (Groceries/Fruit): ");
            string category = Console.ReadLine();
            Console.Write("Enter Price:");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter Stock Quantity: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimum Stock Quantity: ");
            int minStock = int.Parse(Console.ReadLine());
            product p =new product(name, category, price, stock, minStock);
            products.Add(p);
            Console.WriteLine("Product Added Successfully! \n");
            Console.ReadKey ();
        }
        public void ViewAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Console.WriteLine("\n----------------->All Products<-----------------");
            foreach (product p in products)
            {
                p.Display();
            }

        }
        public void FindMostExpensiveProduct()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            product mostExpensive = products[0];
            foreach (product p in products)
            {
                if (p.GetPrice() > mostExpensive.GetPrice())
                {
                    mostExpensive = p;
                }
            }

            Console.WriteLine("\nMost Expensive Products Are :");
            mostExpensive.Display();
        }
        public void ViewSalesTax()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Console.WriteLine("\nSales Tax of All Products:");
            foreach (product p in products)
            {
                Console.WriteLine($"Product: {p.name}, Sales Tax: {p.CalculateSalesTax()}");
            }
        }
        public void ViewReorderProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            Console.WriteLine("\nProducts to be Ordered:");
            foreach (product p in products)
            {
                if (p.NeedsReorder())
                {
                    p.Display();
                }
            }
        }
    }

}
