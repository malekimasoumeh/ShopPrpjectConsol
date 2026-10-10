using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectConsol
{
    internal class LaptopDiscountStrategyFactory
    {
        public IDisCountStrategy Create(laptopType type)
        {
            if (type == laptopType.Special)
            {
                return new SpecialLaptopDisCountStrategy();
            }
            if (type == laptopType.Normal)
            {
                return new NormalLaptopDiscountStrategy();
            }
            throw new ArgumentException("No Strategy Found");
        }
    }
}
