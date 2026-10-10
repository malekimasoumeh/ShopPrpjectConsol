using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectConsol
{
    internal class NormalLaptopDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price, decimal percent)
        {
            if(percent>=20 || percent <= 0)
            {
                throw new ArgumentOutOfRangeException( nameof(percent));
            }
            return (price - (price * (percent / 100)));
        }
    }
}
