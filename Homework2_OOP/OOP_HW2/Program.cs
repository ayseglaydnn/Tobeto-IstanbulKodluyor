using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new FakeBankService());
            productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 },
                new Customer { Id = 1, Name = "Engin", DiscountStrategy = new StudentDiscountStrategy()});

        }

        class Customer : IEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IDiscountStrategy DiscountStrategy { get; set; }
            // student, officer, none

        }
        interface IEntity
        {
        }
        class Product : IEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }


        }
        class ProductManager : IProductService
        {
            private IBankService _bankService;
            public ProductManager(IBankService bankService)
            {
                _bankService = bankService;
            }
            public void Sell(Product product, Customer customer)
            {

                decimal price = customer.DiscountStrategy.ApplyDiscount(product.Price); //indirim uygulandı

                CurrencyRate currencyRate = new CurrencyRate { Currency = (CurrencyType)1, Price = price };

                price = _bankService.ConvertRate(currencyRate); // döviz kuru dönüştürüldü
                Console.WriteLine($"{customer.Name} ürünü satın aldı. {price} {currencyRate.Currency} ödeme alındı");
                Console.ReadLine();
            }

        }
        interface IProductService
        {
            void Sell(Product product, Customer customer);
        }


        class FakeBankService : IBankService
        {
            public decimal ConvertRate(CurrencyRate currencyRate)
            {
                decimal coefficient;

                switch (currencyRate.Currency)
                {
                    case CurrencyType.TL:
                        coefficient = (decimal)1;
                        break;
                    case CurrencyType.Dollar:
                        coefficient = (decimal)5.25;
                        break;
                    case CurrencyType.Euro:
                        coefficient = (decimal)6.10; 
                        break;
                    default:
                        throw new ArgumentException("Geçersiz para birimi");
                }
                return currencyRate.Price / coefficient;
            }
        }

    }
    interface IBankService
    {
        decimal ConvertRate(CurrencyRate currencyRate);
    }
    public enum CurrencyType
    {
        TL = 0,
        Dollar = 1,
        Euro = 2
    }
    class CurrencyRate
    {
        public decimal Price { get; set; }
        public CurrencyType Currency { get; set; }
    }
    class CentralBankServiceAdapter : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            CentralBankServise centralBankServise = new CentralBankServise();
            return centralBankServise.ConvertCurrency(currencyRate);
        }
    }
    //Merkez bankası
    class CentralBankServise
    {
        public decimal ConvertCurrency(CurrencyRate currencyRate)
        {
            decimal coefficient;

            switch (currencyRate.Currency)
            {
                case CurrencyType.TL:
                    coefficient = (decimal)1;
                    break;
                case CurrencyType.Dollar:
                    coefficient = (decimal)5.23;
                    break;
                case CurrencyType.Euro:
                    coefficient = (decimal)6.09;
                    break;
                default:
                    throw new ArgumentException("Geçersiz para birimi");
            }
            return currencyRate.Price / coefficient;
        }
    }

    // Discount Rate
    interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal price);
    }

    class DefaultDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price; 
        }
    }

    class StudentDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.90m; // %10 indirim
        }
    }

    class OfficerDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.80m; // %20 indirim
        }
    }
}