using ConsoleAppTobeto2.DataAccess.Abstracts;
using ConsoleAppTobeto2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTobeto2.DataAccess.Concretes.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        List<Product> products = new List<Product>();
        public EfProductDal()
        {

            products.Add(new Product
            {
                Id = 1,
                Name = "Elma EF",
                UnitPrice = 10,
                Description = "Kırmızı Elma",
                DiscountRate = 10
            });
            products.Add(new Product
            {
                Id = 2,
                Name = "Armut EF",
                UnitPrice = 20,
                Description = "Sulu armut",
                DiscountRate = 20
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
