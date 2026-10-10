using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectConsol
{
    internal interface IDisCountStrategy
    {  
        BookType type { get; } 
        decimal ApplyDiscount(decimal price, decimal percent);
        
    }
}
