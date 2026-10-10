using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectConsol
{
    internal class DiscountStrategyFactory:IdiscountStrategyFactory
    {
        private readonly Dictionary<BookType, IDisCountStrategy> _strategies;
        public DiscountStrategyFactory(Dictionary<BookType, IDisCountStrategy> strategies)
        {
            _strategies = strategies;
        } 
    
        public IDisCountStrategy Create(BookType type)
        {  

            if (_strategies.TryGetValue(type,out IDisCountStrategy strategy))
          
                return strategy;

            throw new ArgumentException(" No Strategy Found");
        }
    }
}
