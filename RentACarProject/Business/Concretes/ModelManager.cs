using AutoMapper;
using Business.Abstracts;
using Business.Requests.Models;
using Business.Responses.Brands;
using Business.Responses.Models;
using DataAccess.Abstracts;
using DataAccess.Concretes.Repositories;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ModelManager : IModelService
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public ModelManager(IModelRepository modelRepository, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
        }

        public async Task<CreateModelResponse> AddAsync(CreateModelRequest request)
        {
            Model model = _mapper.Map<Model>(request);
            await _modelRepository.Add(model);

            //Model model = new Model();
            //model.BrandId = request.BrandId;
            //model.Name = request.Name;
            //await _modelRepository.Add(model);

            CreateModelResponse response = _mapper.Map<CreateModelResponse>(model);

            //CreateModelResponse response = new CreateModelResponse();
            //response.BrandId = model.BrandId;
            //response.Name = model.Name;
            //response.CreatedDate = model.CreatedDate;

            return response;
        }

        public async Task<List<GetAllModelResponse>> GetAllAsync()
        {

            //AutoMapper eklenecek

            List<Model> models = await _modelRepository.GetAll(include: x => x.Include(x => x.Brand));
            List<GetAllModelResponse> responses = _mapper.Map<List<GetAllModelResponse>>(models);


            //manuel mapppng
            //List<GetAllModelResponse> responses = new List<GetAllModelResponse>();
            //foreach (Model model in models)
            //{
            //    GetAllModelResponse response = new GetAllModelResponse();
            //    response.Id = model.Id;
            //    response.BrandId = model.BrandId;
            //    response.Name = model.Name;
            //    response.BrandName = model.Brand.Name;
            //    responses.Add(response);
            //}
            return responses;
        }
    }
}
