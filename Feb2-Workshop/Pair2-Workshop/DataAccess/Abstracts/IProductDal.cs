using ConsoleAppTobeto2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTobeto2.DataAccess.Abstracts
{
    public interface IProductDal
    {
        void Add(Product product);
        List<Product> GetProducts();
    }
}
