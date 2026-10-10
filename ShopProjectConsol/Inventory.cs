using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProjectConsol
{
    internal class Inventory
    {
     
        private List<Product> _products=new List<Product>(); 

       
        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw  new ArgumentNullException(nameof(product));
            }
            if(_products.Any(p=>p.Name== product.Name))
            {
                throw new InvalidOperationException("Product already exists.");
            }
              
                    _products.Add(product);
                    
        }
        public bool RemoveProduct(string name)
        {
            Product? product = FindProduct(name);

            if (product == null)
            {
               return false;
            }
            _products.Remove(product);
            return true;
        }
        public  IReadOnlyList<Product> GetAllProduct ()
        { 
           
            return _products;
           
        }
        public Product? FindProduct(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is requiered");
            }
            return _products.FirstOrDefault(p => p.Name == name);
          
        }

        public List<Product> FindByCategory(ProductCategory category)
        {
            return _products.Where(pro => pro.Category == category).ToList(); 
            
                
        }
        public int GetProductcountByCategory(ProductCategory category)
        {
            return _products.Count(p=>p.Category==category);
        }
        public IReadOnlyList<Product> GetProductOrderByPrice()
        {
            return _products.OrderBy(p => p.Price).ToList();
             
        }
        /////////////////////////////////////////////////////////inheritanceand poly morphysm
        ///
       

        
    }
}
