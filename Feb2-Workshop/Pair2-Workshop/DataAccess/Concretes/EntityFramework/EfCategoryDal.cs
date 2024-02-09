using ConsoleAppTobeto2.DataAccess.Abstracts;
using ConsoleAppTobeto2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTobeto2.DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        List<Category> categories = new List<Category>();
        public EfCategoryDal()
        {

            categories.Add(new Category
            {
                Id = 1,
                Name = "Market",

            });
            categories.Add(new Category
            {
                Id = 2,
                Name = "Mağaza",

            });
            categories.Add(new Category
            {
                Id = 3,
                Name = "Elektronik",

            });

        }
        public void Add(Category category)
        {
            categories.Add(category);
        }
        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}
