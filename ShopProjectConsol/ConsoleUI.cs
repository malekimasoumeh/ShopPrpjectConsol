using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShopProjectConsol
{
    internal class ConsoleUI
    {
       
        string name = string.Empty;
        decimal price;

        public ConsoleUI() { }

        public void ShowMenue()
        {

            Console.WriteLine("=== Invertory Menue===");
            Console.WriteLine($"{Environment.NewLine} {Environment.NewLine}" +
                $" 1. Add Product {Environment.NewLine}" +
                $" 2. Remove Product {Environment.NewLine}" +
                $" 3. Show All Product {Environment.NewLine}" +
                $" 4. Find Product {Environment.NewLine}" +
                $" 5. Find Products By Category {Environment.NewLine}" +
                $" 6. number of Products By Category {Environment.NewLine}" +
                $" 7. product order by price {Environment.NewLine}" +
                $" 8. Exite {Environment.NewLine}" +
                $"{Environment.NewLine} Choose:");
        }

        public ProductCategory ReadCategory()
        {
            
            int choose=-1;
            while (true)
            {
                ShowCategoryMenu();
                Console.WriteLine($"{Environment.NewLine} Choose Number:");
                if (int.TryParse(Console.ReadLine(), out choose))
                {
                    if (Enum.IsDefined(typeof(ProductCategory), choose-1))
                    {
                        
                        return(ProductCategory)choose-1; 

                    }
                }

                Console.WriteLine("Invalid inpute");
            }
            

        }

        private void ShowCategoryMenu()
        {
            int i = 1;
            Console.WriteLine("=== Category Menue===");
            Console.WriteLine($"{Environment.NewLine} {Environment.NewLine}");
            foreach (ProductCategory category in Enum.GetValues<ProductCategory>())
            {
                Console.WriteLine($"{i++}- {category}{Environment.NewLine}");

            }

        }

        public int SelectionMenue()
        {
            int selection;
            if (int.TryParse(Console.ReadLine(), out selection))
            {
                if (selection < 0)
                {
                    Console.WriteLine("it must be greater than 0");
                    selection = 0;
                }
            }
            else
            {
                Console.WriteLine("it must be number");
                selection = 0;
            }
            return selection;

        }
        public string ReadProductName()
        {
            while (true)
            {
                Console.Write("please enter name of goods : ");
                name=Console.ReadLine();
                if (int.TryParse(name, out _))
                {
                    Console.WriteLine(" Name must be Character ");
                }
                else
                {
                    break;
                }

            }
            return name;
        }
        public decimal ReadPrice()
        {
            while (true)
            {
                Console.WriteLine($"please enter price of {name}: ");
                if (decimal.TryParse(Console.ReadLine(), out price))
                {
                    if (price <= 0)
                    {
                        Console.WriteLine("it must be greater than 0");

                    }
                    else
                        break;
                }
                else
                {
                    Console.WriteLine(" Price must be Number");
                }
               
            }
            return price;

        }
        
        public void Display(Product? pro)
        {
            if (pro == null)
            {
                Console.WriteLine("invalid product");
            }
            else
            {
                Console.WriteLine($"ID: {pro.Id}");
                Console.WriteLine($"Name: {pro.Name}");
                Console.WriteLine($"Category: {pro.Category}");
                Console.WriteLine($"Price: {pro.Price}");
                Console.WriteLine($"Stock: {pro.Stock}");
                Console.WriteLine("--------------------------");
            }
        }

        public void DisplayAllProduct(IReadOnlyList<Product> product)
        {
            if (product.Count == 0)
            {
                Console.WriteLine("Invertory is empty");
                
            }
            foreach (Product product1 in product)
            {

                Display(product1);

            }

            
        }
        //////////////////////////////////////////////////////////inheritanceand poly morphysm

        public void DisplayAllProductinheritence(IReadOnlyList<Product> products)
        {
            foreach(Product product in products)
            {
                product.DisplayInfo();
            }

        }
    }
}
