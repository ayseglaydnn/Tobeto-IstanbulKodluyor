using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTobeto2.Entities
{
    public class Product
    {
        //overloading
        public Product()
        {

        }
        public Product(int id, string name, string description, double unitPrice) //constructor oluşturma classla aynı isimde olur
        {
            Id = id;
            Name = name;
            Description = description;
            UnitPrice = unitPrice;
        }//ctor yazıldığında da constructor çalıştırılabilir.

        //property
        public int Id { get; set; } // get okumak, set değer yazamak için (mesela seti kaldırırsak sadece okunabilir demek)
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public double DiscountRate { get; set; }
        public double DiscountedPrice => UnitPrice - (UnitPrice * DiscountRate / 100); //=> Expressions
        public Category Category { get; set; }

    }
}
