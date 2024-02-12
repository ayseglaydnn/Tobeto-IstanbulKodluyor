using Kodlama_Io_WorkShop.Business.Dtos.Requests;
using Kodlama_Io_WorkShop.Business.Dtos.Responses;
using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Business.Abstracts
{
    public interface ICategoryService
    {
        public void Add(CreateCategoryRequest category);
        void Delete(int categoryId);
        void Update(int categoryId, UpdateCategoryRequest category);
        List<GetAllCategoryResponse> GetCategories();
    }
}
