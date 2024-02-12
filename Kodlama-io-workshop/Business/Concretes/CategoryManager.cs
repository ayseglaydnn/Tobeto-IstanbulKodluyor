using Kodlama_Io_WorkShop.Business.Abstracts;
using Kodlama_Io_WorkShop.Business.Dtos.Requests;
using Kodlama_Io_WorkShop.Business.Dtos.Responses;
using Kodlama_Io_WorkShop.DataAccess.Abstracts;
using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(CreateCategoryRequest category)
        {
            Category categoryToCreate = new();
            categoryToCreate.CategoryName = category.Name;
            _categoryDal.Add(categoryToCreate);
        }

        

        public List<GetAllCategoryResponse> GetCategories()
        {
            List<GetAllCategoryResponse> category = new List<GetAllCategoryResponse>();
 
            foreach (var item in _categoryDal.GetCategories())
            {
                GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse();
                getAllCategoryResponse.CategoryId = item.CategoryId;
                getAllCategoryResponse.CategoryName = item.CategoryName;
                category.Add(getAllCategoryResponse);
            }
            return category;
        }
        public void Delete(int categoryId)
        {
            Category deleteToCategory = _categoryDal.GetByIdCategory(categoryId);
            if (deleteToCategory != null)
            {
                _categoryDal.Delete(deleteToCategory);
            }
            else
            {
                // Handle category not found error
                throw new Exception("Category not found");
            }
        }

        public void Update(int categoryId, UpdateCategoryRequest category)
        {
            Category updateToCategory = _categoryDal.GetByIdCategory(categoryId);
            if (updateToCategory != null)
            {
                updateToCategory.CategoryName = category.Name;
                _categoryDal.Update(updateToCategory);
            }
            else
            {
                // Handle category not found error
                throw new Exception("Category not found");
            }
        }
    }
}
