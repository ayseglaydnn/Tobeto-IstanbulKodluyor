﻿using Business.Requests.Brands;
using Business.Responses.Brands;
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
        Task<CreateBrandResponse> AddAsync(CreateBrandRequest request);
        Task<List<GetAllBrandResponse>> GetAllAsync();
    }
}
