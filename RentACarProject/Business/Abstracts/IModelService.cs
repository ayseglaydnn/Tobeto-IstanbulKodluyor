using Business.Requests.Models;
using Business.Responses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IModelService
    {
        Task<CreateModelResponse> AddAsync(CreateModelRequest reques);
        Task<List<GetAllModelResponse>> GetAllAsync();
    }
}
