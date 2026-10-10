using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectConsol
{
    internal class Laptop : Product
    {
        private readonly IDisCountStrategy _disCountStrategy;
        public string Cpu { get; }
        public string Ram { get; }
        public laptopType LaptopType { get; }
        public Laptop(string name, decimal price, string cpu, string ram,IDisCountStrategy disCount,laptopType type) : base(name, price, ProductCategory.Digital)
        {
            Cpu = cpu;
            Ram = ram;
            _disCountStrategy = disCount;
            LaptopType=type;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Laptop: {Name} and price : {Price}");
            
            Console.WriteLine($"Cpu: {Cpu} - Ram: {Ram}");
        }


        public void ApplyDiscount(decimal percent)
        {
            decimal NewPrice = _disCountStrategy.ApplyDiscount(Price, percent);
            ChangePrice(NewPrice);
        }
    }

    }
