using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectConsol
{
    internal class SpecialLaptopDisCountStrategy
        {
        public decimal ApplyDiscount(decimal price, decimal percent)
        {
            if (percent <= 0 || percent >= 50)
            {
                throw new ArgumentOutOfRangeException(nameof(percent));

            }

            return (price - (price * (percent / 100)));


        }
    }
}
