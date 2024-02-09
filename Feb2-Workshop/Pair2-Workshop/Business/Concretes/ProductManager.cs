using ConsoleAppTobeto2.DataAccess.Concretes.InMemory;
using ConsoleAppTobeto2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTobeto2.Business.Concretes
{
    public class ProductManager
    {
        ImProductDal productDal = new ImProductDal();
        public void Add(Product product)
        {
            //business rules
            productDal.Add(product);
        }
        public List<Product> GetProducts()
        {
            return productDal.GetProducts();
        }
    }
}
