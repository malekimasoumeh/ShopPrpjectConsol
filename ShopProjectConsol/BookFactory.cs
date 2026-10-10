using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectConsol
{
    internal class BookFactory
    {
        private readonly IdiscountStrategyFactory _discountFactory;
        public BookFactory (IdiscountStrategyFactory discountFactory)
        {
            _discountFactory = discountFactory;
        }

        public Book Create (string name, decimal price, string author, int pagecount, BookType bookType)
        {


            IDisCountStrategy Strategy = _discountFactory.Create(bookType);
            return new Book(name, price, author, pagecount, bookType, Strategy);
        }
    }
}
