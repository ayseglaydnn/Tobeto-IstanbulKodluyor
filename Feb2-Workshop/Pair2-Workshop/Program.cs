using ConsoleAppTobeto2.Business.Concretes;
using ConsoleAppTobeto2.DataAccess.Concretes.InMemory;
using ConsoleAppTobeto2.Entities;


Console.WriteLine("Hello, World!");
Product product1 = new Product(); //referans oluşturma
product1.Id = 1;
product1.Name = "Laptop";
product1.Description = "Aşırı güçlü bir laptop";
product1.UnitPrice = 50000;
product1.DiscountRate = 10; //referans değeri verme

Product product2 = new Product(2, "GSM", "Samsung bişey", 70000);


ProductManager productManager = new ProductManager(new ImProductDal());
productManager.Add(product2);
foreach(var product in productManager.GetProducts())
{
    Console.WriteLine(product.Name);
}

Category category1 = new Category(4,"xxx");

CategoryManager categoryManager = new CategoryManager(new ImCategoryDal());
categoryManager.Add(category1);

foreach (var category in categoryManager.GetCategories())
{
    Console.WriteLine(category.Name);
}


