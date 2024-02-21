using AutoMapper;
using Business.Requests.Brands;
using Business.Requests.Models;
using Business.Responses.Brands;
using Business.Responses.Models;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Brands
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreateBrandRequest>().ReverseMap();
            CreateMap<Brand, CreateBrandResponse>().ReverseMap();
            CreateMap<Brand, GetAllBrandResponse>().ReverseMap();
        }
    }
}
