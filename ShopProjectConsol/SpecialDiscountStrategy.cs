using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectConsol
{
    internal class SpecialDiscountStrategy:IDisCountStrategy
    {
        public BookType type => BookType.Special;
       public decimal ApplyDiscount(decimal price,decimal percent)
        {
            if (percent > 20 || percent<=0)
                throw new  ArgumentOutOfRangeException("Ou of range");
            else
                return (price - (price * (percent / 100)));
        }
    }
}
