using ConsoleAppTobeto2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTobeto2.DataAccess.Concretes.InMemory
{
    public class ImProductDal
    {
        List<Product> products = new List<Product>();
        public ImProductDal()
        {
            
            products.Add(new Product
            {
                Id = 1,
                Name = "Elma",
                UnitPrice = 10,
                Description = "Kırmızı Elma",
                DiscountRate = 10
            });
            
        }
        public void Add(Product product) 
        {
            products.Add(product);
        }
        public List<Product> GetProducts() 
        {
            return products;
        }


    }
}
