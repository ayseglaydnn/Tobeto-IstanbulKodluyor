using ConsoleAppTobeto2.Business.Abstracts;
using ConsoleAppTobeto2.Business.Dtos.Requests;
using ConsoleAppTobeto2.Business.Dtos.Responses;
using ConsoleAppTobeto2.DataAccess.Abstracts;
using ConsoleAppTobeto2.DataAccess.Concretes.EntityFramework;
using ConsoleAppTobeto2.DataAccess.Concretes.InMemory;
using ConsoleAppTobeto2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTobeto2.Business.Concretes
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(CreateCategoryRequest category)
        {
            //business rules
            Category categoryToCreate = new Category();
            categoryToCreate.Name = category.Name;

            //business rules
            _categoryDal.Add(categoryToCreate);
        }
        public List<GetAllCategoryResponse> GetCategories()
        {

            List<GetAllCategoryResponse> categories = new List<GetAllCategoryResponse>();

            foreach (var item in _categoryDal.GetCategories())
            {
                GetAllCategoryResponse getAllCategoriesResponse = new GetAllCategoryResponse();
                getAllCategoriesResponse.Id = item.Id;
                getAllCategoriesResponse.Name = item.Name;

            }

            return categories;
        }
    }
}
