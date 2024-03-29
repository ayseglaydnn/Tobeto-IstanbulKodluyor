﻿using AutoMapper;
using Business.Abstracts;
using Business.Requests.Cars;
using Business.Responses.Cars;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarManager : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarManager(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<CreateCarResponse> AddAsync(CreateCarRequest request)
        {
            Car car = _mapper.Map<Car>(request);
            await _carRepository.Add(car);

            CreateCarResponse response = _mapper.Map<CreateCarResponse>(car);
            return response;
        }

        public async Task<IDataResult<List<GetAllCarResponse>>> GetAllAsync()
        {
            List<Car> cars = await _carRepository.GetAll(include: x => x.Include(x => x.Model).Include(x => x.Model.Brand));
            List<GetAllCarResponse> responses = _mapper.Map<List<GetAllCarResponse>>(cars);
            return new SuccessDataResult<List<GetAllCarResponse>>(responses, "Listed Successfully");
        }
    }
}
