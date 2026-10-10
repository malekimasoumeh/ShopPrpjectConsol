using System.IO.Pipes;

namespace ShopProjectConsol
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int choose;
            Inventory inventory = new Inventory();

            string name;
            decimal price;
            ConsoleUI ui = new ConsoleUI();
            //while (true)
            //{

            //ui.ShowMenue();
            //choose=ui.SelectionMenue();

            //    switch (choose)
            //    {
            //        case 1:
            //        name = ui.ReadProductName();
            //        ProductCategory category = ui.ReadCategory();
            //        price = ui.ReadPrice();
            //        Product pro = new Product(name, price, category);
            //        inventory.AddProduct(pro);
            //        break;
            //        case 2:

            //        name = ui.ReadProductName();
            //        if (inventory.RemoveProduct(name) == true)
            //                Console.WriteLine("product deleted");
            //            else
            //                Console.WriteLine("invalid name");
            //                break;
            //        case 3:
            //        IReadOnlyList<Product> _products = inventory.GetAllProduct();
            //        ui.DisplayAllProduct(_products);    
            //        break;

            //        case 4:
            //        name = ui.ReadProductName();
            //        Product? product=inventory.FindProduct(name);
            //        ui.Display(product);
            //                break;
            //        case 5:

            //           category = ui.ReadCategory();
            //           List<Product> _productbycategory= inventory.FindByCategory(category);
            //           ui.DisplayAllProduct(_productbycategory);
            //        break;
            //        case 6:
            //         category = ui.ReadCategory();
            //         Console.WriteLine($" number of {category} is: {inventory.GetProductcountByCategory(category)}");
            //        break;
            //    case 7:
            //        IReadOnlyList<Product> productordered = inventory.GetProductOrderByPrice();
            //        ui.DisplayAllProduct(productordered);

            //        break;
            //    case 8:
            //            Console.WriteLine("Goodbye...");
            //            return;

            //        default:
            //            Console.WriteLine(" invalid selection");
            //            break;
            //    }

            //}


            /////////////////////////////////////////////////////////inheritanceand poly morphysm

            BookType type = BookType.Normal;
           
            var strategies = new Dictionary<BookType, IDisCountStrategy> { {BookType.Normal, new NormalBookDisCountStrategy() },
                { BookType.Special , new SpecialDiscountStrategy()}
        };
            DiscountStrategyFactory discountFactory = new DiscountStrategyFactory(strategies);
            BookFactory bookFactory = new BookFactory (discountFactory);
            Book book = bookFactory.Create("B1", 15, "ali", 120, type);
            book.ApplyDiscount(30);
          
            ui.Display(book);
        ////LaptopDiscountStrategyFactory laptopfactory= new LaptopDiscountStrategyFactory ();
        ////    laptopType Laptoptype= laptopType.Normal;
        ////    Laptop laptop=new Laptop("LP1", 180,"Intel","350",laptopfactory.Create(Laptoptype), Laptoptype);
        ////    laptop.ApplyDiscount(10);
        ////    ui.Display(laptop);
        } }
}

