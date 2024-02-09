using ConsoleAppTobeto2.DataAccess.Abstracts;
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
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            //business rules
            _productDal.Add(product);
        }
        public List<Product> GetProducts()
        {
            return _productDal.GetProducts();
        }
    }
}
