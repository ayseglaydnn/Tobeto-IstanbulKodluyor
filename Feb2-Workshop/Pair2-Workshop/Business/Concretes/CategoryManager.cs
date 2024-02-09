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
    public class CategoryManager
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            //business rules
            _categoryDal.Add(category);
        }
        public List<Category> GetCategories()
        {
            return _categoryDal.GetCategories();
        }
    }
}
