namespace ShopProjectConsol
{
    internal class Book: Product
    {
        private readonly IDisCountStrategy _discountStrategy;
      
        public string Author { get; }
        public int PageCount { get; }
        public BookType BookType { get; }
        public Book(string name, decimal price,string author,int pagecount,BookType bookType,IDisCountStrategy discount) : base(name, price, ProductCategory.Stationery)
        {
            Author = author;
            PageCount = pagecount;
            _discountStrategy = discount;
            BookType = bookType;

        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Name} and price : {Price}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"pageCount: {PageCount}");
        }
        public void ApplyDiscount(decimal percent)
        {
            decimal NewPrice = _discountStrategy.ApplyDiscount(Price, percent);
            ChangePrice(NewPrice);
        }

    }
}
