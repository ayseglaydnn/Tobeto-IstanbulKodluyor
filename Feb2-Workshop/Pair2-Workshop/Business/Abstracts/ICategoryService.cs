using ConsoleAppTobeto2.Business.Dtos.Requests;
using ConsoleAppTobeto2.Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTobeto2.Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(CreateCategoryRequest category);//request
        List<GetAllCategoryResponse> GetCategories();//response
    }
}
