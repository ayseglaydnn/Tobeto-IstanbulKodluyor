using AutoMapper;
using Business.Abstracts;
using Business.Requests.Brands;
using Business.Responses.Brands;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public BrandManager(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<CreateBrandResponse> AddAsync(CreateBrandRequest request)
        {
            Brand brand = _mapper.Map<Brand>(request);
            await _brandRepository.Add(brand);

            //Brand brand = new Brand();
            //brand.Name = request.Name;
            //await _brandRepository.Add(brand);

            CreateBrandResponse response = _mapper.Map<CreateBrandResponse>(brand);

            //CreateBrandResponse response = new CreateBrandResponse();
            //response.Name = brand.Name;
            //response.CreatedDate = brand.CreatedDate;

            return response;
        }

        public async Task<List<GetAllBrandResponse>> GetAllAsync()
        {
            List<Brand> brands = await _brandRepository.GetAll();
            List<GetAllBrandResponse> responses = _mapper.Map<List<GetAllBrandResponse>>(brands);

            return responses;
        }
    }
}
