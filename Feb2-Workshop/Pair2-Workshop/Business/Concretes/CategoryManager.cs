using ConsoleAppTobeto2.DataAccess.Concretes.InMemory;
using ConsoleAppTobeto2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTobeto2.Business.Concretes
{
    public class CategoryManager
    {
        ImCategoryDal categoryDal = new ImCategoryDal();
        public void Add(Category category)
        {
            //business rules
            categoryDal.Add(category);
        }
        public List<Category> GetCategories()
        {
            return categoryDal.GetCategories();
        }
    }
}
