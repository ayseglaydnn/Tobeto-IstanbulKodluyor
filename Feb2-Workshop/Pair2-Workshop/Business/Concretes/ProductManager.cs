using ConsoleAppTobeto2.Business.Abstracts;
using ConsoleAppTobeto2.Business.Dtos.Requests;
using ConsoleAppTobeto2.Business.Dtos.Responses;
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
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(CreateProductRequest product)
        {
            Product productToCreate = new Product();
            productToCreate.Description = product.Description;
            productToCreate.UnitPrice = product.UnitPrice;
            productToCreate.Name = product.Name;
            productToCreate.DiscountRate = product.DiscountRate;

            //business rules
            _productDal.Add(productToCreate);
        }
        public List<GetAllProductResponse> GetProducts()
        {
            List<GetAllProductResponse> products = new List<GetAllProductResponse>();

            foreach (var item in _productDal.GetProducts())
            {
                GetAllProductResponse getAllProductResponse = new GetAllProductResponse();
                getAllProductResponse.UnitPrice = item.UnitPrice;
                getAllProductResponse.Description = item.Description;
                getAllProductResponse.Name = item.Name;
                getAllProductResponse.Id = item.Id;
                getAllProductResponse.DiscountRate = item.DiscountRate;
            }
            
            return products;
        }
    }
}
