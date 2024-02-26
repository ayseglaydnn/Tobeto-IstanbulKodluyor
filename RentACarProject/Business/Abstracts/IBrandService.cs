using Business.Requests.Brands;
using Business.Responses.Brands;
using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        Task<IDataResult<CreateBrandResponse>> AddAsync(CreateBrandRequest request);
        Task<IDataResult<List<GetAllBrandResponse>>> GetAllAsync();
    }
}
