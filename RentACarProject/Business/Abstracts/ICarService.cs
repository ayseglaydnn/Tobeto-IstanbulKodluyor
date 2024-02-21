using Business.Requests.Cars;
using Business.Responses.Cars;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICarService
    {
        Task<CreateCarResponse> AddAsync(CreateCarRequest request);
        Task<IDataResult<List<GetAllCarResponse>>> GetAllAsync();
    }
}
