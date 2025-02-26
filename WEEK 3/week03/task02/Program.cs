using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            store store = new store();
            while (true)
            {
                Console.WriteLine("\n1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Find Product with Highest Price");
                Console.WriteLine("4. View Sales Tax of All Products");
                Console.WriteLine("5. Products to be Ordered");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        store.AddProduct();
                        break;
                    case 2:
                        store.ViewAllProducts();
                        break;
                    case 3:
                        store.FindMostExpensiveProduct();
                        break;
                    case 4:
                        store.ViewSalesTax();
                        break;
                    case 5:
                        store.ViewReorderProducts();
                        break;
                    case 6:
                        Console.WriteLine("Thanks For Your Corporation");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
