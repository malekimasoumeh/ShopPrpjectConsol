using System.Data;

namespace ShopProjectConsol
{
    internal abstract class Product
    {
        private static int _id;
        private string _name = string.Empty;
        private decimal _price;
        private int _stock;
        public ProductCategory Category { get;}
        

        public int Id
        {
            get;
            
        }
        public string Name
        {
            get { return _name; }
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("name is invalid");
                _name = value;
            }
          
        }
        public decimal Price
        {
            get { return _price; }
             private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("price must be greater than zero");
                _price = value;
            }
        }
        public int Stock
        {
            get { return _stock; }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("stock cannot be negative");
                _stock = value;
            }
        }
        public Product(string name, decimal price,ProductCategory category)
        {
            Name = name;
            Price = price;
            Stock = 0;
            Category=category;
            Id = _id++;
        }
       
        
        public void AddStock(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(" it must be greater than 0");
            }
            Stock += amount;
        }
        public void RemoveStock(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("can not be negative");
            }
            if (amount > Stock)
            {
                throw new InvalidOperationException("Insufficient balance. ");
            }
            Stock -= amount;
        }

        public abstract void DisplayInfo();

        public void ChangePrice(decimal newprice)
        {
            if (newprice > 0)
            {
                Price=newprice; 
            }
            else 
               throw new ArgumentOutOfRangeException(nameof (newprice));
        }

  
    }
    }
